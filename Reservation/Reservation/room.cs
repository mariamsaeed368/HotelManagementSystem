using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class room
    {
        private int number;
        private string status;
        private bool isfree;

    
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }


        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public bool Isfree
        {
            get
            {
                return isfree;
            }

            set
            {
                isfree = value;
            }
        }
    }
}
