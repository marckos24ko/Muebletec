using DAL;
using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Servicio.Core.Recibo
{
    public class ReciboServicio : IReciboServicio
    {
        public void Atrasar(ReciboDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var reciboModificar = context.Recibos.Single(x => x.Id == dto.Id);

                reciboModificar.Pagado = dto.Pagado - reciboModificar.Pago;
                reciboModificar.Pago = 0m;
                reciboModificar.Atraso = dto.MontoCuota;
                reciboModificar.Estado = dto.Estado;
                reciboModificar.Saldo = dto.Saldo;

                context.SaveChanges();
            }
        }

        public void Eliminar(long reciboId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var reciboEliminar = context.Recibos.Find(reciboId);

                context.Recibos.Remove(reciboEliminar);
                context.SaveChanges();
            }
        }

        public void Insertar(ReciboDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var reciboNuevo = new DAL.Recibo();

                reciboNuevo.Numero = dto.Numero;
                reciboNuevo.MontoCredito = dto.MontoCredito;
                reciboNuevo.NumeroCuota = dto.NumeroCuota;
                reciboNuevo.CuotasPendiente = dto.CuotasPendiente;
                reciboNuevo.MontoCuota = dto.MontoCuota;
                reciboNuevo.Saldo = dto.Saldo;
                reciboNuevo.UltimoPago = dto.UltimoPago;
                reciboNuevo.Atraso = dto.Atraso;
                reciboNuevo.Pagado = dto.Pagado;
                reciboNuevo.FechaPago = dto.FechaPago;
                reciboNuevo.Pago = dto.Pago;
                reciboNuevo.CreditoId = dto.CreditoId;
                reciboNuevo.ClienteId = dto.ClienteId;
                reciboNuevo.Estado = dto.Estado;


                context.Recibos.Add(reciboNuevo);
                context.SaveChanges();
            }
        }

        public void Modificar(ReciboDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var reciboModificar = context.Recibos.Single(x => x.Id == dto.Id);

                reciboModificar.Pago = dto.Pago;
                reciboModificar.Pagado = dto.Pagado;
                reciboModificar.FechaPago = dto.FechaPago;
                reciboModificar.Atraso = dto.Atraso;
                reciboModificar.Saldo = dto.Saldo;
                reciboModificar.UltimoPago = dto.UltimoPago;
                reciboModificar.Estado = dto.Estado;

                context.SaveChanges();
            }
        }

        public IEnumerable<ReciboDto> ObtenerPorCredito(long? idCredito, string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var reciboBuscar = context.Recibos.AsNoTracking()
                    .Where(x => x.CreditoId == idCredito && (x.NumeroCuota == codigo
                           || x.Cliente.Apellido.Contains(cadenaBuscar)
                           || x.Cliente.Nombre.Contains(cadenaBuscar)));
                          

                return reciboBuscar.Select(x => new ReciboDto()
                {
                    Id = x.Id,
                    Numero = x.Numero,
                    MontoCredito = x.MontoCredito,
                    NumeroCuota = x.NumeroCuota,
                    CuotasPendiente = x.CuotasPendiente,
                    MontoCuota = x.MontoCuota,
                    Saldo = x.Saldo,
                    UltimoPago = x.UltimoPago,
                    Atraso = x.Atraso,
                    Pagado = x.Pagado,
                    FechaPago = x.FechaPago,
                    Pago = x.Pago,
                    ApyNomCliente = x.Cliente.Apellido + " " + x.Cliente.Nombre,
                    ClienteId = x.ClienteId,
                    CreditoId = x.CreditoId,
                    Estado = x.Estado


                }).ToList();
            }
        }

        public IEnumerable<ReciboDto> ObtenerPorFiltro(string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var reciboBuscar = context.Recibos.AsNoTracking()
                    .Where(x => x.Numero == codigo
                           || x.Cliente.Apellido.Contains(cadenaBuscar)
                           || x.Cliente.Nombre.Contains(cadenaBuscar)).ToList();

                return reciboBuscar.Select(x => new ReciboDto()
                {
                    Id = x.Id,
                    Numero = x.Numero,
                    MontoCredito = x.MontoCredito,
                    NumeroCuota = x.NumeroCuota,
                    CuotasPendiente = x.CuotasPendiente,
                    MontoCuota = x.MontoCuota,
                    Saldo = x.Saldo,
                    UltimoPago = x.UltimoPago,
                    Atraso = x.Atraso,
                    Pagado = x.Pagado,
                    FechaPago = x.FechaPago,
                    Pago = x.Pago,
                    ApyNomCliente = x.Cliente.Apellido + " " + x.Cliente.Nombre,
                    ClienteId = x.ClienteId,
                    CreditoId = x.CreditoId,
                    Estado = x.Estado


                }).ToList();
            }
        }

        public ReciboDto obtenerPorId(long reciboId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var recibo = context.Recibos
                    .FirstOrDefault(x => x.Id == reciboId);

                if (recibo == null) throw new ArgumentNullException("No existe el Cliente");

                return new ReciboDto()
                {
                    Id = recibo.Id,
                    Numero = recibo.Numero,
                    MontoCredito = recibo.MontoCredito,
                    NumeroCuota = recibo.NumeroCuota,
                    CuotasPendiente = recibo.CuotasPendiente,
                    MontoCuota = recibo.MontoCuota,
                    Saldo = recibo.Saldo,
                    UltimoPago = recibo.UltimoPago,
                    Atraso = recibo.Atraso,
                    Pagado = recibo.Pagado,
                    FechaPago = recibo.FechaPago,
                    Pago = recibo.Pago,
                    ApyNomCliente = recibo.Cliente.Apellido + " " + recibo.Cliente.Nombre,
                    ClienteId = recibo.ClienteId,
                    CreditoId = recibo.CreditoId,
                    Estado = recibo.Estado

                };
            }
        }

        public IEnumerable<ReciboDto> ObtenerPorSemana(string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                CultureInfo myCI = new CultureInfo("es-AR");
                Calendar myCal = myCI.Calendar;

                CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

                var numeroSemanaActual = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);

                var lista = context.Recibos.AsNoTracking();
                var listaRecibosSemanaActual = new List<DAL.Recibo>();

                foreach (var item in lista)
                {
                    var numeroSemanaRecibo = myCal.GetWeekOfYear(item.FechaPago.Date, myCWR, myFirstDOW);

                    if (numeroSemanaActual == numeroSemanaRecibo)
                    {
                        listaRecibosSemanaActual.Add(item);
                    }
                }


                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var reciboBuscar = listaRecibosSemanaActual
                    .Where(x => x.Numero == codigo
                           || x.Cliente.Apellido.Contains(cadenaBuscar)
                           || x.Cliente.Nombre.Contains(cadenaBuscar)).ToList();

                return reciboBuscar.Select(x => new ReciboDto()
                {
                    Id = x.Id,
                    Numero = x.Numero,
                    MontoCredito = x.MontoCredito,
                    NumeroCuota = x.NumeroCuota,
                    CuotasPendiente = x.CuotasPendiente,
                    MontoCuota = x.MontoCuota,
                    Saldo = x.Saldo,
                    UltimoPago = x.UltimoPago,
                    Atraso = x.Atraso,
                    Pagado = x.Pagado,
                    FechaPago = x.FechaPago,
                    Pago = x.Pago,
                    ApyNomCliente = x.Cliente.Apellido + " " + x.Cliente.Nombre,
                    ClienteId = x.ClienteId,
                    CreditoId = x.CreditoId,
                    Estado = x.Estado


                }).ToList();
            }
        }

        public int ObtenerSiguienteCodigo()
        {
            using (var context = new ModeloFinancieraContainer())
            {

                return context.Recibos
               .Any()
               ? context.Recibos.Max(x => x.Numero) + 1
               : 1;

            }
        }

        public bool VerificarSiExiste(long? id, int numero)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                return context.Recibos.Any(x => x.Id != id && x.Numero == numero);
            }
        }
    }
}
