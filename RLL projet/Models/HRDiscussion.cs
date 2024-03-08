namespace RLL_projet.Models
{
    public class HRDiscussion
    {
        public string? CandidateName { get; set; }
        public string? Interviewer { get; set; }
        public string? InterviewDate { get; set; }
        public int CommunicationSkillsRating { get; set; }
        public int TechnicalSkillsRating { get; set; }
        public int ProblemSolvingRating { get; set; }
        public string? Comments { get; set; }
    }
}
