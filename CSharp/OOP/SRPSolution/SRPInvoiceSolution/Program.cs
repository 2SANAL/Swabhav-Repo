
namespace SRPInvoiceSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInvoice printInvoice = new PrintInvoice(new Invoice(1, "invoice2", 120, 23.1f, .18f));
            printInvoice.Print();
        }
    }
}
