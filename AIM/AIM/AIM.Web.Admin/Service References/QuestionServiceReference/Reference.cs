﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIM.Web.Admin.QuestionServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:trackable-entities:service", ConfigurationName="QuestionServiceReference.IQuestionService")]
    public interface IQuestionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/GetQuestionsList", ReplyAction="urn:trackable-entities:service/IQuestionService/GetQuestionsListResponse")]
        AIM.Service.Entities.Models.Question[] GetQuestionsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/GetQuestion", ReplyAction="urn:trackable-entities:service/IQuestionService/GetQuestionResponse")]
        AIM.Service.Entities.Models.Question GetQuestion(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/UpdateQuestion", ReplyAction="urn:trackable-entities:service/IQuestionService/UpdateQuestionResponse")]
        AIM.Service.Entities.Models.Question UpdateQuestion(AIM.Service.Entities.Models.Question entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/CreateQuestion", ReplyAction="urn:trackable-entities:service/IQuestionService/CreateQuestionResponse")]
        AIM.Service.Entities.Models.Question CreateQuestion(AIM.Service.Entities.Models.Question entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/DeleteQuestion", ReplyAction="urn:trackable-entities:service/IQuestionService/DeleteQuestionResponse")]
        bool DeleteQuestion(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/GetQuestionnairesList", ReplyAction="urn:trackable-entities:service/IQuestionService/GetQuestionnairesListResponse")]
        AIM.Service.Entities.Models.Questionnaire[] GetQuestionnairesList();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/GetQuestionnaire", ReplyAction="urn:trackable-entities:service/IQuestionService/GetQuestionnaireResponse")]
        AIM.Service.Entities.Models.Questionnaire GetQuestionnaire(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/UpdateQuestionnaire", ReplyAction="urn:trackable-entities:service/IQuestionService/UpdateQuestionnaireResponse")]
        AIM.Service.Entities.Models.Questionnaire UpdateQuestionnaire(AIM.Service.Entities.Models.Questionnaire entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/CreateQuestionnaire", ReplyAction="urn:trackable-entities:service/IQuestionService/CreateQuestionnaireResponse")]
        AIM.Service.Entities.Models.Questionnaire CreateQuestionnaire(AIM.Service.Entities.Models.Questionnaire entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trackable-entities:service/IQuestionService/DeleteQuestionnaire", ReplyAction="urn:trackable-entities:service/IQuestionService/DeleteQuestionnaireResponse")]
        bool DeleteQuestionnaire(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuestionServiceChannel : AIM.Web.Admin.QuestionServiceReference.IQuestionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuestionServiceClient : System.ServiceModel.ClientBase<AIM.Web.Admin.QuestionServiceReference.IQuestionService>, AIM.Web.Admin.QuestionServiceReference.IQuestionService {
        
        public QuestionServiceClient() {
        }
        
        public QuestionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuestionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AIM.Service.Entities.Models.Question[] GetQuestionsList() {
            return base.Channel.GetQuestionsList();
        }
        
        public AIM.Service.Entities.Models.Question GetQuestion(int id) {
            return base.Channel.GetQuestion(id);
        }
        
        public AIM.Service.Entities.Models.Question UpdateQuestion(AIM.Service.Entities.Models.Question entity) {
            return base.Channel.UpdateQuestion(entity);
        }
        
        public AIM.Service.Entities.Models.Question CreateQuestion(AIM.Service.Entities.Models.Question entity) {
            return base.Channel.CreateQuestion(entity);
        }
        
        public bool DeleteQuestion(int id) {
            return base.Channel.DeleteQuestion(id);
        }
        
        public AIM.Service.Entities.Models.Questionnaire[] GetQuestionnairesList() {
            return base.Channel.GetQuestionnairesList();
        }
        
        public AIM.Service.Entities.Models.Questionnaire GetQuestionnaire(int id) {
            return base.Channel.GetQuestionnaire(id);
        }
        
        public AIM.Service.Entities.Models.Questionnaire UpdateQuestionnaire(AIM.Service.Entities.Models.Questionnaire entity) {
            return base.Channel.UpdateQuestionnaire(entity);
        }
        
        public AIM.Service.Entities.Models.Questionnaire CreateQuestionnaire(AIM.Service.Entities.Models.Questionnaire entity) {
            return base.Channel.CreateQuestionnaire(entity);
        }
        
        public bool DeleteQuestionnaire(int id) {
            return base.Channel.DeleteQuestionnaire(id);
        }
    }
}
