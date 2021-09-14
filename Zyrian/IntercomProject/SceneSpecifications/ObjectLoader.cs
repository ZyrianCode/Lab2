using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications
{
    public class ObjectLoader
    {
        private List<ObjectHolder> _objectHolders;
        private List<Person> _people;

        public ObjectLoader(List<ObjectHolder> objectHolders)
        {
            _objectHolders = objectHolders;
        }

        public List<Person> LoadPeople()
        {
            foreach (var objectHolder in _objectHolders)
            {
                if (objectHolder is PeopleHolder)
                {
                    _people = (objectHolder as PeopleHolder).GetObjects();
                }
            }
            return _people;
        }
    }
}
