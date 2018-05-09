using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace myserver
{
    [DataContract]
    public class person1
    {
        private string name;
        private DateTime checkin;
        private DateTime checkout;
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
        public DateTime Checkin
        {
            get
            {
                return checkin;
            }

            set
            {
                checkin = value;
            }
        }
        [DataMember]
        public DateTime Checkout
        {
            get
            {
                return checkout;
            }

            set
            {
                checkout = value;
            }
        }

    }
}