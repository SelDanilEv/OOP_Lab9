using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab9
{
    class MessagesS : List<string>
    {
        private bool _sound = true;

        public MessagesS(bool sound, string[] actions)
        {
            _sound = sound;
            foreach (string i in actions)
            {
                this.Add(i);
            }
            Console.WriteLine("Был создан объект messages");
        }

        public void IfCount()
        {
            if (this.Count > 0)
            {
                Console.WriteLine($"\nСообщение удалено. Осталось {this.Count-1} уведомлений");
                delete();
            }
            else Console.WriteLine("\nСообщений больше нет");
        }

        public void delete() => this.RemoveAt(0);

        public void Mute()
        {
            if (_sound)
                Console.WriteLine($"\nЗвук cообщений был выключен");
            else
                Console.WriteLine($"\nЗвук сообщений был включен");
            _sound = !_sound;
        }
    }

    class NotificationS:List<string>
    {
        private bool _sound = true;

        public NotificationS(bool sound, string[] actions)
        {
            _sound = sound;
            foreach(string i in actions)
            {
                this.Add(i);
            }
            Console.WriteLine("Был создан объект notification");
        }

        public void IfCount()
        {
            if (this.Count > 0)
            {
                Console.WriteLine($"\nУведомление удалено. Осталось {this.Count-1} уведомлений");
                delete();
            }
            else Console.WriteLine("\nСообщений больше нет");
        }

        public void delete() => this.RemoveAt(0);

        public void Mute()
        {
            if (_sound)
                Console.WriteLine($"\nЗвук cообщений был выключен");
            else
                Console.WriteLine($"\nЗвук сообщений был включен");
            _sound = !_sound;
        }
    }
}
