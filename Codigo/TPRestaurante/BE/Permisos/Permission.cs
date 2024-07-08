using System.Collections.Generic;
using BE.Permisos;
using Interfaces;

namespace BE.Permisos
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

        public override object Clone()
        {
            Permission clone = new Permission()
            {
                ID = this.ID,
                Name = this.Name,
                Type = this.Type,
                PermissionType = this.PermissionType
            };

            return clone;
        }
    }
}
