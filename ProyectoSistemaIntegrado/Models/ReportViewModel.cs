﻿namespace ProyectoSistemaIntegrado.Models
{
    public class ReportViewModel
    {
        public int CodigoReporte { get; set; }

        public int CodigoEmpresa { get; set; }
        public int AnioOperacion { get; set; }
        public int SemanaOperacion { get; set; }

        public long CodigoTraslado { get; set; }

        public int CodigoTipoReporte { get; set; }

    }
}