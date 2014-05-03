﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AIM.Application.Service.Entities.Models;

namespace AIM.Web.Application.ApplicationServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:trackable-entities:service", ConfigurationName="ApplicationServiceReference.IApplicationService")]
    public interface IApplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IApplicationService/GetApplicantsList", ReplyAction="urn:trackable-entities:service/IApplicationService/GetApplicantsListResponse")]
        AIM.Application.Service.Entities.Models.Applicant[] GetApplicantsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IApplicationService/GetApplicant", ReplyAction="urn:trackable-entities:service/IApplicationService/GetApplicantResponse")]
        Applicant GetApplicant(int? id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IApplicationService/UpdateApplicant", ReplyAction="urn:trackable-entities:service/IApplicationService/UpdateApplicantResponse")]
        AIM.Application.Service.Entities.Models.Applicant UpdateApplicant(AIM.Application.Service.Entities.Models.Applicant entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IApplicationService/CreateApplicant", ReplyAction="urn:trackable-entities:service/IApplicationService/CreateApplicantResponse")]
        AIM.Application.Service.Entities.Models.Applicant CreateApplicant(AIM.Application.Service.Entities.Models.Applicant entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IApplicationService/DeleteApplicant", ReplyAction="urn:trackable-entities:service/IApplicationService/DeleteApplicantResponse")]
        bool DeleteApplicant(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationServiceChannel : AIM.Web.Application.ApplicationServiceReference.IApplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationServiceClient : System.ServiceModel.ClientBase<AIM.Web.Application.ApplicationServiceReference.IApplicationService>, AIM.Web.Application.ApplicationServiceReference.IApplicationService {
        
        public ApplicationServiceClient() {
        }
        
        public ApplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AIM.Application.Service.Entities.Models.Applicant[] GetApplicantsList() {
            return base.Channel.GetApplicantsList();
        }
        
        public Applicant GetApplicant(int? id) {
            return base.Channel.GetApplicant(id);
        }
        
        public AIM.Application.Service.Entities.Models.Applicant UpdateApplicant(AIM.Application.Service.Entities.Models.Applicant entity) {
            return base.Channel.UpdateApplicant(entity);
        }
        
        public AIM.Application.Service.Entities.Models.Applicant CreateApplicant(AIM.Application.Service.Entities.Models.Applicant entity) {
            return base.Channel.CreateApplicant(entity);
        }
        
        public bool DeleteApplicant(int id) {
            return base.Channel.DeleteApplicant(id);
        }
    }
}
