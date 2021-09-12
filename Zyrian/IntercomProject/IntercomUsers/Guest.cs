using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.IntercomUsers
{
    public class Guest : Person
    {
        public override event EventHandler PersonJoined;

        public override void TryOpenDoor()
        {
            PersonJoined?.Invoke(this, new EventArgs());
            Console.WriteLine("Звонит в домофон...");
        }
    }
}
