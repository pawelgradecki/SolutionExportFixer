using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExportFixer.Model
{
    public interface IComponent
    {
        IComponent Parent { get; set; }

        string Name { get; set; }

        SolutionComponentType Type { get; set; }

        IEnumerable<IComponent> Childs { get; set; }
    }
}
