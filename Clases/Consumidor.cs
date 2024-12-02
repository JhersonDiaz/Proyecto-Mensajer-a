﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proycto_Mensajeria.Clases
{
    public class Consumidor
    {
        private Cola<Usuario> _cola;

        public Consumidor(Cola<Usuario> cola)//Constructor
        {

            _cola = cola;
        }

        public Usuario Consumir()
        {
            Usuario usuario = _cola.Extraer();
            Thread.Sleep(5000);
            return usuario;
        }
    }
}
