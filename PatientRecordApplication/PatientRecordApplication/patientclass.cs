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
    class patientclass
    {
        /// <summary>
        /// patient class opens the files and then loops through a prompt for the user
        /// then prompts the user and throwns an exception if the format is wrong or if the number is negative or if the input is empty
        /// then it saves the data to the file and asks the user if they want to continue, it errors if they input nothing or the wrong format and exits
        /// finally it closes the file
        /// </summary>

        public int IDNum { get; set; }
        public string Name { get; set; }
        public double BalanceOwed { get; set; }
        private const String filename = "EmployeeData.txt";

        public void save()
        {
            
                
                int sentinel = 0;
                int END = 999;
                char DELIM = ',';

                    while (sentinel != END)
                    {
                        FileStream outFile = new FileStream(filename, FileMode.Append);
                        StreamWriter writer = new StreamWriter(outFile);
                        try
                        {
                            Write("Enter employee number >> ");
                            IDNum = Int32.Parse(ReadLine());
                    
                    if (IDNum < 0)
                            {
                                throw new User_DefinedException("ID numbers must be positive");
                            }
                            Write("Enter last name >> ");
                            Name = ReadLine();
                    if (Name == "")
                    {
                        throw new User_DefinedException("A name must be inputted");

                    }
                    Write("Enter balance to be paid >> ");
                            BalanceOwed = Convert.ToDouble(ReadLine());
                    if (BalanceOwed < 0)
                    {
                        throw new User_DefinedException("Balance owed must be positive");
                    }
                    
                    writer.WriteLine((IDNum.ToString()) + DELIM + Name + DELIM + BalanceOwed);
                           

                        try { 
                            Write("Enter "+END+ " to exit or another number to continue >> "); 
                            sentinel = Convert.ToInt32(ReadLine());
                            
                        }
                        catch(FormatException )
                        {
                            Write("INVALID: Exiting\n");
                            sentinel = END;
                        }
                    finally
                    {
                        Write("User data has been saved\n");
                    }
                        }
                        catch(User_DefinedException f)
                        {
                            WriteLine(f.Message);
                            WriteLine("INVALID: Please reenter patient data\n");
                        }
                        catch(FormatException )
                        {
                            Write("INVALID: Please reenter patient data\n");
                            
                        }
                finally
                {
                    if(writer != null)
                    {
                    writer.Close();
                    outFile.Close();
                    }

                }
                
                    
                
                    }

                    
                   
                               
        }

    }

    public class Patientclass
    {
    }
}
