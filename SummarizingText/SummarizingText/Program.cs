using System;
using System.Text;


namespace SummarizingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a really really really really really really a long sentence...";

            //Console.WriteLine( StringUtility.SummarizeText(sentence));
            var builder = new StringBuilder("Hello World");
            
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header")
            .AppendLine()
            .Append('-', 10);


            builder.Replace('-', '+');

            builder.Remove(0, 10)
                .Insert(0, new String('-', 10));

            Console.WriteLine(builder[23]);

            Console.WriteLine(builder);



        }
    }
}
