
using SRPRefactored.Domain;
using SRPRefactored.Presentation;

var starBucksInvoice = new Invoice(1, "Star bucks", 1000, .20);
<<<<<<< HEAD

//Its done thorugh creating an instance of PrintInvoice
//var consolePrinter = new InvoiceFilePrinter();
//consolePrinter.PrintInvoice(starBucksInvoice);

//This is done by calling thorugh a class which is static
InvoiceFilePrinter.PrintInvoice(starBucksInvoice);

InvoiceHtmlPrinter.PrintInvoice(starBucksInvoice);
=======
InvoiceFilePrinter.PrintInvoice(starBucksInvoice);

>>>>>>> 67b9254ed9562ab84c8669c37d8f02f094ee4d20

