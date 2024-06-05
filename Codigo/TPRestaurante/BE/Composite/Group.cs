using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class Group: Component
    {
        private IList<IComponent> children = new List<IComponent>();

        public override IList<IComponent> Children => children.ToArray();

        public override void AddChild(IComponent c)
        {
            children.Add(c);
        }

        public override void EmptyChildren()
        {
            children.Clear();
        }
    }
}
