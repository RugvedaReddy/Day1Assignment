using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class ReadWrite
    {
        public void WriteFile(string fname)
        {
            StreamWriter write = new StreamWriter(fname,true);

            try
            {
                
                Console.WriteLine("enter data to be written to file");
                string data = Console.ReadLine();
                write.WriteLine(data);
                Console.WriteLine("data written to file");
            }
            catch(IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                write.Close();
            }

        }
        public void ReadFile(string fname)
        {
            StreamReader read = new StreamReader(fname);
            try
            {

                string data = read.ReadToEnd();
                Console.WriteLine("data read from file");
                Console.WriteLine(data);

            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                read.Close();
            }

        }
    }
}
