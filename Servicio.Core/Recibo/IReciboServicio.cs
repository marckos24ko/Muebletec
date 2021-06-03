using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Core.Recibo
{
    public interface IReciboServicio
    {
        void Insertar(ReciboDto dto);

        void Modificar(ReciboDto dto);

        void Eliminar(long reciboId);

        void Atrasar(ReciboDto dto);

        IEnumerable<ReciboDto> ObtenerPorFiltro(string cadenaBuscar);

        IEnumerable<ReciboDto> ObtenerPorCredito(long? idCredito, string cadenaBuscar);

        IEnumerable<ReciboDto> ObtenerPorSemana(string cadenaBuscar);

        ReciboDto obtenerPorId(long ClienteId);

        int ObtenerSiguienteCodigo();

        bool VerificarSiExiste(long? id, int codigo);
    }
}
