using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.GetElements;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.Other;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.ReciveElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Holders
{
    [Serializable]
    public class PeopleHolder : ObjectHolder
    {
        private List<Person> _people = new();

        public PeopleHolder()
        {
            reciveBehaviour = new RecivePeopleMode(_people);
            getElementsBehaviour = new GetPeopleMode(_people);
            removeElementsBehaviour = new PeopleClearMode(_people);
        }

        new public List<Person> GetObjects() => getElementsBehaviour.GetObjects().Cast<Person>().ToList();        
    }
}
