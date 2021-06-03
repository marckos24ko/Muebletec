using DAL;
using Presentacion.Base.Varios;
using Servicio.Core.Cliente.Dto;
using Servicio.Core.Credito.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Core.Credito
{
    public class CreditoServicio : ICreditoServicio
    {
        public void Eliminar(long CreditoId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var creditoEliminar = context.Creditos.Find(CreditoId);

                context.Creditos.Remove(creditoEliminar);
                context.SaveChanges();
            }
        }

        public void Insertar(CreditoDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var creditoNuevo = new DAL.Credito();

                creditoNuevo.Monto = dto.Monto;
                creditoNuevo.CodigoCredito = dto.CodigoCredito;
                creditoNuevo.FechaEmision = dto.FechaEmision;
                creditoNuevo.CantidadCuotas = dto.CantidadCuotas;
                creditoNuevo.MontoCuota = dto.MontoCuota;
                creditoNuevo.Estado = dto.Estado;
                creditoNuevo.TotalAbonado = dto.TotalAbonado;
                creditoNuevo.FechaCancelacion = dto.FechaCancelacion;
                creditoNuevo.Interes = dto.Interes;
                creditoNuevo.ClienteId = dto.ClienteId;
                creditoNuevo.TipoCredito = dto.TipoCredito;
                creditoNuevo.Refinanciado = dto.Refinanciado;
                creditoNuevo.Extension = null;
                creditoNuevo.CodigoCreditoBase = dto.codigoCreditoBase;
                
                context.Creditos.Add(creditoNuevo);
                context.SaveChanges();
            }
        }

        public void Modificar(CreditoDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var creditoModificar = context.Creditos.Single(x => x.Id == dto.Id);

                creditoModificar.Monto = dto.Monto;
                creditoModificar.FechaEmision = dto.FechaEmision;
                creditoModificar.CantidadCuotas = dto.CantidadCuotas;
                creditoModificar.MontoCuota = dto.MontoCuota;
                creditoModificar.TotalAbonado = dto.TotalAbonado;
                creditoModificar.FechaCancelacion = dto.FechaCancelacion;
                creditoModificar.Interes = dto.Interes;
                creditoModificar.ClienteId = dto.ClienteId;
                creditoModificar.Estado = dto.Estado;
                creditoModificar.Extension = dto.Extension;
                creditoModificar.Refinanciado = dto.Refinanciado;

                context.SaveChanges();
            }
        }

        public void ModificarPorPagoRecibo(CreditoDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var creditoModificar = context.Creditos.Single(x => x.Id == dto.Id);

                creditoModificar.TotalAbonado = dto.TotalAbonado;
                creditoModificar.Estado = dto.Estado;
                creditoModificar.Interes = dto.Interes;

                context.SaveChanges();
            }
        }

        public CreditoDto obtenerPorCodigo(int codigo)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var credito = context.Creditos
                    .FirstOrDefault(x => x.CodigoCredito == codigo);

                if (credito == null) throw new ArgumentNullException("No existe el Cliente");

                return new CreditoDto()
                {
                    Id = credito.Id,
                    CodigoCredito = credito.CodigoCredito,
                    ApyNomCliente = credito.Cliente.Apellido + " " + credito.Cliente.Nombre,
                    Monto = credito.Monto,
                    FechaEmision = credito.FechaEmision,
                    CantidadCuotas = credito.CantidadCuotas,
                    MontoCuota = credito.MontoCuota,
                    Estado = credito.Estado,
                    TotalAbonado = credito.TotalAbonado,
                    FechaCancelacion = credito.FechaCancelacion,
                    Interes = credito.Interes,
                    TipoCredito = credito.TipoCredito,
                    Refinanciado = credito.Refinanciado,
                    ClienteId = credito.ClienteId

                };
            }
        }

        public IEnumerable<CreditoDto> ObtenerPorFiltro(string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var creditoBuscar = context.Creditos.AsNoTracking()
                    .Where(x => x.TipoCredito != Constante.TipoCredito.Refinanciado && (
                           x.CodigoCredito == codigo
                           || x.Cliente.Apellido.Contains(cadenaBuscar)
                           || x.Cliente.Nombre.Contains(cadenaBuscar))).ToList();

                return creditoBuscar.Select(x => new CreditoDto()
                {
                    Id = x.Id,
                    CodigoCredito = x.CodigoCredito,
                    Monto = x.Monto,
                    FechaEmision= x.FechaEmision,
                    CantidadCuotas = x.CantidadCuotas,
                    MontoCuota = x.MontoCuota,
                    Estado = x.Estado,
                    TotalAbonado = x.TotalAbonado,
                    FechaCancelacion = x.FechaCancelacion,
                    Interes = x.Interes,
                    ClienteId = x.ClienteId,
                    ApyNomCliente = x.Cliente.Apellido + " " + x.Cliente.Nombre,
                    TipoCredito = x.TipoCredito,
                    Refinanciado = x.Refinanciado,
                    Extension = x.Extension
                    
                }).ToList();
            }
        }

        public CreditoDto obtenerPorId(long? creditoId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var credito = context.Creditos
                    .FirstOrDefault(x => x.Id == creditoId);

                if (credito == null) throw new ArgumentNullException("No existe el Cliente");

                return new CreditoDto()
                {
                    Id = credito.Id,
                    CodigoCredito = credito.CodigoCredito,
                    codigoCreditoBase = credito.CodigoCreditoBase,
                    ApyNomCliente = credito.Cliente.Apellido + " " + credito.Cliente.Nombre,
                    Monto = credito.Monto,
                    FechaEmision = credito.FechaEmision,
                    CantidadCuotas = credito.CantidadCuotas,
                    MontoCuota = credito.MontoCuota,
                    Estado = credito.Estado,
                    TotalAbonado = credito.TotalAbonado,
                    FechaCancelacion = credito.FechaCancelacion,
                    Interes = credito.Interes,
                    TipoCredito = credito.TipoCredito,
                    Refinanciado = credito.Refinanciado,
                    Extension = credito.Extension,
                    ClienteId =  credito.ClienteId

                };
            }
        }

        public int ObtenerSiguienteCodigo()
        {
            using (var context = new ModeloFinancieraContainer())
            {

                return context.Creditos
               .Any()
               ? context.Creditos.Max(x => x.CodigoCredito) + 1
               : 1;

            }
        }

        public bool VerificarSiExiste(long? id, int codigoCredito)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                return context.Creditos.Any(x => x.Id != id && x.CodigoCredito == codigoCredito);
            }
        }

       public IEnumerable<CreditoDto> ObtenerPorCliente(long ClienteId, string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var creditoBuscar = context.Creditos.AsNoTracking()
                    .Where(x => x.ClienteId == ClienteId && x.CodigoCreditoBase == null && (x.CodigoCredito == codigo || x.TipoCredito.Contains(cadenaBuscar))).ToList();

                return creditoBuscar.Select(x => new CreditoDto()
                {
                    Id = x.Id,
                    CodigoCredito = x.CodigoCredito,
                    Monto = x.Monto,
                    TotalAbonado = x.TotalAbonado,
                    Estado = x.Estado,
                    FechaCancelacion = x.FechaCancelacion,
                    ClienteId = x.ClienteId

                }).ToList();

            }
        }

        public IEnumerable<CreditoDto> obtenerRefinanciacion(int codigoCreditoBase, long clienteId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var credito = context.Creditos
                    .FirstOrDefault(x => x.CodigoCreditoBase == codigoCreditoBase
                                     && x.ClienteId == clienteId && x.Refinanciado == null
                                     && x.Extension == null);

                var creditoBuscar = context.Creditos.AsNoTracking()
                   .Where(x => x.CodigoCreditoBase == codigoCreditoBase
                                     && x.ClienteId == clienteId && x.Refinanciado == null
                                     && x.Extension == null).ToList();

                return creditoBuscar.Select(x => new CreditoDto()
                {
                    Id = x.Id,
                    CodigoCredito = x.CodigoCredito,
                    Monto = x.Monto,
                    FechaEmision = x.FechaEmision,
                    CantidadCuotas = x.CantidadCuotas,
                    MontoCuota = x.MontoCuota,
                    Estado = x.Estado,
                    TotalAbonado = x.TotalAbonado,
                    FechaCancelacion = x.FechaCancelacion,
                    Interes = x.Interes,
                    ClienteId = x.ClienteId,
                    ApyNomCliente = x.Cliente.Apellido + " " + x.Cliente.Nombre,
                    TipoCredito = x.TipoCredito

                }).ToList();
            }
        }

        public IEnumerable<CreditoDto> ObtenerTodosPorCliente(long ClienteId, string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var creditoBuscar = context.Creditos.AsNoTracking()
                    .Where(x => x.ClienteId == ClienteId && x.TipoCredito != Constante.TipoCredito.Refinanciado && (x.CodigoCredito == codigo || x.TipoCredito.Contains(cadenaBuscar))).ToList();

                return creditoBuscar.Select(x => new CreditoDto()
                {
                    Id = x.Id,
                    CodigoCredito = x.CodigoCredito,
                    Monto = x.Monto,
                    TotalAbonado = x.TotalAbonado,
                    Estado = x.Estado,
                    FechaCancelacion = x.FechaCancelacion,
                    Refinanciado = x.Refinanciado,
                    ClienteId = x.ClienteId

                }).ToList();

            }
        }
    }
}
