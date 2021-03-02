using CommandLine;
using CommandLine.Text;
using Sorter.Service.Contracts;
using System;
using System.Linq;

namespace Sorter.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var parser = new Parser(with => with.CaseInsensitiveEnumValues = true);
                var parserResults = parser.ParseArguments<SortOptions>(args)
                    .WithParsed(opts => 
                    {
                        var sortResults = new Sorter().Sort(opts);
                        var sortMessage = String.Join(Environment.NewLine, sortResults.Select(result
                            => $"Algorithm: {Enum.GetName(result.Algorithm)}, Sorted Numbers: [{String.Join(',', result.SortedNumbers)}], Speed: {result.Speed.TotalMilliseconds}ms"));
                        Console.WriteLine(sortMessage);
                    })
                    .WithNotParsed(errors => 
                    {
                        var sentenceBuilder = SentenceBuilder.Create();
                        var errorMessage = String.Join(Environment.NewLine, errors.Select(error => sentenceBuilder.FormatError(error)));
                        Console.WriteLine(errorMessage);
                    });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
