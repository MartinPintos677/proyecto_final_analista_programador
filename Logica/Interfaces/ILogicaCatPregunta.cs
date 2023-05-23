﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;

namespace Logica.Interfaces
{
    public interface ILogicaCatPregunta
    {
        void AltaCategoria(CategoriaPregunta categoria, UsuarioAdmin logueo);
        void CategoriaModificar(CategoriaPregunta categoria, UsuarioAdmin usuario);
        void CategoriaBaja(CategoriaPregunta categoria, UsuarioAdmin usuario);
        CategoriaPregunta BuscarCategoriaActiva(string codigo, UsuarioAdmin usuario);
        List<CategoriaPregunta> ListaCategorias(UsuarioAdmin usuario);
    }
}
