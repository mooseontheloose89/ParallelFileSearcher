using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelFileSearcher
{
    public class FileSearcherParallel
    {
        public ConcurrentBag<string> FindFilesWithExtension(string rootPath, string extension)
        {
            var files = new ConcurrentBag<string>();
            
            try
            {
                var directFiles = Directory.GetFiles(rootPath, $"*{extension}");
                foreach (var file in directFiles)
                {
                    files.Add(file);
                }
                Console.WriteLine($"Direct files found in root: {directFiles.Length}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error accessing root path {rootPath}: {ex.Message}");
            }


            foreach (var dir in Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories))
            {
                try
                {

                    foreach (var file in Directory.GetFiles(dir, $"*{extension}"))
                    {
                        files.Add(file);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}: Access denied to {dir}. Skipping...");
                }
            }           

            return files;
        }
    }
}
