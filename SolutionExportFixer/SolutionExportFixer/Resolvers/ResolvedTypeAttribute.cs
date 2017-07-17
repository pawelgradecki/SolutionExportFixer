using System;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal sealed class ResolvedTypeAttribute : Attribute
    {
        private SolutionComponentType type;

        public ResolvedTypeAttribute(SolutionComponentType type)
        {
            this.type = type;
        }

        public SolutionComponentType Type
        {
            get
            {
                return this.type;
            }
        }
    }
}