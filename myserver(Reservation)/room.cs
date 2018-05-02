using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace myserver
{
    public class room
    {
        private int number;
        [DataMember]
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        private string status;
        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private bool isfree;
        [DataMember]
        public bool Isfree
        {
            get { return isfree; }
            set { isfree = value; }
        }
    }
}