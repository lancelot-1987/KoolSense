using System;
using hpCasl;
using CaslWmi;
using CaslSmBios;
namespace Test
{


	class MainClass
	{
		

		public static void Main (string[] args)
		{
           
            CommandInformation c = new CommandInformation();

            string[] commands  = c.SupportedGetCommands();
            foreach(string command in commands)
            {
                
                object value = null;
                Console.WriteLine("Command: " + command);
                
                c.Get(command, out value);
                Console.WriteLine("Value:" + value);
            }

            CommandDiags diags = new CaslWmi.CommandDiags();
            string[] getcommands = diags.SupportedGetCommands();
            foreach (string command in getcommands)
            {

                object value = null;
                Console.WriteLine("Command: " + command);

                diags.Get(command, out value);
                Console.WriteLine("Value:" + value);
            }

            CommandWireless feature = new CaslWmi.CommandWireless();
            getcommands = feature.SupportedGetCommands();
            foreach (string command in getcommands)
            {

                object value = null;
                Console.WriteLine("Command: " + command);

                feature.Get(command, out value);
                Console.WriteLine("Value:" + value);
            }


            object thermalStatus = null;
            byte status = 2;
            enReturnCode ret = diags.Get(Constants.DiagsThermalControl, out thermalStatus);
            Console.WriteLine("Thermal status is:" + ((byte[])thermalStatus)[2]);
            Console.WriteLine("Full string:"+ ((byte[])thermalStatus)[0]+" "+ ((byte[])thermalStatus)[1]+" "+ ((byte[])thermalStatus)[2]+" "+ ((byte[])thermalStatus)[3]);
            ((byte[])thermalStatus)[1] = status;

            ret = diags.Set(Constants.DiagsThermalControl, thermalStatus);
            ret = diags.Get(Constants.DiagsThermalControl, out thermalStatus);
            Console.WriteLine("Thermal status is:" + ((byte[])thermalStatus)[2]);
            Console.WriteLine("Full string:" + ((byte[])thermalStatus)[0] + " " + ((byte[])thermalStatus)[1] + " " + ((byte[])thermalStatus)[2] + " " + ((byte[])thermalStatus)[3]);
            
        }
    }
}
