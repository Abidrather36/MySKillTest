namespace OSAP.WebApi.Models
{
    public class SkillReportModel
    {
        public int PrimaryDomainId { get; set; }
        public string PrimaryDomainName { get; set; }
        public int DomainId { get; set; }
        public string DomianName { get; set; }
        public int ComplexityId { get; set; }
        public int BasicNoOfQuestions { get; set; }
        public int IntermediateNoOfQuestions { get; set; }
        public int ComplexNoOfQuestions { get; set; }
        public int BasicCodingQuestions { get; set; }
        public int IntermediateCodingQuestions { get; set; }
        public int ComplexCodingQuestions { get; set; }
    }
}