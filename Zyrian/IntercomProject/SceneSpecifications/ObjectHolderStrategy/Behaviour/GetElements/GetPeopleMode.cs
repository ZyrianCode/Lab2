using Lab2.Zyrian.IntercomProject.IntercomUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.GetElements
{
    public class GetPeopleMode : IElementsGetter
    {
        private List<Person> _people;

        public GetPeopleMode(List<Person> people)
        {
            _people = people;
        }

        public List<IntercomSceneObject> GetObjects() => _people.Cast<IntercomSceneObject>().ToList();
    }
}
