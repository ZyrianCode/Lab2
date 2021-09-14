using Lab2.Zyrian.IntercomProject.IntercomUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.Other
{
    public class PeopleClearMode : IElementsRemover
    {
        private List<Person> _people;

        public PeopleClearMode(List<Person> people)
        {
            _people = people;
        }

        public void ClearObjects() => _people.Clear();
    }
}
