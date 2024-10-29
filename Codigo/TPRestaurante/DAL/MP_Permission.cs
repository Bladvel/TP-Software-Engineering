using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BE.Permisos;
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

            if (!string.IsNullOrEmpty(component.Name) && component is Permission)
            {
                component.PermissionType = (PermissionType)Enum.Parse(typeof(PermissionType), component.Name);
            }

            component.Type = type;
            component.ID = int.Parse(dr["ID"].ToString());

            return component;
        }

        //public override Component Transform(DataRow dr)
        //{
        //    Component component;
        //    ComponentType type = (ComponentType)Enum.Parse(typeof(ComponentType), dr["TIPO"].ToString());

        //    if (type == ComponentType.P)
        //        component = new Permission();
        //    else
        //        component = new Group();

        //    component.Name = dr["NOMBRE"].ToString();
        //    if (!string.IsNullOrEmpty(component.Name))
        //    {
        //        component.PermissionType = (PermissionType)Enum.Parse(typeof(PermissionType), component.Name);
        //    }
        //    component.Type = type;
        //    component.ID = int.Parse(dr["ID"].ToString());

        //    return component;
        //}

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


        public List<Component> GetAllPermissions()
        {
            List<Component> permissions = new List<Component>();
            access.Open();
            DataTable dt = access.Read("LISTAR_SOLO_PERMISO");
            access.Close();
            foreach (DataRow row in dt.Rows)
            {
                permissions.Add(Transform(row));
            }
            return permissions;
        }


        public List<Component> GetAllGroups()
        {
            
            List<Component> allComponents = GetAll();
            List<Component> groups = (from g in allComponents
                                    where g.Type.Equals(ComponentType.G)
                                    select g).ToList();

            return groups;
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
            int id;
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nom", entity.Name),
                access.CreateParameter("@type", entity.Type.ToString()),
            };

            access.Open();
            id = access.WriteScalar("INSERTAR_PERMISO", parameters);
            access.Close();

            return id;

        }

        public void InsertGroup(Group group)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@id", group.ID)
            };
            access.Open();
            int filasAfectadas = access.Write("ELIMINAR_GRUPO", parameters);
            if (filasAfectadas!= -1)
            {
                List<SqlParameter> parameters2;
                foreach (var groupChild in group.Children)
                {
                    parameters2 = new List<SqlParameter>()
                    {
                        access.CreateParameter("@id_padre", group.ID),
                        access.CreateParameter("@id_hijo", groupChild.ID)
                    };

                    access.Write("INSERTAR_GRUPO", parameters2);


                }
            }

            access.Close();
            
        }

        [Obsolete]
        public void UniversalInsert(Component entity)
        {
            int lastID = Insert(entity);
            List<Component> components;
            Group group;

            if (entity.Type.Equals(ComponentType.G))
            {
                components = GetAll();
                group = components.FirstOrDefault(c => c.ID.Equals(lastID)) as Group;
                InsertGroup(group);
            }

        }





        public override int Update(Component entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Component entity)
        {
            throw new NotImplementedException();
        }


        public MP_Permission(Access access) : base(access)
        {
        }
    }
}
