namespace QuestPDFConsole.Model
{
    public class DataModel
    {
        public QuoteDetailEntitie quoteDetailEntitie { get; set; }
        public BusinessDateModel businessModel { get; set; }
        public PatientDetail patientDetail { get; set; }
        public List<ExamDetails> examDetails { get; set; }
    }
}
