﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cards.UI.Web.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStringData", ReplyAction="http://tempuri.org/IService1/GetStringDataResponse")]
        void GetStringData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStringData", ReplyAction="http://tempuri.org/IService1/GetStringDataResponse")]
        System.Threading.Tasks.Task GetStringDataAsync(string value);
        
        //[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        //ActivationService.CompositeType GetDataUsingDataContract(ActivationService.CompositeType composite);
        
        //[System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        //System.Threading.Tasks.Task<ActivationService.CompositeType> GetDataUsingDataContractAsync(ActivationService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Cards.UI.Web.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Cards.UI.Web.ServiceReference2.IService1>, Cards.UI.Web.ServiceReference2.IService1 {
        
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
        
        public void GetStringData(string value) {
            base.Channel.GetStringData(value);
        }
        
        public System.Threading.Tasks.Task GetStringDataAsync(string value) {
            return base.Channel.GetStringDataAsync(value);
        }
        
        //public ActivationService.CompositeType GetDataUsingDataContract(ActivationService.CompositeType composite) {
        //    return base.Channel.GetDataUsingDataContract(composite);
        //}
        
        //public System.Threading.Tasks.Task<ActivationService.CompositeType> GetDataUsingDataContractAsync(ActivationService.CompositeType composite) {
        //    return base.Channel.GetDataUsingDataContractAsync(composite);
        //}
    }
}
