using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    [ResolvedType(SolutionComponentType.Entity)]
    public class EntityMetadataResolver : BaseComponentMetadataResolver<RetrieveEntityRequest, RetrieveEntityResponse>
    {
        public EntityMetadataResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
            var component = base.Resolve(solutionComponent);
            var response = this.GetResolvedObject(new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.All,
                MetadataId = solutionComponent.ObjectId.Value
            });
            
            component.Name = response.EntityMetadata.LogicalName;
            return component;
        }
    }
}
