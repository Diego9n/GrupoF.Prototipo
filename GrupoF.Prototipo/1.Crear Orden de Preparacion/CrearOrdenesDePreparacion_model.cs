﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoF.Prototipo.Procesar_ordenes_de_preparacion
{
    internal interface ProcesarOrdenesDePreparacion__model
    {

    }

    internal class CrearOrdnesDePreparacion_model
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>
        {
            new Cliente {Id_Cliente = 0, Dni = 0, NombreApellido = "---"},

            new Cliente {Id_Cliente = 1, Dni = 42119134, NombreApellido = "Felipe Diaz", Cuit = 242119134, Domicilio = "Casa 1", CondIva = "Si"},

            new Cliente {Id_Cliente = 2, Dni = 42102237, NombreApellido = "Martin Frias", Cuit = 242102237, Domicilio = "Dpto 2", CondIva = "No"}
        };

        public List<Transportista> Transportistas { get; set; } = new List<Transportista>
        {
            new Transportista {Dni_Transportista = 42119134, NombreApellido_Transportista = "Carlos Lopez"},

            new Transportista {Dni_Transportista = 42102237, NombreApellido_Transportista = "Matias Tallone"}
        };


        public List<Mercaderia> Mercaderias { get; set; } = new List<Mercaderia>
        {
            new Mercaderia {Id_Mercaderia = 0, Descripcion_Mercaderia = "---"},

            new Mercaderia {Id_Mercaderia = 1, Descripcion_Mercaderia = "Manzanas"},

            new Mercaderia {Id_Mercaderia = 2, Descripcion_Mercaderia = "Peras"}
        };

        public List<Deposito> Depositos { get; set; } = new List<Deposito>
        {
            new Deposito { Id_Cliente = 0, Id_Deposito = 0, Nombre_Deposito = "---", Coordenadas_Deposito = "0-0-0"},

            new Deposito { Id_Cliente = 1, Id_Deposito = 1, Nombre_Deposito = "GBAS 1", Coordenadas_Deposito = "15-32-7"},

            new Deposito { Id_Cliente = 2, Id_Deposito = 2, Nombre_Deposito = "GBAS 2", Coordenadas_Deposito = "12-43-2" }
        };


    }
}
