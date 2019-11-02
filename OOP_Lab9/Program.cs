using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab9
{
    class Program
    {
        public static string startconf, newstr1;

        static void Main(string[] args)
        {
            string[] buff = { "it", "is", "not", "empty" };
            NotificationS notification = new NotificationS(true, buff);
            buff = new string[] { "hey", "why", "do", "you", "read", "this" };
            MessagesS messages = new MessagesS(true, buff);
            Programmer programmer = new Programmer(notification, messages);
            //Programmer programmer2 = new Programmer();
            programmer.showAll();
            programmer.OnDelete += programmer.GetNotific.IfCount;
            programmer.OnMute += programmer.GetMessage.Mute;
            programmer.OnDelete += programmer.GetMessage.IfCount;

            //programmer.OnDelete += notification.IFCOUNT;
            //programmer.OnDelete += messages.IFCOUNT;
            //programmer.OnMute += messages.Mute;
            //programmer.OnMute += notification.Mute;
            //programmer.OnDelete += notification.IFCOUNT;
            //programmer.OnDelete += messages.IFCOUNT;
            //programmer.OnMute += messages.Mute;
            //programmer.OnMute += notification.Mute;

            //programmer2.OnMute += messages.Mute;
            //programmer2.OnMute += notification.Mute;
            //programmer2.OnDelete += messages.IFCOUNT;
            //programmer2.OnDelete += notification.IFCOUNT;


            programmer.Do();
            programmer.showAll();
            //programmer2.Do();

            Console.WriteLine("\n String Treatment \n");

            StringTreatment stringTreatment = new StringTreatment();

            startconf = "This,         : Is!       Example.";
            newstr1 = startconf;
            Console.WriteLine(newstr1 + "\n Start configuration");

            //Console.WriteLine("\t+\t To Lower Case");
            //stringTreatment.func1 = stringTreatment.toLowerCase;

            //newstr1 = stringTreatment.func1(newstr1);
            //Console.WriteLine(newstr1.Append('\n'));

            //Console.WriteLine("\t-\t To Lower Case");
            //stringTreatment.func1 -= stringTreatment.toLowerCase;
            //Console.WriteLine("\t+\t To Upper Case");
            //stringTreatment.func1 += stringTreatment.toUpperCase;

            //newstr1 =  stringTreatment.func1(newstr1);
            //Console.WriteLine(newstr1);

            //Console.WriteLine("\t-\t To Upper Case");
            //stringTreatment.func1 -= stringTreatment.toUpperCase;
            Console.WriteLine("\t+\t To Delete Signs");
            stringTreatment.func1 = stringTreatment.delSigns;
            Console.WriteLine("\t+\t To Delete Space");
            stringTreatment.func1 += stringTreatment.delSpace;
            newstr1 = startconf;

            newstr1 =  stringTreatment.func1(newstr1);
            Console.WriteLine(newstr1);

            stringTreatment.func2 = stringTreatment.addSymbol;
            newstr1 = stringTreatment.func2(4,'q',newstr1);
            Console.WriteLine(newstr1);


            Console.ReadKey();
        }
    }
}