using System.Collections.Generic;

namespace OSAP.WebApi.Models
{
    public class UserAssessmentResultsModel
    {
        public int UserResponseId { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public QuestionModel Question { get; set; }        
        public IEnumerable<AnswerModel> Answers { get; set; }
        public string UserAnswer { get; set; }
        public bool isCorrectAnswer { get; set; }
        public bool MultiAnswer { get; set; }
        public int? Rating { get; set; }
        public string Remarks { get; set; }
    }
}