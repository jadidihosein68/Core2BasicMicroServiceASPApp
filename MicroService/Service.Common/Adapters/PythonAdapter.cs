using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Service.Common.Adapters
{
    public class PythonAdapter : IPythonAdapter
    {

        public PythonAdapter()
        {

            

        }



        public string get()
        {

            const string python = @"your python engine path";

            // python app to call
            const string myPythonApp = @"your python script path";

            // dummy parameters to send Python script
            int x = 2;
            int y = 5;

            // Create new process start info
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // start python app with 3 arguments 
            // 1st arguments is pointer to itself, 2nd and 3rd are actual arguments we want to send
            myProcessStartInfo.Arguments = myPythonApp + " " + x + " " + y;

            Process myProcess = new Process();
            // assign start information to the process
            myProcess.StartInfo = myProcessStartInfo;

            // start the process
            myProcess.Start();

            // Read the standard output of the app we called. 
            // in order to avoid deadlock we will read output first and then wait for process terminate:
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            /*if you need to read multiple lines, you might use:
                string myString = myStreamReader.ReadToEnd() */

            // wait exit signal from the app we called and then close it.
            myProcess.WaitForExit();
            myProcess.Close();


            return myString; 
        }

    }
}
