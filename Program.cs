using System;
using System.IO;



    class Program
    {
        static void Main(string[] args)
        {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"F:\New folder (3)\Data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            Console.ReadLine();
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine("Check the file Name", ex.FileName);
            Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
            Console.WriteLine("final block");
            
        }
            }
        }







 
