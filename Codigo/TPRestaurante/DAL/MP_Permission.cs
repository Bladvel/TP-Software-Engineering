using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Interfaces;

namespace DAL
{
    public class MP_Permission:Mapper<Component>
    {
        public override Component GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override Component Transform(DataRow dr)
        {
            Component component;
            ComponentType type = (ComponentType)Enum.Parse(typeof(ComponentType), dr["TIPO"].ToString());

            if (type == ComponentType.P)
                component = new Permission();
            else
                component = new Group();

            component.Name = dr["NOMBRE"].ToString();
            if (!string.IsNullOrEmpty(component.Name))
            {
                component.PermissionType = (PermissionType)Enum.Parse(typeof(PermissionType), component.Name);
            }
            component.Type = type;
            component.ID = int.Parse(dr["ID"].ToString());

            return component;
        }


        public List<Component> GetAllWithoutComposite()
        {
            List<Component> components = new List<Component>();
            access.Open();
            DataTable dt = access.Read("LISTAR_PERMISO");
            access.Close();
            foreach (DataRow row in dt.Rows)
            {
                components.Add(Transform(row));
            }

            return components;
        }

        public override List<Component> GetAll()
        {
            List<Component> components = GetAllWithoutComposite();

            if (components.Count > 0)
            {
                access.Open();
                DataTable dt = access.Read("LISTAR_GRUPO");
                access.Close();

                foreach (DataRow row in dt.Rows)
                {
                    int id_padre = int.Parse(row["ID_PADRE"].ToString());
                    int id_hijo = int.Parse(row["ID_HIJO"].ToString());

                    Component father = (from g in components where g.ID== id_padre select g).FirstOrDefault() as Group;
                    Component child = (from p in components where p.ID== id_hijo select p).FirstOrDefault();

                    if (father != null && child != null)
                    {
                        father.AddChild(child);
                    }


                }


            }


            return components;
        }

        public override int Insert(Component entity)
        {
            throw new NotImplementedException();
        }

        public override int Update(Component entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Component entity)
        {
            throw new NotImplementedException();
        }
    }
}
