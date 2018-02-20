using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1_AtlasExercise
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    /*[ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }*/
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        List<Customer> GetCustomers();

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        void AddCustomers(Customer customer);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        void UpdateCustomers(Customer customer);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    /*[DataContract]
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
    }*/
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string LastName;
        [DataMember]
        public string Email;
        [DataMember]
        public string Address1;
        [DataMember]
        public string Address2;
        [DataMember]
        public string City;
        [DataMember]
        public string State;
        [DataMember]
        public string Zip;
        [DataMember]
        public string Country;
    }

    [DataContract]
    public class ExceptionMessage
    {
        private string infoExceptionMessage;
        public ExceptionMessage(string Message)
        {
            this.infoExceptionMessage = Message;
        }
        [DataMember]
        public string errorMessageOfAction
        {
            get { return this.infoExceptionMessage; }
            set { this.infoExceptionMessage = value; }
        }
    }
}
