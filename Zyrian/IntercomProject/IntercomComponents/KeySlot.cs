using Lab2.Zyrian.IntercomProject.KeyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.IntercomComponents
{
    public class KeySlot
    {
        private KeyScanner _keyScanner = new KeyScanner();
        private static KeyInfoHolder _keyInfoHolder = new KeyInfoHolder();

        public void TakeKey(Key key)
        {
            _keyInfoHolder.SaveKeyInfo(_keyScanner.ScanKey(key));
        }

        public KeyInfoHolder GetInfoHolder() => _keyInfoHolder;
    }
}
