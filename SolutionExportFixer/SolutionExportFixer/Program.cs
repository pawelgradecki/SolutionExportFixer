using System;
using System.Configuration;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using SolutionExportFixer.Model;
using SolutionExportFixer.Resolvers;

namespace SolutionExportFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Please provide solution name");
                return;
            }

            var solutionUniqueName = args[0];

            var orgService = new CrmServiceClient(ConfigurationManager.ConnectionStrings["CRM"].ConnectionString);
            var solutionComponentQuery = new QueryExpression("solutioncomponent");
            solutionComponentQuery.Distinct = true;
            solutionComponentQuery.ColumnSet.AddColumns("objectid", "componenttype", "solutioncomponentid");
            var solutioncomponentSolutionLink = solutionComponentQuery.AddLink("solution", "solutionid", "solutionid");
            solutioncomponentSolutionLink.EntityAlias = "aa";
            solutioncomponentSolutionLink.LinkCriteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName);

            var results = orgService.RetrieveMultiple(solutionComponentQuery);

            var resolverFactory = new ResolverFactory(orgService);

            foreach (var item in results.Entities)
            {
                try
                {
                    var resolver = resolverFactory.GetResolver((SolutionComponentType)item.GetAttributeValue<OptionSetValue>("componenttype").Value);
                    var result = resolver.Resolve(item.ToEntity<SolutionComponent>());
                    Console.WriteLine(result.Name);
                }
                catch
                {
                    //attribute is missing, remove it from solution
                    Console.WriteLine($"Object { item.GetAttributeValue<Guid>("objectid")} is missing. Removing from the solution.");
                    orgService.Delete("solutioncomponent", item.Id);
                }
            }
        }
    }
}
