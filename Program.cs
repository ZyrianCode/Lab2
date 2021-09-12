using Lab2.Zyrian;
using Lab2.Zyrian.IntercomProject;
using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scene> scenes = new List<Scene>()
            {
                new IntercomScene()
            };
            
            foreach (var scene in scenes)
            {
                scene.Start();
            }
        }
    }
}
