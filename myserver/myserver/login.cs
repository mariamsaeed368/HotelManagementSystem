using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace myserver
{
    [DataContract]
    public class login
    {
        private string user;
        private string username;
        private string password;
        [DataMember]
        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }
        [DataMember]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        [DataMember]
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}