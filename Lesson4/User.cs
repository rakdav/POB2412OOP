using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class User
    {
        private string? name="";
        private string? email="";
        private string? phone="";
        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name":return name!;
                    case "email": return email!;
                    case "phone": return phone!;
                    default:throw new Exception("Неизвестное свойство");
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":name = value;break;
                    case "email": email = value; break;
                    case "phone": phone = value; break;
                }
            }
        }
    }
}
