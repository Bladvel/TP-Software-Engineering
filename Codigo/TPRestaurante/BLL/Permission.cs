using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BE.Permisos;
using DAL;
using DAL.FactoryMapper;
using Interfaces;

namespace BLL
{
    public class Permission
    {
        private MP_Permission mpPermission;

        public Permission()
        {
            mpPermission = MpPermissionCreator.GetInstance.CreateMapper() as MP_Permission;
        }

        public List<Component> ListComponents()
        {
            List<Component> list = mpPermission.GetAll();
            return list;
        }


        public void SaveGroup(Group group)
        {
            mpPermission.InsertGroup(group);
        }


        public bool Exist(IComponent component, int id)
        {
            if (component.ID.Equals(id))
            {
                return true;
            }

            foreach (var componentChild in component.Children)
            {
                if (Exist(componentChild, id))
                {
                    return true;
                }
            }

            return false;

        }

        public bool CanAddComponent(IComponent parent, IComponent componentToAdd)
        {
            // Verifica que no estás añadiendo el componente a sí mismo
            if (Exist(parent,componentToAdd.ID) || Exist(componentToAdd, parent.ID))
            {
                return false;
            }

            return true;

        }




        //Obtiene los permisos de la tabla Permisos sin los grupos
        public List<Component> GetPermissions()
        {
            return mpPermission.GetAllPermissions();
        }

        //Obtiene los grupos ya compuestos
        public List<Component> GetGroups()
        {
            return mpPermission.GetAllGroups();
        }


        //Inserta un componente si ya no existe uno con el mismo nombre
        public int InsertComponent(Component component)
        {

            List<Component> permissionList = mpPermission.GetAllWithoutComposite();
            foreach (var permissionComponent in permissionList)
            {
                if (permissionComponent.Name.Equals(component.Name, StringComparison.OrdinalIgnoreCase))
                    return -1;
            }

            return mpPermission.Insert(component);
        }

        

    }
}
