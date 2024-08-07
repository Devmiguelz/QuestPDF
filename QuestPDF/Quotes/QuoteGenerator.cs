using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDFConsole.Helpers;
using QuestPDFConsole.Model;

namespace QuestPDFConsole.Quotes
{
    public class QuoteGenerator: IDocument
    {
        private DataModel _dataModel { get; }

        public QuoteGenerator(DataModel dataModel)
        {
            _dataModel = dataModel;
        }

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(15);
                    page.Size(PageSizes.A4);
                    page.PageColor(Colors.White);

                    page.Header().Height(Styles.HeaderHeight).Element(CreateHeader);
                    page.Content().Element(CreateContent);
                    page.Footer().Element(CreateFooter);

                });
        }

        void CreateHeader(IContainer container)
        {
            Image LogoImage = Image.FromFile("C:\\Users\\Miguel Zambrano\\Documents\\NET\\GeneratePDF\\QuestPDF\\Resources\\Image\\LIS.png");

            container.Element(Styles.HeaderContainerStyle).Row(row =>
            {
                row.RelativeItem().Element(Styles.HeaderImageStyle).Image(LogoImage).FitHeight().FitWidth();

                row.ConstantItem(70).Element(Styles.HeaderTextLeftStyle).Column(column =>
                {
                    column.Item().Text($"Cotización N° {_dataModel.quoteDetailEntitie.IdQuoteForm}").FontSize(Styles.FontSizeTextMin).SemiBold();
                });

                row.ConstantItem(150).AlignMiddle().Column(column =>
                {                    
                    column.Item().Element(CreateHeaderText);                    
                });

            });
        }

        void CreateHeaderText(IContainer container)
        {
            container.PaddingLeft(10)
                    .Column(row =>
                    {                        
                        row.Item().Text($"Generado por: Administrador").FontSize(Styles.FontSizeTextMin);
                        row.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy}").FontSize(Styles.FontSizeTextMin);
                        row.Item().Text($"{_dataModel.businessModel.address}").FontSize(Styles.FontSizeTextMin);
                    });
        }

        void CreateContent(IContainer container)
        {

            container.Column(column =>
            {
                column.Item().Element(CreateInfoPatient);

                // Tabla de exámenes
                column.Item().Element(CreateTableExams);

                // Recomendaciones
                column.Item().Element(CreateRecomendation);

                // Totales
                column.Item().Element(CreateTotal);

                // Vigencia Cotización
                column.Item().Element(CreateVigencie);
            });
        }

        void CreateInfoPatient(IContainer container)
        {
            container.Element(Styles.PatientStyle).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Nombre: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.name}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Identificación: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.identification}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Teléfono: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.telephoneNumber}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Dirección: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.address}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Nombre: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.name}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Identificación: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.identification}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Teléfono: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.telephoneNumber}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Dirección: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.address}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Nombre: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.name}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Identificación: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.identification}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Teléfono: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.telephoneNumber}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Dirección: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.address}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Nombre: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.name}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Identificación: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.identification}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Teléfono: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.telephoneNumber}").FontSize(Styles.FontSizeTextMin);
                });

                table.Cell().Element(Styles.CellPatientStyle).Text(text =>
                {
                    text.Span("Dirección: ").FontSize(Styles.FontSizeTextMin).Bold();
                    text.Span($"{_dataModel.patientDetail.address}").FontSize(Styles.FontSizeTextMin);
                });
            });
        }

        void CreateTableExams(IContainer container)
        {
            container.Element(Styles.TableExamStyle).Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(0.7f); // Código del examen
                    columns.RelativeColumn(3); // Nombre del examen
                    columns.RelativeColumn(1); // Fecha
                    columns.RelativeColumn(0.7f); // Cantidad
                    columns.RelativeColumn(1); // Valor
                    columns.RelativeColumn(1); // Descuento
                    columns.RelativeColumn(1); // Valor Total
                });

                table.Header(header =>
                {
                    header.Cell().Element(Styles.CellExamnHeaderLeftStyle).Text("Código").Style(Styles.HeaderTextStyle);
                    header.Cell().Element(Styles.CellExamnHeaderStyle).Text("Examen").Style(Styles.HeaderTextStyle);
                    header.Cell().Element(Styles.CellExamnHeaderStyle).Text("Fecha").Style(Styles.HeaderTextStyle);
                    header.Cell().Element(Styles.CellExamnHeaderStyle).Text("Cantidad").Style(Styles.HeaderTextStyle);
                    header.Cell().Element(Styles.CellExamnHeaderStyle).Text("Valor Unitario").Style(Styles.HeaderTextStyle);
                    header.Cell().Element(Styles.CellExamnHeaderStyle).Text("Descuento").Style(Styles.HeaderTextStyle);
                    header.Cell().Element(Styles.CellExamnHeaderRightStyle).Text("Valor Total").Style(Styles.HeaderTextStyle);
                });

                foreach (var exam in _dataModel.examDetails)
                {   
                    bool isLast = exam == _dataModel.examDetails.Last();

                    table.Cell().Element(isLast ? Styles.CellExamnLastStyle : Styles.CellExamnStyle).Text(exam.examCode).Style(Styles.CellTextStyle);
                    table.Cell().Element(isLast ? Styles.CellExamnNameLastStyle : Styles.CellExamnNameStyle).Text($"{exam.idExam} - {exam.examName}").Style(Styles.CellTextStyle);
                    table.Cell().Element(isLast ? Styles.CellExamnLastStyle : Styles.CellExamnStyle).Text($"{DateTime.Now.ToString("dd/MM/yyyy")}").Style(Styles.CellTextStyle);
                    table.Cell().Element(isLast ? Styles.CellExamnLastStyle : Styles.CellExamnStyle).Text("1").Style(Styles.CellTextStyle);
                    table.Cell().Element(isLast ? Styles.CellExamnLastStyle : Styles.CellExamnStyle).Text($"{exam.valorPesos}").Style(Styles.CellTextStyle);
                    table.Cell().Element(isLast ? Styles.CellExamnLastStyle : Styles.CellExamnStyle).Text("$ 14.00 (10%)").Style(Styles.CellTextStyle);
                    table.Cell().Element(isLast ? Styles.CellExamnLastStyle : Styles.CellExamnStyle).Text($"{exam.valorPesos}").Style(Styles.CellTextStyle);
                }
            });
        }

        void CreateRecomendation(IContainer container)
        {
            container.Element(Styles.RecomendationStyle).Column(column =>
            {
                column.Item().Text("RECOMENDACIONES").FontSize(Styles.FontSizeTextMin).SemiBold();
                column.Item().Text(_dataModel.patientDetail.observations ?? "No hay observaciones").FontSize(Styles.FontSizeTextMin);
            });
        }

        void CreateTotal(IContainer container)
        {
            container.Element(Styles.TotalTableStyle).Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(300);
                            columns.RelativeColumn();
                            columns.ConstantColumn(90);
                        });

                        table.Cell().Element(Styles.CellObservationStyle).Text("OBSERVACIONES").Style(Styles.CellTotalTextStyle);
                        table.Cell().Element(Styles.CellTotalTopStyle).Text("MONEDA").Style(Styles.CellTotalTextStyle);

                        table.Cell().Element(Styles.CellTotalTopRightStyle).Text("MXN").Style(Styles.CellTotalTextStyle);
                        table.Cell().RowSpan(3).Element(Styles.CellObservationTextStyle).Text("");

                        table.Cell().Element(Styles.CellTotalRightBStyle).Text("TOTAL BRUTO").Style(Styles.CellTotalTextStyle);
                        table.Cell().Element(Styles.CellTotalRightStyle).Text("$ 140.00").Style(Styles.CellTotalTextStyle);

                        table.Cell().Element(Styles.CellTotalRightBStyle).Text("DESCUENTOS").Style(Styles.CellTotalTextStyle);
                        table.Cell().Element(Styles.CellTotalRightStyle).Text("$ 14.00").Style(Styles.CellTotalTextStyle);

                        table.Cell().Element(Styles.CellTotalRightBStyle).Text("I.V.A (16.00)").Style(Styles.CellTotalTextStyle);
                        table.Cell().Element(Styles.CellTotalRightStyle).Text("$ 22.40").Style(Styles.CellTotalTextStyle);


                        table.Cell().Element(Styles.CellTotalLetterStyle).Text("CIENTO CUARENTA Y OCHO PESOS").Style(Styles.CellTotalTextStyle);
                        table.Cell().ColumnSpan(2).Element(Styles.CellTotalNumberStyle).Text("$ 148.00").Style(Styles.CellTotalTextStyle);
                    });
        }

        void CreateVigencie(IContainer container)
        {
            container.AlignCenter().Column(column =>
            {
                column.Item().PaddingTop(10).PaddingBottom(10).Text($"*Esta cotización es válida por {15} días hábiles*").FontSize(9).Bold().AlignCenter();
            });
        }

        void CreateFooter(IContainer container)
        {
            Image backgroundImage = Image.FromFile("C:\\Users\\Miguel Zambrano\\Documents\\NET\\GeneratePDF\\QuestPDF\\Resources\\Image\\Footer 2024.png");

            container.Background(Colors.Grey.Medium).Height(Styles.FooterHeight).Row(row =>
            {
                row.ConstantItem(50).AlignCenter().AlignMiddle().Text(text =>
                {
                    text.Span("Pag. ").FontColor(Colors.White).FontSize(Styles.FontSizeTextMin);
                    text.CurrentPageNumber().FontColor(Colors.White).FontSize(Styles.FontSizeTextMin);
                    text.Span(" de ").FontColor(Colors.White).FontSize(Styles.FontSizeTextMin);
                    text.TotalPages().FontColor(Colors.White).FontSize(Styles.FontSizeTextMin);
                });

                row.RelativeItem().AlignCenter().AlignMiddle().Column(column =>
                {
                    column.Item().Row(rowText =>
                    {
                        rowText.AutoItem().Text($"{_dataModel.businessModel.businessName.ToUpper()}").Style(Styles.FooterNameTextStyle);
                    });

                    column.Item().AlignCenter().PaddingTop(10).Row(rowText =>
                    {
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.name}").Style(Styles.FooterTextStyle);
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.nit}").Style(Styles.FooterTextStyle);
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.email}").Style(Styles.FooterTextStyle);
                    });

                    column.Item().AlignCenter().PaddingTop(10).Row(rowText =>
                    {
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.telephoneNumber}").Style(Styles.FooterTextStyle);
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.address}").Style(Styles.FooterTextStyle); 
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.PostalCode}").Style(Styles.FooterTextStyle);
                    });

                    column.Item().AlignCenter().PaddingTop(10).Row(rowText =>
                    {
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.CityName}").Style(Styles.FooterTextStyle);
                        rowText.AutoItem().PaddingRight(10).Text($"{_dataModel.businessModel.CountryName}").Style(Styles.FooterTextStyle);
                    });

                });

            });
        }

        IContainer DefaultCellStyle(IContainer container, string backgroundColor)
        {
            return container
                .Border(1)
                .BorderColor(Colors.Grey.Lighten1)
                .Background(backgroundColor)
                .PaddingVertical(5)
                .PaddingHorizontal(10)
                .AlignCenter()
                .AlignMiddle();
        }
    }
}
