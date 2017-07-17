using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    [ResolvedType(SolutionComponentType.LocalizedLabel)]
    public class LocalizedLablesResolver : BaseComponentMetadataResolver<RetrieveLocLabelsRequest, RetrieveLocLabelsResponse>
    {
        public LocalizedLablesResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
            //TODO TODO TODO
            var component = base.Resolve(solutionComponent);
            var response = this.GetResolvedObject(new RetrieveLocLabelsRequest
            {
            
            });

            component.Name = response.Label.ToString();
            return component;
        }
    }
}
