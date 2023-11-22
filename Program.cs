using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using ParallelFileSearcher; 

class Program
{
    static IConfiguration Configuration { get; set; }

    static void Main(string[] args)
    {
        
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        
        var directoryPath = Configuration["FileSearchConfig:DirectoryPath"];
        var fileExtension = Configuration["FileSearchConfig:FileExtension"];

        
        var searcher = new FileSearcherParallel();
        var foundFiles = searcher.FindFilesWithExtension(directoryPath, fileExtension);

        
        foreach (var file in foundFiles)
        {
            Console.WriteLine(file);
        }

        Console.WriteLine($"{foundFiles.Count} files found with extension {fileExtension}.");
    }
}
