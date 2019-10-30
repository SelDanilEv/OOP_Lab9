using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab9
{
    class Programmer
    {
        public delegate void Deleg();

        private NotificationS _myNotific;
        private MessagesS _myMessage;
        private int _counterSub;

        public MessagesS GetMessage { get { return _myMessage; } }
        public NotificationS GetNotific { get { return _myNotific; } }

        public Programmer(NotificationS not, MessagesS mes)
        {
            this._myNotific = not;
            this._myMessage = mes;
            Console.WriteLine("Был создан объект programmer");
        }

        private event Deleg _OnDelete;
        private event Deleg _OnMute;


        public void showAll()
        {
            string str = "\nNotifications";
            foreach (string i in GetNotific)
            {
                str += '\n' + i;
            }
            str += "\n\nMessages";
            foreach (string i in GetMessage)
            {
                str += '\n' + i;
            }
            Console.WriteLine(str);
        }

        public event Deleg OnDelete
        {
            add
            {
                if (_counterSub < 3)
                {
                    _OnDelete += value;
                    _counterSub++;
                }
                else
                    Console.WriteLine("\nПревышение максимального кол-во подписок");
            }
            remove
            {
                if (_counterSub > 0)
                {
                    _OnDelete -= value;
                    _counterSub--;
                }
                else
                    Console.WriteLine("\nПодписок не осталось.Нечего отписать((((");
            }
        }
        public event Deleg OnMute
        {
            add
            {
                if (_counterSub < 3)
                {
                    _OnDelete += value;
                    _counterSub++;
                }
                else
                    Console.WriteLine("\nПревышение максимального кол-во подписок");
            }
            remove
            {
                if (_counterSub > 0)
                {
                    _OnDelete -= value;
                    _counterSub--;
                }
                else
                    Console.WriteLine("Подписок не осталось.Нечего отписать((((");
            }
        }

        public void Delete() => _OnDelete?.Invoke();
        public void Mute() => _OnMute?.Invoke();
        public void Do() => (_OnDelete + _OnMute)?.Invoke();
    }
}
