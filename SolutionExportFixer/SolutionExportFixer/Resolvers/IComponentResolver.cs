using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionExportFixer.Model;

namespace SolutionExportFixer.Resolvers
{
    public interface IComponentResolver
    {
        IComponent Resolve(SolutionComponent component);
    }
}
