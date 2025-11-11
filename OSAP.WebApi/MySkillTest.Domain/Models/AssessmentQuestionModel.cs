using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class AssessmentQuestionModel
    {
        public int AssessmentQuestionId { get; set; }
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int AssessmentOrder { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }

    public class AssessmentQuestionGridModel
    {
        public int AssessmentQuestionId { get; set; }
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int AssessmentOrder { get; set; }
        public string DomainName { get; set; }
        public string QuestionTypeName { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }

    public class AssessmentQuestionsViewModel
    {
        public int DomainId { get; set; }
        public string DomainName { get; set; }
        public List<QuestionDetailsModel> QuestionDetails { get; set; }
    }

    public class QuestionDetailsModel
    {
        public int ComplexityId { get; set; }
        public string ComplexityLevel { get; set; }
        public int QuestionTypeId { get; set; }
        public string QuestionTypeName { get; set; }
        public int NoOfQuestionsAdded { get; set; }
        public int TotalNoOfQuestions { get; set; }
    }

    public class SaveAssessmentQuestionModel
    {
        public int AssessmentId { get; set; }
        public QuestionAnswerModel QuestionModel { get; set; }
    }

    public enum QuestionTypeEnum
    {
        Coding = 6,
        MultipleChoice = 7
    }
}