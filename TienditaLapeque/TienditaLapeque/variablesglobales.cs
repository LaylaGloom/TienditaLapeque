﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace variablesGlobales
{
    static class Globales
    {
        public static string usuario;
        public static Document document;
        public static string constraseña;
        public static int ap;
        public static string am;
        public static int idrango;
        public static string idproducto;
        public static string precio;
        public static string cantidad;
        public static int idventa;
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
        public static string updateQuery, deleteQuery, selectQuery;
        public static bool EP_pagado=false;
        public static int ventana;
        public static string fecha_ini, fecha_fin;
        public static decimal tventa;
        public static int tp_venta;
    }
}
