using System;
using Lab2.Zyrian.IntercomProject.KeyComponents;

namespace Lab2.Zyrian.IntercomProject.IntercomUsers
{
	public class Bandito : Person
	{
        private Key _key = new Key();

        public override event EventHandler PersonJoined;

        private void PullsOutKey()
        {
            _key.GetKeyInfo().SetKeyCode("abc-vag-785");
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