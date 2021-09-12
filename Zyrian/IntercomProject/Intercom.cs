using Lab2.Zyrian.IntercomProject.IntercomComponents;
using Lab2.Zyrian.IntercomProject.KeyManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject
{
    public class Intercom
    {

        private KeySlot _keySlot = new();
        private KeyValidator _keyValidator = new KeyValidator();
        private static readonly string _validKeyCode = "abc-dfe-007";

        public event EventHandler DoorUnlocked;

        public void TakeKey(Key key) => _keySlot.TakeKey(key);

        /// <summary>
        /// Проверяет возможно ли открыть дверь ключом
        /// </summary>
        /// <param name="door"> дверь </param>
        public void IsAbleToDoorOpen(Door door)
        {
            if (_keyValidator.IsValidKey(_keySlot.GetInfoHolder(), _validKeyCode))
            {
                UnlockDoor(door);
            }
            else
            {
                Console.WriteLine("Ключ не подошёл!");
            }
        }

        /// <summary>
        /// Разблокирует дверь
        /// </summary>
        /// <param name="door"> дверь </param>
        private void UnlockDoor(Door door)
        {
            DoorUnlocked?.Invoke(this, new EventArgs());
        }

    }
}
