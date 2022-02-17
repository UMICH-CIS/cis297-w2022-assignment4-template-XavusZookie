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
    class Readerclass
    {
        /// <summary>
        /// reader class opens the employee data file loops through each line
        /// then it ouputs each line to the user
        /// finally it closes the file
        /// </summary>
        public void readfile()
        { 
        const char DELIM = ',';
        const string FILENAME = "EmployeeData.txt";
        patientclass emp = new patientclass();
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
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
                WriteLine("{0,-5}{1,-12}{2,8}",
                   emp.IDNum, emp.Name, emp.BalanceOwed.ToString("C"));
                recordIn = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
        }


    }

    public class readerclass
    {
    }
}
