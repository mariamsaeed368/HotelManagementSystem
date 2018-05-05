using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace myserver
{
    [DataContract]
    public class Room
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