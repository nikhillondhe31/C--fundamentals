using System;
using System.IO;

namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\nikhi\Desktop\";
            /*
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {

            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            var mybool = fileInfo.Exists;*/

            //Directory

            Directory.CreateDirectory(path);

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var path2 = @"C:\Users\nikhi\Desktop\";

            Console.WriteLine(Path.GetExtension(path2));

        }
    }
}
