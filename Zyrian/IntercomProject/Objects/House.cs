using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.KeyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.Objects
{
    public class House
    {
        private Intercom _intercom = new Intercom();
        private Door _door = new Door();
        private Key _key;
        private List<Person> _visitors = new List<Person>();

        /// <summary>
        /// Позволяет поставить рядом с домофоном человека
        /// </summary>
        /// <param name="person"></param>
        public void TakeSomebody(Person person) => _visitors.Add(person);

        /// <summary>
        /// Позволяет убрать от домофона человека
        /// </summary>
        /// <param name="person"></param>
        public void DeleteSomebody(Person person) => _visitors.Remove(person);

        /// <summary>
        /// Вставляет ключ
        /// </summary>
        /// <param name="key"> Ключ </param>
        /// <returns> ключ </returns>
        public Key PutKey(Key key) => key;

        /// <summary>
        /// Посетители пытаются открыть дверь
        /// </summary>
        public void VisitorsTriesOpenDoor()
        {
            foreach (var visitor in _visitors)
            {
                if (visitor is Guest)
                {
                    visitor.PersonJoined += OnGuestJoined;
                    visitor.TryOpenDoor();
                }
                else if(visitor is HouseOwner)
                {
                    visitor.PersonJoined += OnHouseOwnerJoined;
                    _key = PutKey((visitor as HouseOwner).PutKeyOnIntercom());
                    visitor.TryOpenDoor();
                }
                else
                {
                    visitor.PersonJoined += OnBanditoJoined;
                    _key = PutKey((visitor as Bandito).PutKeyOnIntercom());
                    visitor.TryOpenDoor();
                }
            }
        }

        /// <summary>
        /// Срабатывает, когда происходит разблокировка двери.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void OnDoorUnlocked(object sender, EventArgs eventArgs)
        {
            _door.Open();
            PrintDebugOpenDoorInfo();
        }

        /// <summary>
        /// Срабатывает по пришествию гостя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void OnGuestJoined(object sender, EventArgs eventArgs) => PrintGuestJoinedInfo();

        /// <summary>
        /// Срабатывает по пришествию владельца
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void OnHouseOwnerJoined(object sender, EventArgs eventArgs)
        {
            PrintOwnerJoinedInfo();
            _intercom.DoorUnlocked += OnDoorUnlocked;
            _intercom.TakeKey(_key);

            _intercom.IsAbleToDoorOpen(_door);
            _intercom.DoorUnlocked -= OnDoorUnlocked;
        } 
        
        /// <summary>
        /// Срабатывает по пришествию бандита
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void OnBanditoJoined(object sender, EventArgs eventArgs)
        {
            PrintBanditoJoinedInfo();
            _intercom.DoorUnlocked += OnDoorUnlocked;
            _intercom.TakeKey(_key);

            _intercom.IsAbleToDoorOpen(_door);
            _intercom.DoorUnlocked -= OnDoorUnlocked;
        }

        private void PrintDebugOpenDoorInfo() => Console.WriteLine("Door was opened!");
        private void PrintGuestJoinedInfo() => Console.WriteLine("Hi, I'm Guest!");
        private void PrintOwnerJoinedInfo() => Console.WriteLine("Hi, I'm Owner!");
        private void PrintBanditoJoinedInfo() => Console.WriteLine("Hi, I'm Bandito!");
    }
}
