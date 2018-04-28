using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class person
    {
        private string name;
        private DateTime checkin;
        private DateTime checkout;

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
