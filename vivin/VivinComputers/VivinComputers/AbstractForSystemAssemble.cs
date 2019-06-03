using System;
using System.Collections.Generic;
using System.Text;

namespace VivinComputers
{
    public abstract class AbstractForSystemAssemble : IinterfaceForProfitCalculation, IInterfaceForGstCalculation
    {

        public double gst, profit;
        //Constructor for AbstractForSystemAssemble
        public AbstractForSystemAssemble()
        {

        }
        //Destructor for AbstractForSystemAssemble
        ~AbstractForSystemAssemble()
        {

        }
        //Display parts for System assembling and Spare Parts Sale
       

        //Display parts for System assembling and Spare Parts Sale
        public void DisplayPartsOfSpareParts()
        {
            Console.WriteLine("1--Monitor ");
            Console.WriteLine("2--Speed   ");
            Console.WriteLine("3--RAM    ");
            Console.WriteLine("4--DRIVE   ");
            Console.WriteLine("5--Mouse  ");
            Console.WriteLine("6--Keyboard ");
            Console.WriteLine("7--PORTS   ");
        }
        public double GstCalculation(double amount, double gst)
        {

            this.gst = gst;
            amount = amount + (amount * (gst / 100));
            return amount;
        }
        public double ProfitCalculation(double amount, double profit)
        {
            this.profit = profit;
            amount = amount + (amount * (profit / 100));
            return amount;
        }


    }
}

