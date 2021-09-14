using Lab2.Zyrian.IntercomProject.IntercomUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.ReciveElements
{
    public class RecivePeopleMode : IElementsReciver
    {
        private List<Person> _people;

        public RecivePeopleMode(List<Person> people)
        {
            _people = people;
        }
        public void TakeObject(IntercomSceneObject person) => _people.Add((Person)person);

        public void TakeObjects(List<IntercomSceneObject> people) => _people.AddRange((IEnumerable<Person>)people);
    }
}
