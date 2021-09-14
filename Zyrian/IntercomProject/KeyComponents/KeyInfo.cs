using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.KeyComponents
{
    public class KeyInfo
    {
        private string _keyCode;
        public void SetKeyCode(string keyCode) => _keyCode = keyCode;
        public string GetKeyCode() => _keyCode;
    }
}
