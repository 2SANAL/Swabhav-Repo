using System;
using InterfaceApp.Crud;
using InterfaceApp.Vehical;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();
            CaseStudy2();
        }
        public static void CaseStudy1()
        {
            DoDbOperation(new CustomerDB());
            Console.WriteLine();
            DoDbOperation(new InvoiceDb());
            Console.WriteLine();
            DoDbOperation(new DepartmentDB());
        }
        public static void DoDbOperation(ICrudable icrudable)
        {
            Console.WriteLine("In side DoDbOperation");
            icrudable.Create();
            icrudable.Read();
            icrudable.Delete();
            icrudable.Update();
        }
        public static void CaseStudy2()
        {

            IMovable[] imoveable = new IMovable[3];
            imoveable[0] = new Bika();
            imoveable[1] = new Car();
            imoveable[2] = new Truk();
            StartRace(imoveable);

        }
        public static void StartRace(IMovable[] movable)
        {

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine("Inside start Race");
                movable[index].Move();
            }
        }


    }
}
