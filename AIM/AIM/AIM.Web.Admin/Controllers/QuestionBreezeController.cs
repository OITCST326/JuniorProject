using System;
using System.Linq;
using System.Web.Http;
using AIM.Service.Entities.Models;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;

namespace AIM.Web.Admin.Controllers
{
    [BreezeController]
    public class QuestionBreezeController : ApiController
    {
        readonly EFContextProvider<AIM_DBContext> _contextProvider =
            new EFContextProvider<AIM_DBContext>();

        // ~/breeze/QuestionBreeze/Metadata
        [HttpGet]
        public string Metadate()
        {
            return _contextProvider.Metadata();
        }

        // ~/breeze/QuestionBreeze/SaveChanges
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        // ~/breeze/QuestionBreeze/Questions
        // ~/breeze/QuestionBreeze/Questions?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Question> Questions()
        {
            return _contextProvider.Context.Questions;
        }

        // ~/breeze/QuestionBreeze/Questionnaires
        // ~/breeze/QuestionBreeze/Questionnaires?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Questionnaire> Questionnaires()
        {
            return _contextProvider.Context.Questionnaires;
        }

        // ~/breeze/QuestionBreeze/InterviewQuestions
        // ~/breeze/QuestionBreeze/InterviewQuestions?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<InterviewQuestion> InterviewQuestions()
        {
            return _contextProvider.Context.InterviewQuestions;
        }

        // ~/breeze/QuestionBreeze/Jobs
        // ~/breeze/QuestionBreeze/Jobs?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Job> Jobs()
        {
            return _contextProvider.Context.Jobs;
        }

        // ~/breeze/QuestionBreeze/Hours
        // ~/breeze/QuestionBreeze/Hours?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Hour> Hours()
        {
            return _contextProvider.Context.Hours;
        }

        // ~/breeze/QuestionBreeze/Applicants
        // ~/breeze/QuestionBreeze/Applicants?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Applicant> Applicants()
        {
            return _contextProvider.Context.Applicants;
        }

        // ~/breeze/QuestionBreeze/Applications
        // ~/breeze/QuestionBreeze/Applications?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Application> Applications()
        {
            return _contextProvider.Context.Applications;
        }

        // ~/breeze/QuestionBreeze/Educations
        // ~/breeze/QuestionBreeze/Educations?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Education> Educations()
        {
            return _contextProvider.Context.Educations;
        }

        // ~/breeze/QuestionBreeze/Employees
        // ~/breeze/QuestionBreeze/Employees?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Employee> Employees()
        {
            return _contextProvider.Context.Employees;
        }

        // ~/breeze/QuestionBreeze/JobHistories
        // ~/breeze/QuestionBreeze/JobHistories?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<JobHistory> JobHistories()
        {
            return _contextProvider.Context.JobHistories;
        }

        // ~/breeze/QuestionBreeze/OpenJobs
        // ~/breeze/QuestionBreeze/OpenJobs?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<OpenJob> OpenJobs()
        {
            return _contextProvider.Context.OpenJobs;
        }

        // ~/breeze/QuestionBreeze/References
        // ~/breeze/QuestionBreeze/References?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Reference> References()
        {
            return _contextProvider.Context.References;
        }

        // ~/breeze/QuestionBreeze/PersonalInfoes
        // ~/breeze/QuestionBreeze/PersonalInfoes?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<PersonalInfo> PersonalInfoes()
        {
            return _contextProvider.Context.PersonalInfoes;
        }

        // ~/breeze/QuestionBreeze/Regions
        // ~/breeze/QuestionBreeze/Regions?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Region> Regions()
        {
            return _contextProvider.Context.Regions;
        }

        // ~/breeze/QuestionBreeze/Stores
        // ~/breeze/QuestionBreeze/Stores?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<Store> Stores()
        {
            return _contextProvider.Context.Stores;
        }

        // ~/breeze/QuestionBreeze/Users
        // ~/breeze/QuestionBreeze/Users?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<User> Users()
        {
            return _contextProvider.Context.Users;
        }

        // ~/breeze/QuestionBreeze/ApplicantQuestionAnswers
        // ~/breeze/QuestionBreeze/ApplicantQuestionAnswers?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<ApplicantQuestionAnswer> ApplicantQuestionAnswers()
        {
            return _contextProvider.Context.ApplicantQuestionAnswers;
        }

        // ~/breeze/QuestionBreeze/QuestionInterviewQuestionMappings
        // ~/breeze/QuestionBreeze/QuestionInterviewQuestionMappings?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings()
        {
            return _contextProvider.Context.QuestionInterviewQuestionMappings;
        }

        // ~/breeze/QuestionBreeze/QuestionQuestionnaires
        // ~/breeze/QuestionBreeze/QuestionQuestionnaires?$filter=IsArchived eq false&$orderby=CreatedAt
        [HttpGet]
        public IQueryable<QuestionQuestionnaire> QuestionQuestionnaires()
        {
            return _contextProvider.Context.QuestionQuestionnaires;
        }

    }
}
