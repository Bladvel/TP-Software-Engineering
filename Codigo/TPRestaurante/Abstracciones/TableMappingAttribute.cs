using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableMappingAttribute: Attribute
    {
        public string TableName { get; }

        public TableMappingAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}
