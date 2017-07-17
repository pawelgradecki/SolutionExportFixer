using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace SolutionExportFixer.Resolvers
{
    public class ResolverFactory
    {
        private IOrganizationService service;
        private Dictionary<SolutionComponentType, IComponentResolver> resolverMap;

        public ResolverFactory(IOrganizationService service)
        {
            this.service = service;
            this.resolverMap = new Dictionary<SolutionComponentType, IComponentResolver>();
            Initialize();
        }

        public IComponentResolver GetResolver(SolutionComponentType type)
        {
            if (resolverMap.ContainsKey(type))
            {
                return resolverMap[type];
            }
            else
            {
                throw new ArgumentException("Provided type has no known resolvers");
            }
        }

        private void Initialize()
        {
            var allComponentResolvers = Assembly.GetExecutingAssembly().GetTypes().Where(t => typeof(IComponentResolver).IsAssignableFrom(t) && t.IsClass);
            foreach (var resolver in allComponentResolvers)
            {
                foreach (var attr in resolver.GetCustomAttributes<ResolvedTypeAttribute>())
                {
                    var resolvedType = attr.Type;
                    this.resolverMap.Add(resolvedType, (IComponentResolver)Activator.CreateInstance(resolver, this.service));
                }
            }
        }
    }
}
