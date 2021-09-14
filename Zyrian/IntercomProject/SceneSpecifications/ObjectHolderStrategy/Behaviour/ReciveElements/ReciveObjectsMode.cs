using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.ReciveElements
{
    public class ReciveObjectsMode : IElementsReciver
    {
        private List<IntercomSceneObject> _objects;

        public ReciveObjectsMode(List<IntercomSceneObject> objects)
        {
            _objects = objects;
        }

        public void TakeObject(IntercomSceneObject obj) => _objects.Add(obj);

        public void TakeObjects(List<IntercomSceneObject> objects) => _objects.AddRange(objects);
    }
}
