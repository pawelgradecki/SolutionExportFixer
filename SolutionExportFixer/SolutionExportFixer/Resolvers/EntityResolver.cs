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

    public class EntityResolver : IComponentResolver
    {
        private IOrganizationService service;
        private string entityLogicalName;

        public EntityResolver(IOrganizationService service, string entityLogicalName)
        {
            this.service = service;
            this.entityLogicalName = entityLogicalName;
        }

        public virtual IComponent Resolve(SolutionComponent component)
        {
            var response = this.service.Retrieve(this.entityLogicalName, component.ObjectId.Value, new ColumnSet());

            return new Component
            {
                Name = response.LogicalName
            };
        }
    }

    public class EntityResolver<T> : EntityResolver, IComponentResolver
        where T: Entity, new()
    {
        private IOrganizationService service;

        public EntityResolver(IOrganizationService service) : base(service, new T().LogicalName)
        {
        }
    }
}
