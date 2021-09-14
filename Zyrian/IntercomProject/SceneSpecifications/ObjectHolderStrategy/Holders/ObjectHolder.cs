using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.GetElements;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.ReciveElements;
using Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Holders
{
    [Serializable]
    public abstract class ObjectHolder
    {
        protected IElementsReciver reciveBehaviour;
        protected IElementsGetter getElementsBehaviour;
        protected IElementsRemover removeElementsBehaviour;

        private List<IntercomSceneObject> _objectList = default;
        
        public ObjectHolder()
        {
            reciveBehaviour = new ReciveObjectsMode(_objectList);
            getElementsBehaviour = new GetObjectsMode(_objectList);
            removeElementsBehaviour = new AllClearMode(_objectList);
        }

        public void SetReciveBehaviour(IElementsReciver newReciveBehaviour) => reciveBehaviour = newReciveBehaviour;
        public void SetGetElementsBehaviour(IElementsGetter newGetElementsBehaviour) => getElementsBehaviour = newGetElementsBehaviour;
        public void SetRemovalElementsBehaviour(IElementsRemover newRemovalElementsBehaviour) => removeElementsBehaviour = newRemovalElementsBehaviour;


        public void TakeObject(IntercomSceneObject obj) => reciveBehaviour.TakeObject(obj);
        public void TakeObjects(List<IntercomSceneObject> objects) => reciveBehaviour.TakeObjects(objects);
        public List<IntercomSceneObject> GetObjects() => getElementsBehaviour.GetObjects();
        public void ClearObjects() => removeElementsBehaviour.ClearObjects();
    }
}
