using DAL;
using Servicio.Core.Cliente.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicio.Core.Cliente
{
    public class ClienteServicio : IClienteServicio
    {
        public void Eliminar(long ClienteId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var clienteEliminar = context.Clientes.Find(ClienteId);

                context.Clientes.Remove(clienteEliminar);
                context.SaveChanges();
            }
        }

        public void Insertar(ClienteDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var ClienteNuevo = new DAL.Cliente();

                ClienteNuevo.NumeroCliente = dto.NumeroCliente;
                ClienteNuevo.Nombre = dto.Nombre;
                ClienteNuevo.Apellido = dto.Apellido;
                ClienteNuevo.Dni = dto.Dni;
                ClienteNuevo.Telefono = dto.Telefono;
                ClienteNuevo.Celular = dto.Celular;
                ClienteNuevo.DireccionComercial = dto.DireccionComercial;
                ClienteNuevo.DireccionParticular = dto.DireccionParticular;
                ClienteNuevo.Estado = true;

                context.Clientes.Add(ClienteNuevo);
                context.SaveChanges();

            }


        }

        public void Modificar(ClienteDto dto)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var clienteModificar = context.Clientes.Single(x => x.Id == dto.Id);

                clienteModificar.Nombre = dto.Nombre;
                clienteModificar.Apellido = dto.Apellido;
                clienteModificar.Dni = dto.Dni;
                clienteModificar.DireccionComercial = dto.DireccionComercial;
                clienteModificar.DireccionParticular = dto.DireccionParticular;
                clienteModificar.Telefono = dto.Telefono;
                clienteModificar.Celular = dto.Celular;
                clienteModificar.Estado = dto.Estado;

                context.SaveChanges();
            }
        }

        public IEnumerable<ClienteDto> ObtenerClientesActivos(string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var clienteBuscar = context.Clientes.AsNoTracking()
                    .Where(x => x.Estado == true &&  (x.Nombre.Contains(cadenaBuscar)
                             || x.Apellido.Contains(cadenaBuscar)
                             || x.Dni == codigo
                             || x.NumeroCliente == codigo)).ToList();

                return clienteBuscar.Select(x => new ClienteDto()
                {
                    Id = x.Id,
                    NumeroCliente = x.NumeroCliente,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Dni = x.Dni,
                    Estado = x.Estado
                }).ToList();
            }
        }

        public IEnumerable<ClienteDto> ObtenerPorFiltro(string cadenaBuscar)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var codigo = -1;
                int.TryParse(cadenaBuscar, out codigo);

                var clienteBuscar = context.Clientes.AsNoTracking()
                    .Where(x => x.Nombre.Contains(cadenaBuscar)
                             || x.Apellido.Contains(cadenaBuscar)
                             || x.Dni == codigo
                             || x.NumeroCliente == codigo).ToList();

                return clienteBuscar.Select(x => new ClienteDto()
                {
                    Id = x.Id,
                    NumeroCliente = x.NumeroCliente,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Dni = x.Dni,
                    Telefono = x.Telefono,
                    Celular = x.Celular,
                    DireccionComercial = x.DireccionComercial,
                    DireccionParticular = x.DireccionParticular,
                    Estado = x.Estado

                }).ToList();
            }
        }

        public ClienteDto obtenerPorId(long ClienteId)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                var cliente = context.Clientes
                    .FirstOrDefault(x => x.Id == ClienteId);

                if (cliente == null) throw new ArgumentNullException("No existe el Cliente");

                return new ClienteDto()
                {
                    Id = cliente.Id,
                    NumeroCliente = cliente.NumeroCliente,
                    Apellido = cliente.Apellido,
                    Dni = cliente.Dni,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Celular = cliente.Celular,
                    DireccionComercial = cliente.DireccionComercial,
                    DireccionParticular = cliente.DireccionParticular

                };
            }
        }

        public int ObtenerSiguienteCodigo()
        {
            using (var context = new ModeloFinancieraContainer())
            {

                return context.Clientes
               .Any()
               ? context.Clientes.Max(x => x.NumeroCliente) + 1
               : 1;

            }
        }

        public int VerificarCantidadClientes()
        {
           using (var context = new ModeloFinancieraContainer())
            {
                return context.Clientes.Count();
            }
        }

        public bool VerificarSiExiste(long? id, string Apellido, string Nombre, int Dni)
        {
            using (var context = new ModeloFinancieraContainer())
            {
                return context.Clientes.Any(x => x.Id != id &&
                (x.Apellido == Apellido && x.Nombre == Nombre &&
                 x.Dni == Dni));
            }    
        }
    }
}
