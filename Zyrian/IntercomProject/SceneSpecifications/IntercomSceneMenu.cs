using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications
{
    public class IntercomSceneMenu
    {
        private ObjectAdder _objectAdder;
        private ObjectHolder _objectHolder;

        public IntercomSceneMenu(ObjectAdder objectAdder, ObjectHolder objectHolder)
        {
            _objectAdder = objectAdder;
            _objectHolder = objectHolder;
        }

        public string PrintMenu()
        {
            Console.WriteLine("1 - Добавить гостя");
            Console.WriteLine("2 - Добавить владельца дома");
            return Console.ReadLine();
        }

        public void DisplayMenu()
        {
            switch (PrintMenu())
            {
                case "1": 
                    _objectHolder.people.Add(_objectAdder.AddGuest()); 
                    
                    break;

                case "2": 
                   _objectHolder.people.Add(_objectAdder.AddHouseOwner()); 
                    break;

                default:
                    Console.WriteLine("Такого пункта меню нет!");
                    break;
            }
        }
    }
}
