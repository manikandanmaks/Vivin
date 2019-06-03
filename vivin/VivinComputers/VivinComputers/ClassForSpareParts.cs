using System;
using System.Collections.Generic;
using System.Text;

namespace VivinComputers
{
    class ClassForSpareParts : AbstractForSystemAssemble, IInterfaceForGstCalculation
    {
        private double monitor15, monitor16, processorI5, processorI7, processorI10, ram4, ram8, drive, mouseWired, mouseWireLess, keyBoard101, keyBoard103, ports;
        //properties for price of items
        public int option = 0;
        public double Monitor1
        {
            get
            {
                return monitor15;
            }
            set
            {
                monitor15 = value;
            }
        }
        public double Monitor2
        {
            get
            {
                return monitor16;
            }
            set
            {
                monitor16 = value;
            }
        }
        public double Processor1

        {
            get
            {
                return processorI5;
            }
            set
            {
                processorI5 = value;
            }
        }
        public double Processor2
        {
            get
            {
                return processorI7;
            }
            set
            {
                processorI7 = value;
            }
        }
        public double Processor3
        {
            get
            {
                return processorI10;
            }
            set
            {
                processorI10 = value;
            }
        }
        public double Ram1
        {
            get
            {
                return ram4;
            }
            set
            {
                ram4 = value;
            }
        }
        public double Ram2
        {
            get
            {
                return ram8;
            }
            set
            {
                ram8 = value;
            }
        }
        public double Drive
        {
            get
            {
                return drive;
            }
            set
            {
                drive = value;
            }
        }
        public double KeyBoard1
        {
            get
            {
                return keyBoard101;
            }
            set
            {
                keyBoard101 = value;
            }
        }
        public double KeyBoard2
        {
            get
            {
                return keyBoard103;
            }
            set
            {
                keyBoard103 = value;
            }
        }
        public double Ports
        {
            get
            {
                return ports;
            }
            set
            {
                ports = value;
            }
        }
        public double Mouse1
        {
            get
            {
                return mouseWired;
            }
            set
            {
                mouseWired = value;
            }
        }
        public double Mouse2
        {
            get
            {
                return mouseWireLess;
            }
            set
            {
                mouseWireLess = value;
            }
        }
       
        public int SelectOption()
        {

            Console.WriteLine("Select the Option: ");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        public int SwitchMethod(int opt)
        {

            switch (opt)
            {
                case 1:
                    Console.WriteLine("Select the option for 1 --> 15 Inch  2--> 16 Inch :");

                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 2");
                    break;
                case 4:
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                    Console.WriteLine("Case 2");
                    break;
                case 6:
                    Console.WriteLine("Case 2");
                    break;
                case 7:
                    Console.WriteLine("Case 2");
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return 0;
        }


    }
}



