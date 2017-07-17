using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    public class RibbonResolver : BaseComponentMetadataResolver<RetrieveApplicationRibbonRequest, RetrieveApplicationRibbonResponse>
    {
        public RibbonResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
            var component = base.Resolve(solutionComponent);
            var response = this.GetResolvedObject(new RetrieveApplicationRibbonRequest { });

            component.Name = "applicationribbon";
            return component;
        }
    }
}
