using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.KeyComponents
{
    public class KeyInfoHolder
    {
        private KeyInfo _keyInfo;

        public void SaveKeyInfo(KeyInfo keyInfo)
        {
            _keyInfo = keyInfo;
        }

        public string GetKeyInfo() => _keyInfo.GetKeyCode();
    }
}
