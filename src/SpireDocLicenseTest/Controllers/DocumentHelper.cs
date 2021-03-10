using System;
using System.IO;
using Spire.Doc;

namespace SpireDocLicenseTest.Controllers
{
    public class DocumentHelper
    {
        public void Run()
        {
            Console.WriteLine("run starting...");
            var dir = Environment.CurrentDirectory;
            Console.WriteLine($"dir: {dir}");
            var source = Path.Combine(dir,"source.docx");
            Console.WriteLine($"dir: {source}");
            var dest = Path.Combine(dir, "zzz.pdf");
            Console.WriteLine($"dir: {dest}");
            if (File.Exists(dest))
            {
                Console.WriteLine("deleting file");
                File.Delete(dest);
            }
            
            var doc = new Document();
            doc.LoadFromFile(source);
            doc.SaveToFile(dest, FileFormat.PDF);
            Console.WriteLine("done.");
        }
    }
}