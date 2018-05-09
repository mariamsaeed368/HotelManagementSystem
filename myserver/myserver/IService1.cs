
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace myserver
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void add_user(login p);
       [OperationContract]
       double Getamount(tax1 p);
        [OperationContract]
        void add1(reservation1 p);
       [OperationContract]
       double findtax(double amount);
        [OperationContract]
        void Add_room(room1 p);
        [OperationContract]
        List<room1> show_room();
        [OperationContract]
        void Add_employee(Employee p);

        [OperationContract]
        List<Employee> show();
        [OperationContract]
        bool isvalid(string user, string password);
       [OperationContract]
       List<guest> show_all();
       [OperationContract]
        void Add_guest(guest g);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
