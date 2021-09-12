using Lab2.Zyrian.IntercomProject.IntercomUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications
{
    [Serializable]
    public class ObjectHolder
    {
        public List<Person> people = new List<Person>();

        public void TakeObjects(object obj) => people.Add(obj as Person);
        public void RemoveObjects(object obj) => people.Remove(obj as Person);
    }
}
