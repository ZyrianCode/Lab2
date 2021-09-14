using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.Other
{
    public class AllClearMode : IElementsRemover
    {
        List<IntercomSceneObject> _objectsList;

        public AllClearMode(List<IntercomSceneObject> objectsList)
        {
            _objectsList = objectsList;
        }

        public void ClearObjects() => _objectsList.Clear();
    }
}
