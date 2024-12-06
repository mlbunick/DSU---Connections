using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicaBenner
{
    public class NegativeNumberException : Exception
    {
        private const string DefaultMessage = "Não é permitido nenhum número menor ou igual a 0!";

        public NegativeNumberException()
            : base(DefaultMessage)
        {
        }
    }

}
