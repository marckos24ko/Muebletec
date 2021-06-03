using Servicio.Core.Credito.Dto;
using System.Collections.Generic;

namespace Servicio.Core.Credito
{
    public interface ICreditoServicio
    {
        void Insertar(CreditoDto dto);

        void Modificar(CreditoDto dto);

        void ModificarPorPagoRecibo(CreditoDto dto);

        void Eliminar(long CreditoId);

        IEnumerable<CreditoDto> ObtenerPorFiltro(string cadenaBuscar);

        CreditoDto obtenerPorId(long? CreditoId);

        CreditoDto obtenerPorCodigo(int codigo);

        IEnumerable<CreditoDto> ObtenerPorCliente(long ClienteId, string cadenaBuscar);

        IEnumerable<CreditoDto> ObtenerTodosPorCliente(long ClienteId, string cadenaBuscar);

        IEnumerable<CreditoDto> obtenerRefinanciacion(int codigoCreditoBase, long clienteId);

        int ObtenerSiguienteCodigo();

        bool VerificarSiExiste(long? id, int codigoCredito);
    }
}
