using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class Permission: Component
    {
        public override IList<IComponent> Children
        {
            get => new List<IComponent>();
        }
        public override void AddChild(IComponent c)
        {
           
        }

        public override void EmptyChildren()
        {
            
        }
    }
}
