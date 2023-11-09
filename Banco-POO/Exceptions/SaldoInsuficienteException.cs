﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_POO.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) :base(mensagem)
        {
                
        }
    }
}
