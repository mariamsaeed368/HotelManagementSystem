using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace myserver
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<guest> show_all()
        {
            return guestdl.p;
        }
       public void Add_guest(guest g)
        {
            guestdl.p.Add(g);
        }
       public List<Employee> show()
       {
           return EmployeeDL.employee;
       }
       public void Add_employee(Employee p)
       {
           EmployeeDL.employee.Add(p);
       }
        public bool isvalid(string user, string password)
        {
            user u = new user();
            if (u.User == "Employee" && u.Password == "employee")
            {
                return true;
            }
            else if (u.User == "Manager" && u.Password == "manager")
            {
                return true;
            }
            else if (u.User == "Owner" && u.Password == "owner")
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
