using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Group: Component
    {
        private IList<Component> children = new List<Component>();

        public override IList<Component> Children => children.ToArray();

        public override void AddChild(Component c)
        {
            children.Add(c);
        }

        public override void EmptyChildren()
        {
            children.Clear();
        }
    }
}
