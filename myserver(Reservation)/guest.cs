using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace myserver
{
    [DataContract]

    public class guest
    {
       
        private string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private string address;
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
     
        private string phone_no;
        [DataMember]
        public string Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
       
        private string email;
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        private string cnic;
        [DataMember]
        public string Cnic
        {
            get { return cnic; }
            set { cnic = value; }
        }
        
        private int rooms;
        [DataMember]
        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }
        
        private string checkin;
        [DataMember]
        public string Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }
        
        private string checkout;
        [DataMember]
        public string Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }
        
        private string gender;
        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

    }
}