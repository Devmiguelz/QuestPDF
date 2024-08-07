namespace QuestPDFConsole.Model
{
    public class QuoteDetailEntitie
    {
        public int IdQuoteForm { get; set; }
        public string QuoteFormName { get; set; }
        public string CompanyName { get; set; }
        public int QuoteFormValidity { get; set; }
        public string ValidityDescription { get; set; }
        public string AdditionalFormHeader { get; set; }
        public string AdditionalFormPatient { get; set; }
        public string AdditionalFormExam { get; set; }
        public string AdditionalFormObs { get; set; }
        public string AdditionalFormFooter { get; set; }
        public string LogoImage { get; set; }
        public bool Active { get; set; }
        public int IdCompany { get; set; }
        public int IdValidityFormat { get; set; }

    }
}
