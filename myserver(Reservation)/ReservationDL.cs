using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace myserver
{
    public class ReservationDL
    {
        public static List<Reservation> resevations = new List<Reservation>();
        public void roomReservation()
        {
            Reservation k=new Reservation();
            if(k.Isfree)
            {
                k.Status="Free";
                ReservationDL.resevations.Add(k);
            }
            else
            {
                k.Status="Busy";
            }
        }
    }
}