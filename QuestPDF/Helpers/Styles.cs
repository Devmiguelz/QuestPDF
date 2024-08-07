using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPDFConsole.Helpers
{
    public static class Styles
    {

        #region Text Style

        public static readonly float FontSizeTitle = 12;
        public static readonly float FontSizeSubTitle = 10;
        public static readonly float FontSizeText = 9;
        public static readonly float FontSizeTextMin = 7.5f;

        public static readonly float HeaderHeight = 90;
        public static readonly float TableExamMinHeight = 290;
        public static readonly float TableExamMaxHeight = 300;
        public static readonly float RecomendationHeight = 90;
        public static readonly float ObservationMinHeight = 90;
        public static readonly float FooterHeight = 120;

        public static readonly Color BlueColor = Colors.Blue.Medium;
        public static readonly Color GreyColor = Colors.Blue.Medium;
        public static readonly Color BlueDark = Color.FromHex("#092643");
        public static readonly Color GreyBorder = Color.FromHex("#AEAEAE");
        public static readonly Color GreyBack = Color.FromHex("#D1D1D1");


        public static TextStyle HeaderTextStyle => TextStyle.Default
                                                            .SemiBold().FontSize(10)
                                                            .FontColor(Colors.Black);

        public static TextStyle CellTextStyle => TextStyle.Default
                                                        .FontSize(8.5f)
                                                        .FontColor(Colors.Black);

        public static TextStyle CellTotalTextStyle => TextStyle.Default
                                                        .FontSize(FontSizeTextMin)
                                                        .Bold()
                                                        .FontColor(Colors.Black);
        public static TextStyle FooterNameTextStyle => TextStyle.Default
                                                        .FontSize(FontSizeText)
                                                        .Bold()
                                                        .FontColor(Colors.White);

        public static TextStyle FooterTextStyle => TextStyle.Default
                                                        .FontSize(FontSizeTextMin)
                                                        .FontColor(Colors.White);

        #endregion

        #region Alignment
        public static IContainer CellCenterStyle(IContainer container)
        {
            return container.AlignCenter();
        }

        public static IContainer CellRightStyle(IContainer container)
        {
            return container.AlignRight();
        }

        public static IContainer CellLeftStyle(IContainer container)
        {
            return container.AlignLeft();
        }

        #endregion

        #region Exams Table

        public static IContainer CellPatientStyle(IContainer container)
        {
            return container
                .MinWidth(30)
                .MinHeight(15)
                .PaddingLeft(10)
                .AlignLeft()
                .AlignMiddle();
        }

        #endregion

        #region Style Name Column

        public static IContainer TableExamStyle(IContainer container)
        {
            return container.Background(Colors.White)
                            .MinHeight(TableExamMinHeight)
                            .MaxHeight(TableExamMaxHeight)
                            .PaddingTop(10);
        }

        public static IContainer CellExamnNameStyle(IContainer container)
        {
            return container
                .BorderRight(0.5f)
                .BorderLeft(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingLeft(5)
                .PaddingTop(3)
                .AlignLeft()
                .AlignMiddle();
        }

        public static IContainer CellExamnNameLastStyle(IContainer container)
        {
            return container
                .BorderRight(0.5f)
                .BorderLeft(0.5f)
                .BorderBottom(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingLeft(5)
                .PaddingTop(3)
                .AlignLeft()
                .AlignMiddle();
        }

        #endregion

        #region Style Header Column

        public static IContainer CellExamnHeaderLeftStyle(IContainer container)
        {
            return container
                .BorderTop(0.5f)
                .BorderLeft(0.5f)
                .BorderBottom(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .Background(GreyBack)
                .AlignCenter()
                .AlignMiddle();
        }

        public static IContainer CellExamnHeaderRightStyle(IContainer container)
        {
            return container
                .BorderTop(0.5f)
                .BorderRight(0.5f)
                .BorderBottom(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .Background(GreyBack)
                .AlignCenter()
                .AlignMiddle();
        }

        public static IContainer CellExamnHeaderStyle(IContainer container)
        {
            return container
                .BorderTop(0.5f)
                .BorderBottom(0.5f)
                .BorderRight(0.5f)
                .BorderLeft(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .Background(GreyBack)
                .AlignCenter()
                .AlignMiddle();
        }

        #endregion

        #region Normal Column

        public static IContainer CellExamnLastStyle(IContainer container)
        {
            return container
                .BorderBottom(0.5f)
                .BorderRight(0.5f)
                .BorderLeft(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .AlignCenter()
                .AlignMiddle();
        }

        public static IContainer CellExamnStyle(IContainer container)
        {
            return container
                .BorderRight(0.5f)
                .BorderLeft(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .AlignCenter()
                .AlignMiddle();
        }

        #endregion

        #region Total Table

        public static IContainer CellTotalLetterStyle(IContainer container)
        {
            return container
                .BorderBottom(0.5f)
                .BorderRight(0.5f)
                .BorderLeft(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .AlignCenter()
                .AlignMiddle();
        }

        public static IContainer CellTotalNumberStyle(IContainer container)
        {
            return container
                .Border(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .AlignRight()
                .PaddingRight(5)
                .AlignMiddle();
        }

        public static IContainer CellObservationStyle(IContainer container)
        {
            return container
                .BorderTop(0.5f)
                .BorderLeft(0.5f)
                .BorderRight(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingLeft(10)
                .AlignLeft()
                .AlignMiddle();
        }

        public static IContainer CellObservationTextStyle(IContainer container)
        {
            return container
                .BorderLeft(0.5f)
                .BorderRight(0.5f)
                .BorderBottom(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingLeft(10)
                .AlignCenter()
                .AlignMiddle();
        }

        public static IContainer CellTotalTopStyle(IContainer container)
        {
            return container
                .BorderTop(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingRight(5)
                .AlignRight()
                .AlignMiddle();
        }

        public static IContainer CellTotalTopRightStyle(IContainer container)
        {
            return container
                .BorderTop(0.5f)
                .BorderRight(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingRight(5)
                .AlignRight()
                .AlignMiddle();
        }

        public static IContainer CellTotalRightStyle(IContainer container)
        {
            return container
                .BorderRight(0.5f)
                .BorderColor(GreyBorder)
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingRight(5)
                .AlignRight()
                .AlignMiddle();
        }

        public static IContainer CellTotalRightBStyle(IContainer container)
        {
            return container
                .ShowOnce()
                .MinWidth(30)
                .MinHeight(15)
                .PaddingRight(5)
                .AlignRight()
                .AlignMiddle();
        }

        #endregion

        #region

        public static IContainer PatientStyle(IContainer container)
        {
            return container.PaddingTop(10).Border(0.5f).BorderBottom(0.6f).BorderColor(GreyBorder);
        }

        #endregion

        #region Recomendation
        public static IContainer RecomendationStyle(IContainer container)
        {
            return container.Height(RecomendationHeight)
                            .PaddingTop(10)
                            .Border(0.5f)
                            .BorderColor(GreyBorder)
                            .Padding(10);
        }

        #endregion

        #region Table Total

        public static IContainer TotalTableStyle(IContainer container)
        {
            return container.MinHeight(ObservationMinHeight)
                            .PaddingTop(10);
        }

        #endregion

        #region Header Text Style

        public static IContainer HeaderTextLeftStyle(IContainer container)
        {
            return container.AlignMiddle().PaddingLeft(10).PaddingRight(4);
        }

        public static IContainer HeaderContainerStyle(IContainer container)
        {
            return container.Border(0.5f).BorderColor(GreyBorder).AlignMiddle().PaddingLeft(10).PaddingRight(4);
        }

        public static IContainer HeaderImageStyle(IContainer container)
        {
            return container.PaddingLeft(20).AlignMiddle().AlignLeft().MaxWidth(170);
        }

        #endregion
    }

}
