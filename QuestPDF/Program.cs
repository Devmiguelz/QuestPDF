using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDFConsole.Quotes;
using QuestPDFConsole.Resources;

Settings.License = LicenseType.Community;

var dataModel = GenerateDataFake.GenerateTestData();

var document = new QuoteGenerator(dataModel);

document.GeneratePdfAndShow();

document.ShowInPreviewer();

Console.WriteLine("Hello, World!");
