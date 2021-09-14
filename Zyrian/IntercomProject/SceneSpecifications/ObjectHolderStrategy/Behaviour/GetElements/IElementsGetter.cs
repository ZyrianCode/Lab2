﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications.ObjectHolderStrategy.Behaviour.GetElements
{
    public interface IElementsGetter
    {
        public List<IntercomSceneObject> GetObjects();
    }
}
