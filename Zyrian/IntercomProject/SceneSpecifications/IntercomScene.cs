using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.SceneSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject
{
    public class IntercomScene : Scene
    {
        private ObjectHolder _objectHolder = new ObjectHolder();
        private ObjectAdder _objectAdder = new ObjectAdder();
        private IntercomSceneMenu _menu;
        private List<Person> _people = new List<Person>();
        private House _house = new House();
        
        public override void Start()
        {
            _menu = new IntercomSceneMenu(_objectAdder, _objectHolder);
            _menu.DisplayMenu();
            LoadObjectsFromHolder();
            _house.TakeSomebody(MovePeopleToHouse());
            _house.VisitorsTriesOpenDoor();
        }

        private void LoadObjectsFromHolder()
        {
            foreach (var person in _objectHolder.people)
            {
                _people.Add(person);
                //_objectHolder.people.Remove(person);
            }
        }

        private Person MovePeopleToHouse()
        {
            foreach (var person in _people)
            {
                return person;
            }
            return null;
        }
    }
}
