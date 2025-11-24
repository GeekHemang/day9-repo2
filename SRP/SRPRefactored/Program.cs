
using SRPRefactored.Domain;
using SRPRefactored.Presentation;

var starBucksInvoice = new Invoice(1, "Star bucks", 1000, .20);

//Its done thorugh creating an instance of PrintInvoice
//var consolePrinter = new InvoiceFilePrinter();
//consolePrinter.PrintInvoice(starBucksInvoice);

//This is done by calling thorugh a class which is static
InvoiceFilePrinter.PrintInvoice(starBucksInvoice);

InvoiceHtmlPrinter.PrintInvoice(starBucksInvoice);

