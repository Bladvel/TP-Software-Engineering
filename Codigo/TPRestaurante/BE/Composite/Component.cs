using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Composite;

namespace BE
{
    public abstract class Component
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public PermissionType Type { get; set; }

        public abstract IList<Component> Children { get; }

        public abstract void AddChild(Component c);

        public abstract void EmptyChildren();

        public override string ToString()
        {
            return Name;
        }
    }
}
