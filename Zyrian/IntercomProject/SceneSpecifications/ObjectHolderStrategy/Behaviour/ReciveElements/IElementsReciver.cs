using Lab2.Zyrian.IntercomProject.IntercomUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.ReciveElements
{
    public interface IElementsReciver
    {
        public void TakeObject(IntercomSceneObject obj);
        public void TakeObjects(List<IntercomSceneObject> objects);
    }
}
