using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    [ResolvedType(SolutionComponentType.AttributePicklistValue)]
    [ResolvedType(SolutionComponentType.AttributeLookupValue)]
    [ResolvedType(SolutionComponentType.ViewAttribute)]
    [ResolvedType(SolutionComponentType.RelationshipExtraCondition)]
    [ResolvedType(SolutionComponentType.EntityRelationshipRole)]
    [ResolvedType(SolutionComponentType.EntityRelationshipRelationships)]
    public class UnknownResolver : IComponentResolver
    {
        public UnknownResolver(IOrganizationService service)
        {

        }

        public IComponent Resolve(SolutionComponent component)
        {
            var componentType = ((SolutionComponentType)component.ComponentType.Value);
            return new Component
            {
                Name = componentType.ToString(),
                Type = componentType
            };
        }
    }
}
