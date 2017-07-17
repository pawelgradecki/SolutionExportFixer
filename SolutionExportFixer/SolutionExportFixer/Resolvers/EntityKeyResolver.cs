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
    [ResolvedType(SolutionComponentType.EntityKey)]
    public class EntityKeyResolver : BaseComponentMetadataResolver<RetrieveEntityKeyRequest, RetrieveEntityKeyResponse>
    {
        public EntityKeyResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
             var component = base.Resolve(solutionComponent);
            var respone = this.GetResolvedObject(new RetrieveEntityKeyRequest
            {
                MetadataId = solutionComponent.ObjectId.Value
            });

            component.Name = respone.EntityKeyMetadata.EntityLogicalName;
            return component;
        }
    }
}
