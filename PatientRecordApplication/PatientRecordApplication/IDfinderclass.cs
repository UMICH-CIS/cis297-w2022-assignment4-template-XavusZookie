using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PatientRecordApplication
{
    class IDfinderclass
    {
        /// <summary>
        /// find id opens the employee data file
        /// then prompts the user and throwns an exception if the format is wrong or if the number is negative or if the input is empty
        /// then it searches through the file for the matching id and outputs it
        /// finally it closes the file
        /// </summary>
        public void findID()
        {
            int find;
            const string FILENAME = "EmployeeData.txt";
           FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            try
            {
                
                Write("Enter employee number >> ");
                find = Int32.Parse(ReadLine());

                if (find < 0)
                {
                    throw new User_DefinedException("ID numbers must be positive");
                }
            





            const char DELIM = ',';
            
            patientclass emp = new patientclass();
            
            string recordIn;
            string[] fields;
            WriteLine("\n{0,-5}{1,-12}{2,8}\n", "Num", "Name", "Balance");
            recordIn = reader.ReadLine();
            while (recordIn != null)
            {


                fields = recordIn.Split(DELIM);
                emp.IDNum = Convert.ToInt32(fields[0]);
                emp.Name = fields[1];
                emp.BalanceOwed = Convert.ToDouble(fields[2]);
                if (emp.IDNum == find)
                {
                    WriteLine("{0,-5}{1,-12}{2,8}", emp.IDNum, emp.Name, emp.BalanceOwed.ToString("C"));
                }
                recordIn = reader.ReadLine();
            }
            

            }
            catch (User_DefinedException f)
            {
                WriteLine(f.Message);
            }
            catch (FormatException)
            { 
                WriteLine("INVALID format\n");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    inFile.Close();
                }

            }
        }

    }

    public class idfinderclass
    {
    }
}
