using Lab2.Zyrian.IntercomProject.KeyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.IntercomComponents
{
    public class KeyValidator
    {
        public bool IsValidKey(KeyInfoHolder keyInfoHolder, string validKeyCode) => keyInfoHolder.GetKeyInfo() == validKeyCode;
    }
}
