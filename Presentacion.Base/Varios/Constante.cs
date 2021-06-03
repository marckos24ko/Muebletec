using System.Drawing;

namespace Presentacion.Base.Varios
{
    public static class Constante
    {

        public static class TipoCredito
        {
            public const string Efecitvo = "Efectivo";
            public const string Mueble = "Mueble";
            public const string Refinanciado = "Refinanciado";
        }

        public static class EstadoCredito
        {
            public const string Pagado = "Pagado";
            public const string PagadoParcial = "Pagado Parcial";
            public const string Impago = "Impago";
        }

        public static class EstadoRecibo
        {
            public const string Pagado = "Pagado";
            public const string PagadoParcial = "Pagado Parcial";
            public const string Impago = "Impago";
            public const string Atrasado = "Atrasado";
        }

        public static class ImagenControl
        {
            public static Image ImagenDeFondo = Recursos.ImagenFondo;
        }
        public static class ColorControl
        {
            public static Color ColorConFoco = Color.Beige;
            public static Color ColorSinFoco = Color.White;
        }

        public static class TipoOperacion
        {
            public const string Nuevo = "Nuevo";
            public const string Eliminar = "Eliminar";
            public const string Modificar = "Modificar";
        }

        public static class Mensaje
        {
            public const string NoHayDatosCargados = "Faltan datos por cargar";
        }
    }
}
