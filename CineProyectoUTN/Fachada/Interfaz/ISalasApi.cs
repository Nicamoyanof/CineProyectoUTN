﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineProyectoUTN.Dominios;

namespace CineProyectoUTN.Fachada.Interfaz
{
    internal interface ISalasApi
    {
        public List<TipoSala> CargarTipoSalas();

        public Salas CargarSalaPorId(int id);

    }
}
