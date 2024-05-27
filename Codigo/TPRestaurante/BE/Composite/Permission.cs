using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Permission: Component
    {
        public override IList<Component> Children
        {
            get => new List<Component>();
        }
        public override void AddChild(Component c)
        {
           
        }

        public override void EmptyChildren()
        {
            
        }
    }
}
