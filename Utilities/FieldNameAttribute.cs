using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapper.Helpers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldNameAttribute : Attribute
    {
        public string Name { get; }

        public FieldNameAttribute(string name)
        {
            Name = name;
        }
    }
}
