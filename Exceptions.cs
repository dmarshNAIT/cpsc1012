using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            const string LOG_FILE = @"C:\LogFiles\Logfile.txt";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(LOG_FILE);
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
            } // end try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Wrong or missing file.");
            } // end catch
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File stream is closed.");
                } // end if
                else
                {
                    Console.WriteLine("File stream is null.");
                } // end else

                try
                {
                    StreamWriter writer = new StreamWriter(LOG_FILE);
                    writer.WriteLine("Log entry #1"); // overwrites existing text
                    writer.Close();
                } // end try
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("File does not exist.");
                } // end catch
            } // end finally
            Console.ReadLine();
        } // eom
    } // eoc
} // eon
