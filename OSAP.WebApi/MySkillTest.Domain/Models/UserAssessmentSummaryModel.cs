using System;
using System.Collections.Generic;

namespace OSAP.WebApi.Models
{
    public class UserAssessmentSummaryModel
    {
        public Guid UserAssessmentId { get; set; }
        public string CandidateName { get; set; }
        public string AssessmentName { get; set; }
        public DateTime AssessmentDate { get; set; }
        public int AssessmentDuration { get; set; }
        public string TotalScore { get; set; }
        public int ClientId { get; set; }
        public byte[] ClientLogoContent { get; set; }
        public List<UserAssessmentSkillReport> UserAssessmentSkillReport { get; set; }
    }

    public class UserAssessmentSkillReport
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string ComplexityBasic { get; set; }
        public string ScoreBasic { get; set; }
        public string ComplexityIntermediate { get; set; }
        public string ScoreIntermediate { get; set; }
        public string ComplexityAdvanced { get; set; }
        public string ScoreAdvanced { get; set; }
    }

    public class UserAssessmentSkillResponseModel
    {
        public Guid UserAssessmentId { get; set; }
        public int UserResponseId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int ComplexityId { get; set; }
        public string ComplexityText { get; set; }
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}