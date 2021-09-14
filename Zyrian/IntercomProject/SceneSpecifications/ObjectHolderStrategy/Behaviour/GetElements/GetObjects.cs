using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.GetElements
{
    public class GetObjectsMode : IElementsGetter
    {
        private List<IntercomSceneObject> _objectsList;

        public GetObjectsMode(List<IntercomSceneObject> objectsList)
        {
            _objectsList = objectsList;
        }

        public List<IntercomSceneObject> GetObjects() => _objectsList;
    }
}
