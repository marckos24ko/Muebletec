namespace Servicio.Core.Cliente.Dto
{
    public class ClienteDto
    {

        public long Id { get; set; }

        public int NumeroCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string ApyNom { get { return Apellido + " " + Nombre; } }

        public int Dni { get; set; }

        public string DireccionComercial { get; set; }

        public string DireccionParticular { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }
        
        public bool Estado { get; set; }

        public string EstadoStr
        {
            get
            {
                if (Estado == true)
                {
                    return "Activo";
                }
                else
                {
                    return "Inactivo";
                }
            } 
        }
    }
}
