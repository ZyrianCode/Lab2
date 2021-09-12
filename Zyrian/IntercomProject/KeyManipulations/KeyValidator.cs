using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.KeyManipulations
{
    public class KeyValidator
    {
        public bool IsValidKey(KeyInfoHolder keyInfoHolder, string validKeyCode) => keyInfoHolder.GetKeyInfo() == validKeyCode;
    }
}
