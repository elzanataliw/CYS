using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYS.Models
{
    class User
    {
        protected string _username;
        protected string _password;

        public string username { get{
            return _username;
        } set{
            _username = value;
        } }
        
        
    }
}
