using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace myserver
{
    [DataContract]
    public class Employee
        {
            private int Id;
            private string name;
            private string phone_no;
            private string Department;
        [DataMember]
        public int Id1
            {
                get
                {
                    return Id;
                }

                set
                {
                    Id = value;
                }
            }
        [DataMember]

        public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }
        [DataMember]
        public string Phone_no
            {
                get
                {
                    return phone_no;
                }

                set
                {
                    phone_no = value;
                }
            }
        [DataMember]
        public string Department1
            {
                get
                {
                    return Department;
                }

                set
                {
                    Department = value;
                }
            }



        }
    }