using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Interfaces;

namespace BLL
{
    public class Permission
    {
        private MP_Permission mpPermission;

        public Permission()
        {
            mpPermission = new MP_Permission();
        }

        public List<BE.Component> ListComponents()
        {
            List<BE.Component> list = mpPermission.GetAll();
            return list;
        }

        public void UniversalSave(BE.Component component)
        {
            mpPermission.UniversalInsert(component);
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

        //Obtiene los permisos "atomicos" (que uso en el enum)
        public Array GetAtomicPermissions()
        {
            return mpPermission.GetAtomicPermissions();
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
        public int InsertComponent(BE.Component component)
        {

            List<Component> permissionList = mpPermission.GetAllWithoutComposite();
            foreach (var permissionComponent in permissionList)
            {
                if (permissionComponent.Name.Equals(component.Name, StringComparison.OrdinalIgnoreCase))
                    return -1;
            }

            return mpPermission.Insert(component);
        }

        public Group GetGroupByID(int id)
        {
            Group g = GetGroups().FirstOrDefault(c => c.ID.Equals(id)) as Group;
            return g;
        }



        public void InsertWholeGroup(Group group)
        {
            mpPermission.InsertGroup(group);
        }

    }
}
