using System;

namespace Servicio.Core.Credito.Dto
{
    public class CreditoDto
    {

        public long Id { get; set; }

        public int CodigoCredito { get; set; }

        public string TipoCredito { get; set; }

        public decimal Monto { get; set; }

        public DateTime FechaEmision { get; set; }

        public int CantidadCuotas { get; set; }

        public decimal MontoCuota { get; set; }

        public string Estado { get; set; }

        public decimal TotalAbonado { get; set; }

        public long ClienteId { get; set; }

        public DateTime FechaCancelacion { get; set; }

        public int? Interes { get; set; }

        public string ApyNomCliente { get; set; }

        public bool? Refinanciado { get; set; }

        public string RefinanciadoStr { get { return Refinanciado is true ? "SI" : "NO"; } }

        public bool? Extension { get; set; }

        public int? codigoCreditoBase  { get; set; }

    }
}
