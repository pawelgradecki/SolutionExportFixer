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
    [ResolvedType(SolutionComponentType.DisplayString)]
    public class DisplayStringResolver : EntityResolver<DisplayString>
    {
        public DisplayStringResolver(IOrganizationService service) : base(service) { }
    }
}
