using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExportFixer.Model
{
    class Component : IComponent
    {
        public IComponent Parent { get; set; }
        public string Name { get; set; }
        public SolutionComponentType Type { get; set; }
        public IEnumerable<IComponent> Childs { get; set; }
    }
}
