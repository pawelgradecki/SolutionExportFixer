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
    [ResolvedType(SolutionComponentType.AttributeMap)]
    public class AttributeMapResolver : EntityResolver<AttributeMap>
    {
        public AttributeMapResolver(IOrganizationService service) : base(service) { }
    }
}
