using Servicio.Core.Cliente.Dto;
using System.Collections.Generic;

namespace Servicio.Core.Cliente
{
    public interface IClienteServicio
    {

        void Insertar(ClienteDto dto);

        void Modificar(ClienteDto dto);

        void Eliminar(long ClienteId);

        IEnumerable<ClienteDto> ObtenerPorFiltro(string cadenaBuscar);

        IEnumerable<ClienteDto> ObtenerClientesActivos(string cadenaBuscar);

        ClienteDto obtenerPorId(long ClienteId);

        int ObtenerSiguienteCodigo();

        bool VerificarSiExiste(long? id, string Apellido, string Nombre, int Dni);

        int VerificarCantidadClientes();



    }
}
