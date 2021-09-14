using Lab2.Zyrian.IntercomProject.SceneSpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.IntercomUsers
{
    public abstract class Person : IntercomSceneObject
    {
        public abstract event EventHandler PersonJoined;
        public abstract void TryOpenDoor();
    }
}
