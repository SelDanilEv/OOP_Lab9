using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] buff = { "it", "is", "not", "empty" };
            NotificationS notification = new NotificationS(true, buff);
            buff = new string[]{"hey", "why", "do", "you", "read", "this"};
            MessagesS messages = new MessagesS(true,buff);
            Programmer programmer = new Programmer(notification,messages);
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

            Console.ReadKey();
        }
    }
}

