using System;
using System.Collections.Generic;
using System.Text;

namespace VivinComputers
{
    sealed class UserInputAndOutput : ClassForSpareParts

    {
        int choice = 0, temp1 = 0;
        char temp3,temp;
       public static Double tAmount;
        int[] itemsArray = new int[100];
        int[] quantityArray = new int[100];
        int itr1 = 0, itr2 = 0;

        //Constructor for AbstractForSystemAssemble
        public UserInputAndOutput()
        {

        }
        //Destructor for AbstractForSystemAssemble
        ~UserInputAndOutput()
        {

        }
        void ItemDetails()
        {
            Console.WriteLine(" Price of Monitor");
            Console.WriteLine("      1-->  15 Inch:     ");
            Console.WriteLine("      2-->  16 Inch:     ");
            Console.WriteLine(" Price of Processor");
            Console.WriteLine("      3-->  I5 :         ");
            Console.WriteLine("      4-->  I7:          ");
            Console.WriteLine("      5-->  I10:         ");
            Console.WriteLine(" Price of Ram");
            Console.WriteLine("      6-->  4GB:         ");
            Console.WriteLine("      7-->  8GB:         ");
            Console.WriteLine("      8-->  Drive:       ");
            Console.WriteLine(" Price of Mouse");
            Console.WriteLine("      9-->  Wired:       ");
            Console.WriteLine("      10--> WireLess:    ");
            Console.WriteLine(" Price of KeyBoard");
            Console.WriteLine("      11--> 101 Keys:    ");
            Console.WriteLine("      12--> 103 Keys:   ");
            Console.WriteLine("      13--> Ports:       ");


        }

        //User Input's Here

        public void UserInput()
        {
            Console.WriteLine("Welcome To VIVIN COMPUTERS ");
            Console.WriteLine("1-->Set A new Price for all Items");
            Console.WriteLine("2-->Set A new Price for particular Items");
            Console.WriteLine("3-->View Price Of Items");
            Console.WriteLine("4-->System Assembly only");
            Console.WriteLine("5-->Spare Parts Only");
            Console.WriteLine("6-->Bill Genearation for System assembly");
            Console.WriteLine("7-->Bill Genearation for Spare Parts");
            Console.WriteLine("Choose the Option:-->");


            choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                if (choice == 1)
                {
                    SetPriceForAllItems();
                }
                else if (choice == 2)
                {
                    SetPriceForParticularItems();
                }

                else if (choice == 3)
                {
                    ViewPriceOfAllItems();
                }

                else if (choice == 4)
                {
                    SystemAssembly();
                }
                else if (choice == 5)
                {
                    SpareParts();
                }
                else if (choice == 6)
                {
                    BillGenerationForSystemAssemble();
                }
                else if (choice == 7)
                {
                    BillGenerationForSpareParts();
                }
                else
                {
                    Console.WriteLine("select the correct option ");
                   
                }
                Console.WriteLine("If u want to  continue--> Press 'Y' Or 'N'");
                temp = Convert.ToChar(Console.ReadLine());
                temp = Char.ToUpper(temp);
            } while (temp == 'Y');
        }

        public void UserInput2()
        {

            choice = Convert.ToInt32(Console.ReadLine());
            do { 
            temp1 = 0;
            if (choice == 1)
            {
                    Console.WriteLine("Enter the Price of Monitor 15 Inch:");
                    Monitor1 = Convert.ToDouble(Console.ReadLine());
            }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the Price of Monitor 16 Inch:");
                    Monitor2 = Convert.ToDouble(Console.ReadLine());
                }

                else if (choice == 3)
                {

                    Console.WriteLine("Enter the Price of Processor I5 :");
                    Processor1 = Convert.ToDouble(Console.ReadLine());

                }

                else if (choice == 4)
                {
                    Console.WriteLine("Enter the Price of Processor I7 :");
                   Processor2 = Convert.ToDouble(Console.ReadLine());

                }
                else if (choice == 5)
                {
                    Console.WriteLine("Enter the Price of Processor I10:");
                    Processor3= Convert.ToDouble(Console.ReadLine());

                }
                else if (choice == 6)
                {
                    Console.WriteLine("Enter the Price of RAM 4GB:");
                    Ram1 = Convert.ToDouble(Console.ReadLine());

                }
                else if (choice == 7)
                {
                    Console.WriteLine("Enter the Price of RAM 8GB:");
                    Ram2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == 8)
                {
                    Console.WriteLine("Enter the Price of Drive:");
                    Drive = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == 9)
                {
                    Console.WriteLine("Enter the Price of Mouse Wired:");
                    Mouse1 = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == 10)
                {
                    Console.WriteLine("Enter the Price of Mouse Wireless:");
                    Mouse2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == 11)
                {
                    Console.WriteLine("Enter the Price of Keyboard 101 Keys:");
                    KeyBoard1= Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == 12)
                {
                    Console.WriteLine("Enter the Price of RAM Keyboard 103 Keys:");
                    KeyBoard2= Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == 13)
                {
                    Console.WriteLine("Enter the Price of Ports:");
                    Ports = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("select the correct option ");
                    temp1 = 1;
                }
        }while( temp1==1);
        }

        public void SystemAssembly()
        {

        }
        public void SpareParts()
        {
            ItemDetails();
            Console.WriteLine("Enter the  Item option with QUANTITY");
            itr1 = 0;
            do
            {

                Console.WriteLine("Item Option:-->");
                itemsArray[itr1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantity-->");
                quantityArray[itr1] = Convert.ToInt32(Console.ReadLine());

                itr1 += 1;

                Console.WriteLine("If u want to Select more items Press 'Y' Or 'N'");
                temp3 = Convert.ToChar(Console.ReadLine());
                temp3 = Char.ToUpper(temp3);
            } while (temp3 == 'Y');
            Console.WriteLine("Items Selected Successfully");
        }

        void Bill(int ch, int i)

        {
           

            if (choice == 1)
            {
                Console.WriteLine("{0}    Monitor15  {2}        {3}",i,quantityArray[i],Monitor1);
                tAmount += Monitor1;
            }
            else if (choice == 2)
            {
                Console.WriteLine("{0}    Monitor16  {2}        {3}", i, quantityArray[i], Monitor2);
                tAmount += Monitor2;
            }

            else if (choice == 3)
            {

                Console.WriteLine("{0}    ProcessorI5  {2}        {3}", i, quantityArray[i], Processor1);
                tAmount += Processor1;
            }

            else if (choice == 4)
            {
                Console.WriteLine("{0}   ProcessorI7   {2}        {3}", i, quantityArray[i], Processor2);
                tAmount += Processor2;

            }
            else if (choice == 5)
            {
                Console.WriteLine("{0}   ProcessorI10  {2}        {3}", i, quantityArray[i], Processor3);
                tAmount += Processor3;

            }
            else if (choice == 6)
            {
                Console.WriteLine("{0}    Ram 4GB  {2}        {3}", i, quantityArray[i], Ram1);
                tAmount += Ram1;

            }
            else if (choice == 7)
            {
                Console.WriteLine("{0}    Ram 8GB  {2}        {3}", i, quantityArray[i], Ram2);
                tAmount += Ram2;
            }
            else if (choice == 8)
            {
                Console.WriteLine("{0}    Drive  {2}        {3}", i, quantityArray[i], Drive);
                tAmount += Drive;
            }
            else if (choice == 9)
            {
                Console.WriteLine("{0}    Mouse Wired  {2}        {3}", i, quantityArray[i], Mouse1);
                tAmount += Mouse1;
            }
            else if (choice == 10)
            {
                Console.WriteLine("{0}   Mouse Wireless  {2}        {3}", i, quantityArray[i], Mouse2);
                tAmount += Mouse2;
            }
            else if (choice == 11)
            {
                Console.WriteLine("{0}    Keyboard 101 Keys  {2}        {3}", i, quantityArray[i], KeyBoard1);
                tAmount += KeyBoard1;
            }
            else if (choice == 12)
            {
                Console.WriteLine("{0}    Keyboard 103 Keys {2}        {3}", i, quantityArray[i], KeyBoard2);
                tAmount += KeyBoard2;
            }
            else if (choice == 13)
            {
                Console.WriteLine("{0}    Ports {2}        {3}", i, quantityArray[i], Ports);
                tAmount += Ports;
            }
            
        }

        void BillGenerationForSystemAssemble()
        {
            Console.WriteLine("SLNO   DESCRIPTION   QUANTITY   AMOUNT");
            for ( itr2=0;itr2<itr1;itr2++)
            {
                Bill(itemsArray[itr2],itr2);
            }

           
            double b = ProfitCalculation(tAmount,1);
            tAmount += b;
            double a = GstCalculation(tAmount,5);
            Console.WriteLine("                      -------------------------");
            Console.WriteLine("                      GST     : {0}  ",a);
            Console.WriteLine("                      TOTAL   : {0}  ",tAmount+a);
            Console.WriteLine("                      -------------------------");
            tAmount = 0;
        }
        void BillGenerationForSpareParts()
        {

            Console.WriteLine("SLNO   DESCRIPTION   QUANTITY   AMOUNT");
            for (itr2 = 0; itr2 < itr1; itr2++)
            {
                Bill(itemsArray[itr2], itr2);
            }

            double a = GstCalculation(tAmount, 5);
            Console.WriteLine("                      -------------------------");
            Console.WriteLine("                      GST     : {0}  ", a);
            Console.WriteLine("                      TOTAL   : {0}  ", tAmount + a);
            Console.WriteLine("                      -------------------------");
            tAmount = 0;
        }
        void ViewPriceOfAllItems()
        {
            Console.WriteLine(" Price of Monitor");
            Console.WriteLine(" Price of 15 Inch:     {0}", Monitor1);
            Console.WriteLine(" Price of 16 Inch:     {0}", Monitor2);
            Console.WriteLine(" Price of Processor");
            Console.WriteLine(" Price of I5 :         {0}", Processor1);
            Console.WriteLine(" Price of I7:          {0}", Processor2);
            Console.WriteLine(" Price of I10:         {0}", Processor3);
            Console.WriteLine(" Price of Ram");
            Console.WriteLine(" Price of 4GB:         {0}", Ram1);
            Console.WriteLine(" Price of 8GB:         {0}", Ram2);
            Console.WriteLine(" Price of Drive:       {0}", Drive);
            Console.WriteLine(" Price of Mouse");
            Console.WriteLine(" Price of Wired:       {0}", Mouse1);
            Console.WriteLine(" Price of WireLess:    {0}", Mouse2);
            Console.WriteLine(" Price of KeyBoard");
            Console.WriteLine(" Price of 101 Keys:    {0}", KeyBoard1);
            Console.WriteLine(" Price of  103 Keys:   {0}", KeyBoard2);
            Console.WriteLine(" Price of Ports:       {0}", Ports);


        }
        void SetPriceForParticularItems()
        { 
            do
            {
               ItemDetails();
               UserInput2();
                Console.WriteLine("If u want to  Change price of another Press 'Y' Or 'N'");
                temp3=Convert.ToChar(Console.ReadLine());
                temp3 = Char.ToUpper(temp3);
            } while (temp3=='Y');
        }
        void SetPriceForAllItems()
        {

            Console.WriteLine("Enter the Price of Monitor");
            Console.WriteLine("Enter the Price of 15 Inch:");
            Monitor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of 16 Inch:");
            Monitor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Processor");
            Console.WriteLine("Enter the Price of I5 :");
            Processor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of I7:");
            Processor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of I10:");
            Processor3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Ram");
            Console.WriteLine("Enter the Price of 4GB:");
            Ram1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of 8GB:");
            Ram2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Drive");
            Drive = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Mouse");
            Console.WriteLine("Enter the Price of Wired:");
            Mouse1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of WireLess:");
            Mouse2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of KeyBoard");
            Console.WriteLine("Enter the Price of 101 Keys:");
            KeyBoard1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of  103 Keys:");
            KeyBoard2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Price of Ports");
            Ports = Convert.ToDouble(Console.ReadLine());
        }
    }
}


