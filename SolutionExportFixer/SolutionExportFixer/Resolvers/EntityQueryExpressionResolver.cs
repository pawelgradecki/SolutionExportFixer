using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    public class EntityQueryExpressionResolver : IComponentResolver
    {
        private IOrganizationService service;
        private string entityLogicalName;

        public EntityQueryExpressionResolver(IOrganizationService service, string entityLogicalName)
        {
            this.service = service;
            this.entityLogicalName = entityLogicalName;
        }

        public virtual IComponent Resolve(SolutionComponent component)
        {
            var query = new QueryExpression(RibbonCustomization.EntityLogicalName);
            query.Criteria.AddCondition($"{entityLogicalName.ToLower()}id", ConditionOperator.Equal, component.ObjectId);
            var result = this.service.RetrieveMultiple(query);

            return new Component
            {
                Name = result.EntityName
            };
        }
    }
}
