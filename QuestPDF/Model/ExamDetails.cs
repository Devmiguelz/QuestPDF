namespace QuestPDFConsole.Model
{
    public class ExamDetails
    {
        public int id { get; set; }
        public int idTypeOfProcedure { get; set; }
        public int? idService { get; set; }
        public int idExam { get; set; }
        public string? examCode { get; set; }
        public string? examCups { get; set; }
        public string? examName { get; set; }
        public int? value { get; set; }
        public string? valorPesos { get; set; }
        public int? idSection { get; set; }
        public int? idAdditionalForm { get; set; }
        public int? idGenerateCopay { get; set; }
        public string idInformedConsent { get; set; }
    }
}
