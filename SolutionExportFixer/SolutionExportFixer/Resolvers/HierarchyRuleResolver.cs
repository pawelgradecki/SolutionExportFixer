﻿using System;
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
    [ResolvedType(SolutionComponentType.HierarchyRule)]
    public class HierarchyRuleResolver : EntityResolver<HierarchyRule>
    {
        public HierarchyRuleResolver(IOrganizationService service) : base(service) { }
    }
}
