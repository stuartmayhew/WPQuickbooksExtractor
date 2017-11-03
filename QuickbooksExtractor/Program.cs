using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickbooksExtractor.Helpers;

namespace QuickbooksExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            //KillProcess();
            //int vendCount = QBDataPump.PumpAllVendors("W");
            KillProcess();
            int custCount = QBDataPump.PumpAllCustomers("W");
            //KillProcess();
            //int emCount = QBDataPump.PumpAllEmployees("W");
            //KillProcess();
            //int clsCount = QBDataPump.PumpAllClass("W");
            //KillProcess();
            //int prItemCount = QBDataPump.PumpAllPayrollItems("W");
            //KillProcess();

            DateTime end = DateTime.Now;
            Console.WriteLine("DONE start " + start + " done " + end);

            start = DateTime.Now;
            //KillProcess();
            //vendCount = QBDataPump.PumpAllVendors("K");

            custCount = QBDataPump.PumpAllCustomers("K");
            KillProcess();
            //emCount = QBDataPump.PumpAllEmployees("K");
            //KillProcess();
            //clsCount = QBDataPump.PumpAllClass("K");
            //KillProcess();
            //prItemCount = QBDataPump.PumpAllPayrollItems("K");
            //KillProcess();

            end = DateTime.Now;

            start = DateTime.Now;

            //custCount = QBDataPump.PumpAllCustomers("O");
            //KillProcess();
            //emCount = QBDataPump.PumpAllEmployees("O");
            //KillProcess();
            //clsCount = QBDataPump.PumpAllClass("O");
            //KillProcess();
            //prItemCount = QBDataPump.PumpAllPayrollItems("O");
            //KillProcess();

            end = DateTime.Now;
            Console.WriteLine("DONE start " + start + " done " + end);
        }

        private static void KillProcess()
        {
            Process[] proc = Process.GetProcessesByName("QBW32");
            if (proc.Count() > 0)
                proc[0].Kill();
        }
    }
}
