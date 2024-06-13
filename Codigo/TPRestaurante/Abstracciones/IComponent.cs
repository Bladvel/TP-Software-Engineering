using System;
using System.Collections.Generic;


namespace Interfaces
{
    public interface IComponent: ICloneable
    {
        int ID { get; set; }
        string Name { get; set; }
        ComponentType Type { get; set; }
        PermissionType PermissionType { get; set; }
        IList<IComponent> Children { get; }
        void AddChild(IComponent c);
        void EmptyChildren();
    }
}