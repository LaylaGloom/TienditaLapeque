﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace variablesGlobales
{
    static class Globales
    {
        public static string usuario;
        public static string constraseña;
        public static int ap;
        public static string am;
        public static int idrango;
        public static string idproducto;
        public static string precio;
        public static string cantidad;
        public static string idventa;
        public static string fechaventa;
        public static string productoventa;
        public static string producto;
        public static string cp_vendidos;
        public static double totalventa;
        public static string totalventas;
        public static double precioproducto;
        public static double cambio;
        public static string recibido;
        public static string subtotal;
        public static int auxiliarid;
        public static int tamañoInicial;
        public static int ContIndexInicial;
        public static decimal restante, deudaT, abono;
        public static string updateQuery, deleteQuery;
        public static bool EP_pagado=false;
    }
}
