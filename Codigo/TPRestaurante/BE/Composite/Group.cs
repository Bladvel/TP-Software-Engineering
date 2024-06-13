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

        public override object Clone()
        {
            Group clone = new Group()
            {
                ID = this.ID,
                Name = this.Name,
                Type = this.Type,
                PermissionType = this.PermissionType
            };

            foreach (var child in this.Children)
            {
                clone.AddChild((Component)child.Clone());
            }

            return clone;

        }
    }
}
