using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnMappingAttribute: Attribute
    {
        public string ColumnName { get; }

        public ColumnMappingAttribute(string columnName)
        {
            ColumnName = columnName;
        }


    }
}
