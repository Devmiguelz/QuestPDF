using QuestPDFConsole.Model;

namespace QuestPDFConsole.Resources
{
    public static class GenerateDataFake
    {
        public static DataModel GenerateTestData()
        {
            return new DataModel
            {
                quoteDetailEntitie = new QuoteDetailEntitie
                {
                    IdQuoteForm = 521,
                    QuoteFormName = "Cotización",
                    CompanyName = "Centro Médico Oftalmológico y Laboratorio Clínico Andrade Narváez COLCAN S.A.S",
                    QuoteFormValidity = 15,
                    ValidityDescription = "Esta cotización es válida por 15 días hábiles",
                    AdditionalFormHeader = "Generado por: Administrador\nFecha: 02/01/2023\nSede: Calle 49",
                    AdditionalFormPatient = "Detalles del Cliente",
                    AdditionalFormExam = "Detalles del Examen",
                    AdditionalFormObs = "Recomendaciones",
                    AdditionalFormFooter = "Footer Information",
                    LogoImage = "https://static.vecteezy.com/system/resources/previews/008/214/517/large_2x/abstract-geometric-logo-or-infinity-line-logo-for-your-company-free-vector.jpg", // Agrega tu imagen en base64
                    Active = true,
                    IdCompany = 1,
                    IdValidityFormat = 1
                },
                businessModel = new BusinessDateModel
                {
                    businessName = "Centro Médico Oftalmológico y Laboratorio Clínico Andrade Narváez COLCAN S.A.S",
                    name = "COLCAN SEDE PRINCIPAL",
                    address = "Calle 49 #13-60",
                    email = "Facturacionelectronica@laboratorio.com",
                    nit = "800066001-3",
                    telephoneNumber = "7437777",
                    CityName = "Bogotá D.C",
                    CountryName = "Colombia",
                    PostalCode = "1020320",
                    base64 = "https://static.vecteezy.com/system/resources/previews/008/214/517/large_2x/abstract-geometric-logo-or-infinity-line-logo-for-your-company-free-vector.jpg" // Logo en base64
                },
                patientDetail = new PatientDetail
                {
                    id = 1,
                    nameIdentification = "CAROLINA OBREGON TARAZONA - 555655555",
                    telephoneNumber = "777777777",
                    email = "DOMINIO@GMAIL.COM",
                    address = "GL 91 A 19 55",
                    observations = "- Llegar en ayunas.\n- No beber alcohol ni fumar 24 horas antes de la prueba.\n- Ingerir alimentos livianos después de la prueba.",
                    beContacted = true,
                    quoteWhatsapp = false,
                    idContract = 1,
                    idContractType = 1,
                    contractName = "Standard Contract",
                    requestNumber = "REQ-001",
                    examQuoteNumber = "EQ-001",
                    additionalForm = "Additional Information"
                },
                examDetails = new List<ExamDetails>
                {
                    new ExamDetails
                    {
                        id = 1,
                        idTypeOfProcedure = 1,
                        idService = 1,
                        idExam = 2484,
                        examCode = "GLC0004",
                        examCups = "COVID-19",
                        examName = "CORONAVIRUS (COVID-19): Detección por PCR + toma de muestra",
                        value = 140,
                        valorPesos = "$140.00",
                        idSection = 1,
                        idAdditionalForm = 1,
                        idGenerateCopay = 0,
                        idInformedConsent = "Consent-001"
                    },
                    new ExamDetails
                    {
                        id = 2,
                        idTypeOfProcedure = 1,
                        idService = 1,
                        idExam = 1025,
                        examCode = "LAB0005",
                        examCups = "HEM-001",
                        examName = "Hemograma Completo",
                        value = 50,
                        valorPesos = "$50.00",
                        idSection = 1,
                        idAdditionalForm = 1,
                        idGenerateCopay = 0,
                        idInformedConsent = "Consent-002"
                    },
                    new ExamDetails
                    {
                        id = 3,
                        idTypeOfProcedure = 1,
                        idService = 1,
                        idExam = 1036,
                        examCode = "LAB0006",
                        examCups = "GLU-002",
                        examName = "Glucosa en Ayunas",
                        value = 30,
                        valorPesos = "$30.00",
                        idSection = 1,
                        idAdditionalForm = 1,
                        idGenerateCopay = 0,
                        idInformedConsent = "Consent-003"
                    },
                    new ExamDetails
                    {
                        id = 4,
                        idTypeOfProcedure = 1,
                        idService = 1,
                        idExam = 1047,
                        examCode = "LAB0007",
                        examCups = "LIP-003",
                        examName = "Perfil Lipídico",
                        value = 70,
                        valorPesos = "$70.00",
                        idSection = 1,
                        idAdditionalForm = 1,
                        idGenerateCopay = 0,
                        idInformedConsent = "Consent-004"
                    },
                    new ExamDetails
                    {
                        id = 5,
                        idTypeOfProcedure = 1,
                        idService = 1,
                        idExam = 1058,
                        examCode = "LAB0008",
                        examCups = "URE-004",
                        examName = "Nitrógeno Ureico en Sangre",
                        value = 40,
                        valorPesos = "$40.00",
                        idSection = 1,
                        idAdditionalForm = 1,
                        idGenerateCopay = 0,
                        idInformedConsent = "Consent-005"
                    },
                    new ExamDetails
                    {
                        id = 6,
                        idTypeOfProcedure = 1,
                        idService = 1,
                        idExam = 1069,
                        examCode = "LAB0009",
                        examCups = "CRE-005",
                        examName = "Creatinina Sérica",
                        value = 45,
                        valorPesos = "$45.00",
                        idSection = 1,
                        idAdditionalForm = 1,
                        idGenerateCopay = 0,
                        idInformedConsent = "Consent-006"
                    }
                }
            };
        }
    }
}
