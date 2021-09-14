using Lab2.Zyrian.IntercomProject.KeyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.IntercomComponents
{
    public class KeyScanner
    {
        public KeyInfo ScanKey(Key key) => key.GetKeyInfo();
    }
}
