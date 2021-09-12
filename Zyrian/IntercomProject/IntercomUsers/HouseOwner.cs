using Lab2.Zyrian.IntercomProject.KeyManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.IntercomUsers
{
    public class HouseOwner : Person
    {
        private Key _key = new Key();

        public override event EventHandler PersonJoined;

        private void PullsOutKey() {
            _key.GetKeyInfo().SetKeyCode("abc-dfe-007");
        }

        public Key PutKeyOnIntercom() => _key;


        public override void TryOpenDoor()
        {
            Console.WriteLine("Открывает дверь ключом");
            PullsOutKey();
            PersonJoined?.Invoke(this, new EventArgs());
        }
    }
}
