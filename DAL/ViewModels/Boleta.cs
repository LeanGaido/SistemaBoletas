﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class Boleta
    {
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string Domicilio { get; set; }
        public string CodPostal { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string CantEmpleados { get; set; }
        public string TotalSueldos { get; set; }
        public string Aportes { get; set; }
        public string CantAfiliados { get; set; }
        public string TotalSueldosAfiliados { get; set; }
        public string AportesAfiliados { get; set; }
        public string CantFamiliaresACargo { get; set; }
        public string UnPorcFamiliaresACargo { get; set; }
        public string RecargoPorMora { get; set; }
        public string Total { get; set; }
        public string FechaVencimiento { get; set; }
        public string TotalDepositado { get; set; }
        public string Banco { get; set; }
        public string CodBarra { get; set; }
        public byte[] BarCode { get; set; }
    }
}
