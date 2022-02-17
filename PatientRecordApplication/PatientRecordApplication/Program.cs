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
    class Program
    {
        /// <summary>
        /// runs the classes to do the reqquested functions
        /// </summary>
        static void Main(string[] args)
        {
            patientclass emp = new patientclass();
            emp.save();
            Readerclass red = new Readerclass();
            red.readfile();
            IDfinderclass id = new IDfinderclass();
            id.findID();
            balancefinderclass bal = new balancefinderclass();
            bal.findbalance();

            ReadLine();
        }
    }

    public class program
    {
    }
}
