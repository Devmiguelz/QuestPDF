namespace QuestPDFConsole.Model
{
    public class PatientDetail
    {
        private string _name = "";
        private string _identification = "";

        public int id { get; set; }
        public string nameIdentification
        {
            get => _name + "-" + _identification;
            set
            {
                var parts = value?.Split('-');
                if (parts != null && parts.Length == 2)
                {
                    _name = parts[0];
                    _identification = parts[1];
                }
                else
                {
                    _name = value;
                    _identification = string.Empty;
                }
            }
        }
        public string name { get => _name; }
        public string identification { get => _identification; }
        public string? telephoneNumber { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        public string? observations { get; set; }
        public bool beContacted { get; set; }
        public bool quoteWhatsapp { get; set; }
        public int idContract { get; set; }
        public int idContractType { get; set; }
        public string contractName { get; set; }
        public string requestNumber { get; set; }
        public string examQuoteNumber { get; set; }
        public string additionalForm { get; set; }
    }
}
