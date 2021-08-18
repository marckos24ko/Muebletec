using System;

namespace Servicio.Core.Recibo.Dto
{
    public class ReciboDto
    {

        public long Id { get; set; }

        public int Numero { get; set; }

        public decimal MontoCredito { get; set; }

        public int NumeroCuota { get; set; }

        public int CuotasPendiente { get; set; }

        public decimal MontoCuota { get; set; }

        public decimal Saldo { get; set; }

        public string UltimoPago { get; set; }

        public decimal Atraso { get; set; }

        public decimal Pagado { get; set; }

        public DateTime FechaPago { get; set; }

        public decimal Pago { get; set; }

        public decimal? Interes { get; set; }

        public string Estado { get; set; }

        public long CreditoId { get; set; }

        public long ClienteId { get; set; }

        public string ApyNomCliente { get; set; }

        public int CodigoCredito { get; set; }

    }
}
