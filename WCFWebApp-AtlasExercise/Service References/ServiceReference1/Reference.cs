﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFWebApp_AtlasExercise.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WcfService1_AtlasExercise")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address1 {
            get {
                return this.Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address1Field, value) != true)) {
                    this.Address1Field = value;
                    this.RaisePropertyChanged("Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address2 {
            get {
                return this.Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address2Field, value) != true)) {
                    this.Address2Field = value;
                    this.RaisePropertyChanged("Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfService1_AtlasExercise")]
    [System.SerializableAttribute()]
    public partial class ExceptionMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorMessageOfActionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string errorMessageOfAction {
            get {
                return this.errorMessageOfActionField;
            }
            set {
                if ((object.ReferenceEquals(this.errorMessageOfActionField, value) != true)) {
                    this.errorMessageOfActionField = value;
                    this.RaisePropertyChanged("errorMessageOfAction");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFWebApp_AtlasExercise.ServiceReference1.ExceptionMessage), Action="http://tempuri.org/IService1/GetCustomersExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfService1_AtlasExercise")]
        WCFWebApp_AtlasExercise.ServiceReference1.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomers", ReplyAction="http://tempuri.org/IService1/GetCustomersResponse")]
        System.Threading.Tasks.Task<WCFWebApp_AtlasExercise.ServiceReference1.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomers", ReplyAction="http://tempuri.org/IService1/AddCustomersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFWebApp_AtlasExercise.ServiceReference1.ExceptionMessage), Action="http://tempuri.org/IService1/AddCustomersExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfService1_AtlasExercise")]
        void AddCustomers(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomers", ReplyAction="http://tempuri.org/IService1/AddCustomersResponse")]
        System.Threading.Tasks.Task AddCustomersAsync(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCustomers", ReplyAction="http://tempuri.org/IService1/UpdateCustomersResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFWebApp_AtlasExercise.ServiceReference1.ExceptionMessage), Action="http://tempuri.org/IService1/UpdateCustomersExceptionMessageFault", Name="ExceptionMessage", Namespace="http://schemas.datacontract.org/2004/07/WcfService1_AtlasExercise")]
        void UpdateCustomers(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCustomers", ReplyAction="http://tempuri.org/IService1/UpdateCustomersResponse")]
        System.Threading.Tasks.Task UpdateCustomersAsync(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFWebApp_AtlasExercise.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFWebApp_AtlasExercise.ServiceReference1.IService1>, WCFWebApp_AtlasExercise.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFWebApp_AtlasExercise.ServiceReference1.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<WCFWebApp_AtlasExercise.ServiceReference1.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void AddCustomers(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer) {
            base.Channel.AddCustomers(customer);
        }
        
        public System.Threading.Tasks.Task AddCustomersAsync(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer) {
            return base.Channel.AddCustomersAsync(customer);
        }
        
        public void UpdateCustomers(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer) {
            base.Channel.UpdateCustomers(customer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomersAsync(WCFWebApp_AtlasExercise.ServiceReference1.Customer customer) {
            return base.Channel.UpdateCustomersAsync(customer);
        }
    }
}
