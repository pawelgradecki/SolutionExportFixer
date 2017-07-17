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
    [ResolvedType(SolutionComponentType.Attribute)]
    public class AttributeResolver : BaseComponentMetadataResolver<RetrieveAttributeRequest, RetrieveAttributeResponse>
    {
        public AttributeResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
            var component = base.Resolve(solutionComponent);
            var response = this.GetResolvedObject(new RetrieveAttributeRequest
            {
                MetadataId = solutionComponent.ObjectId.Value
            });

            component.Name = response.AttributeMetadata.LogicalName;
            return component;
        }
    }
}
