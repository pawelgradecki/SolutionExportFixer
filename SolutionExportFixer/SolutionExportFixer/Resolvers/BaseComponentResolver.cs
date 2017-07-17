using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    public abstract class BaseComponentMetadataResolver<TRequest, VResponse> : IComponentResolver
        where TRequest : OrganizationRequest, new()
        where VResponse: OrganizationResponse, new()
    {
        protected IOrganizationService service;
        protected SolutionComponentType type;

        public BaseComponentMetadataResolver(IOrganizationService service)
        {
            this.service = service;
        }

        public virtual IComponent Resolve(SolutionComponent component)
        {
            return new Component
            {
                Type = this.GetType().GetCustomAttribute<ResolvedTypeAttribute>().Type
            };
        }

        protected VResponse GetResolvedObject(TRequest request)
        {
            return (VResponse)this.service.Execute(request);
        }
    }
}