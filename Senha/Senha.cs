using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Senha
    {
        public int Num { get; set; }
        public Senha Next { get; set; }

        public Senha(int num)
        {
            Num = num;
        }
    }
}
