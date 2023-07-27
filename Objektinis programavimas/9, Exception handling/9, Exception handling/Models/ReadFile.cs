using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Exception_handling.Models
{
    internal class ReadFile
    {
        public ReadFile(string path) 
        {
            Path = path;
        }
        public string Path { get; set; }

        public void TryReadFile()
        {
            try
            {
                string text = File.ReadAllText(Path, Encoding.UTF8);
                var fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (var reader = new StreamReader(fileStream))
                {
                    text = reader.ReadToEnd();
                }
                fileStream.Close();
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file  cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory cannot be found.");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("The drive specified in 'path' is invalid.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("'path' exceeds the maximum supported path length.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permission to create this file.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                Console.WriteLine("There is a sharing violation.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                Console.WriteLine("The file already exists.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An exception occurred:\nError code: " +
                                  $"{e.HResult & 0x0000FFFF}\nMessage: {e.Message}");
            }

        }
    }
}
