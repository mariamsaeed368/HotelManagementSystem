using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace myserver
{
    [DataContract]
    public class Reservation
    {
        private string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private DateTime checkin;
        [DataMember]
        public DateTime Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }
        private DateTime checkout;
        [DataMember]
        public DateTime Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }
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
        private double Room_charges;
        [DataMember]
        public double Room_charges1
        {
            get { return Room_charges; }
            set { Room_charges = value; }
        }
        private double Service_charges;
        [DataMember]
        public double Service_charges1
        {
            get { return Service_charges; }
            set { Service_charges = value; }
        }
        private string Net_total;
        [DataMember]
        public string Net_total1
        {
            get { return Net_total; }
            set { Net_total = value; }
        }
        private string Tax;
        [DataMember]
        public string Tax1
        {
            get { return Tax; }
            set { Tax = value; }
        }
        private string Total;`
        [DataMember]
        public string Total1
        {
            get { return Total; }
            set { Total = value; }
        }
    }
}