﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class tax
    {
        private double Room_charges;
        private double Service_charges;

        public double Room_charges1
        {
            get
            {
                return Room_charges;
            }

            set
            {
                Room_charges = value;
            }
        }

        public double Service_charges1
        {
            get
            {
                return Service_charges;
            }

            set
            {
                Service_charges = value;
            }
        }
        public double Getamount()
        {
            return Room_charges + Service_charges;

        }
        public double mctax = 0.65;
        public double findtax(double amount)
        {
             double ftax = amount - (amount * mctax);
             return ftax;
        }
    }
}
