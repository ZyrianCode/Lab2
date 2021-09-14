using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.Objects;
using Lab2.Zyrian.IntercomProject.SceneSpecifications;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject
{
    public class IntercomScene : Scene
    {
        private List<ObjectHolder> _objectHolder = new();
        private ObjectHolderInteractor _interactor;
        private IntercomSceneMenu _menu;
        private List<Person> _people = new List<Person>();
        private House _house = new House();
        
        public override void Start()
        {
            _interactor = new(_objectHolder);
            _menu = new IntercomSceneMenu(_interactor, _objectHolder);
            _menu.DisplayMenu();
            LoadObjectsFromHolder();
            _interactor.DeepClear();
            _house.TakeSomebody(MovePeopleToHouse());
            _house.VisitorsTriesOpenDoor();
        }

        private void LoadObjectsFromHolder() => _people = _interactor.Load().LoadPeople();

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
