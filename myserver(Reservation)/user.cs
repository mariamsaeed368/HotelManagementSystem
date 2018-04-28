using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace myserver
{
    [DataContract]
    public class user
    {
        private string users;
        [DataMember]
        public string User
        {
            get { return users; }
            set { users = value; }
        }
        private string password;
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
