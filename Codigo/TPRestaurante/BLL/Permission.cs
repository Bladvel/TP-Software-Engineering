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


    }
}
