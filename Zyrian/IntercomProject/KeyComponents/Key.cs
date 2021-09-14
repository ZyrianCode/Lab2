using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.KeyComponents
{
    public class Key
    {
        private KeyInfo _keyInfo = new KeyInfo(); //Хранит keycode

        /// <summary>
        /// Позволяет получить информацию с ключа
        /// </summary>
        /// <returns> keyInfo </returns>
        public KeyInfo GetKeyInfo() => _keyInfo;
    }
}
