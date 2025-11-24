using SRPRefactored.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web;

namespace SRPRefactored.Presentation
{
    class InvoiceHtmlPrinter
    {
        public static void PrintInvoice(Invoice invoice)
        {
            string template = $"Id :{invoice.Id} " +
                $" description:{invoice.Description}" +
                $" cost is :{invoice.Cost}" +
                $" tax amt is :{invoice.CalcuateTax()}" +
                $" discount amt is {invoice.CalculateDiscount()}" +
                $" Final cost is :{invoice.FinalCost()}";

             
            StreamWriter sw = new StreamWriter($"{invoice.Description}.html"); // To create the txt file in the bin folder.
            sw.WriteLine(template);
            sw.Close();

            //Create for the Html print

        }
    }
}
