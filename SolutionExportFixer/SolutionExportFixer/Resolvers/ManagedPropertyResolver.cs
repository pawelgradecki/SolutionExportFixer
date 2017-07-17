using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    [ResolvedType(SolutionComponentType.ManagedProperty)]
    public class ManagedPropertyResolver : BaseComponentMetadataResolver<RetrieveManagedPropertyRequest, RetrieveManagedPropertyResponse>
    {
        public ManagedPropertyResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
            var component = base.Resolve(solutionComponent);
            var respone = this.GetResolvedObject(new RetrieveManagedPropertyRequest
            {
                MetadataId = solutionComponent.ObjectId.Value
            });

            component.Name = respone.ManagedPropertyMetadata.LogicalName;
            return component;
        }
    }
}
