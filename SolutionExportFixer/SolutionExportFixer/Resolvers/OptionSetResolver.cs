﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    [ResolvedType(SolutionComponentType.OptionSet)]
    public class OptionSetResolver : BaseComponentMetadataResolver<RetrieveOptionSetRequest, RetrieveOptionSetResponse>
    {
        public OptionSetResolver(IOrganizationService service) : base(service) { }

        public override IComponent Resolve(SolutionComponent solutionComponent)
        {
            var component = base.Resolve(solutionComponent);
            var response = this.GetResolvedObject(new RetrieveOptionSetRequest
            {
                MetadataId = solutionComponent.ObjectId.Value
            });

            component.Name = response.OptionSetMetadata.Name;
            return component;
        }
    }
}
