using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //     Case1();
            //    Case2();
            //    Case3();
            //   Case4();
            Case5();
        }
        public static void Case1()
        {
            LineItem lineItem;
            ArrayList card = new ArrayList();
            card.Add(new LineItem("Pen", 25, 15));
            card.Add(new LineItem("Book", 5, 75));
            card.Add(new LineItem("mobile", 2, 15000));
            card.Add("Akash");
            card.Add("123");
            card.Add(true);

            foreach (object element in card)
            {
                lineItem = (LineItem)element;
                double total = lineItem.CalaculateTotal();
                Console.WriteLine(total);
            }
        }
        public static void Case2()
        {

            List<LineItem> card = new List<LineItem>();
            LineItem lineItem;

            card.Add(new LineItem("Pen", 25, 15));
            card.Add(new LineItem("Book", 5, 75));
            card.Add(new LineItem("mobile", 2, 15000));


            foreach (object element in card)
            {
                lineItem = (LineItem)element;
                double total = lineItem.CalaculateTotal();
                Console.WriteLine(lineItem.ProductName + " Total Price :" + total);
            }
        }
        public static void Case3()
        {
            HashSet<LineItem> card = new HashSet<LineItem>();


            card.Add(new LineItem("Pen", 25, 15));
            card.Add(new LineItem("Psn", 25, 15));
            card.Add(new LineItem("Pn", 25, 15));

            Console.WriteLine(card.Count);

        }
        public static void Case4()
        {
            HashSet<Student> addStudent = new HashSet<Student>();
            Student student;
            addStudent.Add(new Student(1, 10, "Akash"));
            addStudent.Add(new Student(10, 1, "Akash"));

            Console.WriteLine(addStudent.Count);
            foreach(object ele in addStudent)
            {
                student = (Student)ele;
                Console.WriteLine(student.Name+" "+student.RollNo+" "+student.Standared);
            }
        }
        public static void Case5()
        {
            Dictionary<Student, Student> dStudent = new Dictionary<Student, Student>();
            
            Student akash = new Student(1, 10, "aksh");
            Student dhruv = new Student(2, 11, "dhruv");
            Student dhruv2 = new Student(2, 11, "dhruv");

            dStudent.Add( akash,akash);
            dStudent.Add(dhruv,dhruv);


            dStudent.Add(dhruv2, dhruv2);

            Console.WriteLine(dStudent.Count);
        }
    }
}
