using HtmlToPdf.ConsoleApplication;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

if (string.IsNullOrEmpty(Credentials.SyncfusionLicenseKey))
    throw new Exception("You need to provide your own Syncfusion license key or find another tool that will generate a PDF from HTML");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Credentials.SyncfusionLicenseKey);

Console.WriteLine("Creating PDF...");

HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

// Convert URL to PDF
// You will need to run the web app first, get the local url it uses, update the url below
// Then run this console application
PdfDocument document = htmlConverter.Convert("http://localhost:5229/");
document.PageSettings.Margins = new Syncfusion.Pdf.Graphics.PdfMargins { Top = 0, Left = 0, Right = 0, Bottom = 0 };

FileStream fileStream = new FileStream(@"C:\Temp\PDF\HTML-to-PDF7.pdf", FileMode.Create, FileAccess.ReadWrite);

document.Save(fileStream);
document.Close(true);