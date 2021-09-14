using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications
{
    public class IntercomSceneMenu
    {       
        private List<ObjectHolder> _objectHolders;
        private ObjectHolderInteractor _interactor;
        private ObjectAdder _objectAdder = new();

        public IntercomSceneMenu(ObjectHolderInteractor interactor, List<ObjectHolder> objectHolders)
        {
            _interactor = interactor;
            _objectHolders = objectHolders;
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
                    _interactor.AddPeopleHolder();
                    _interactor.AddPerson(_objectAdder.AddGuest());
                    
                    break;

                case "2":
                    _interactor.AddPeopleHolder();
                    _interactor.AddPerson(_objectAdder.AddHouseOwner());
                    break;

                default:
                    Console.WriteLine("Такого пункта меню нет!");
                    break;
            }
        } 
    }
}
