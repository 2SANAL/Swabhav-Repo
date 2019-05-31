using System;
using System.IO;
namespace ReadInputFileApp
{
    class Program
    {
        


        static void Main(string[] args)
        {
            ReadFill Objread = new ReadFill();
            WriteFile ObjWrite = new WriteFile();

            //ObjWrite.WriteDataToFileUArray();
            //ObjWrite.WriteDataText();
            ObjWrite.StreamWrite();
            //Objread.ReadFileLine();
            //Objread.ReadFileStream();
            //Objread.ReadFiletext(); 
            
        }
    }
}
