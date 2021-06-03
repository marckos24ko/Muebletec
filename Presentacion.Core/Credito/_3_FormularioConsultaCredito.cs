using FontAwesome.Sharp;
using Presentacion.Base;
using Presentacion.Base.Varios;
using Presentacion.Core.Recibos;
using Servicio.Core.Credito;
using Servicio.Core.Credito.Dto;
using Servicio.Core.Recibo;
using Servicio.Core.Recibo.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Core.Credito
{
    public partial class _3_FormularioConsultaCredito : FormularioEnPanelBase
    {
        private readonly ICreditoServicio _creditoServicio;
        private readonly IReciboServicio _reciboServicio;
        private CreditoDto _credito;
        private CreditoDto _creditoRefinanciado;
        private List<ReciboDto> _lista;
        private bool _puedeEliminar;
        private List<CreditoDto> _listaCredito;
        private string _mensaje = "";

        public _3_FormularioConsultaCredito()
            : this(new CreditoServicio())
        {

        }

        public _3_FormularioConsultaCredito(ICreditoServicio creditoServicio)
        {
            InitializeComponent();

            Titulo = @"Lista de Creditos";
            btnEstadoCuenta.Visible = true;
            btnEstadoCuenta.Text = "Recibos";
            btnEstadoCuenta.IconChar = IconChar.Receipt;

            _creditoServicio = new CreditoServicio();
            _reciboServicio = new ReciboServicio();

            ActualizarDatos(string.Empty);

        }

        public override void ActualizarDatos(string cadenaBuscar)
        {
            dgvGrilla.DataSource = _creditoServicio.ObtenerPorFiltro(cadenaBuscar);
            FormatearGrilla(dgvGrilla);
        }

        public override void FormatearGrilla(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["ClienteId"].Visible = false;
            dgvGrilla.Columns["Extension"].Visible = false;
            dgvGrilla.Columns["Refinanciado"].Visible = false;
            dgvGrilla.Columns["CodigoCreditoBase"].Visible = false;

            dgvGrilla.Columns["CodigoCredito"].Visible = true;
            dgvGrilla.Columns["CodigoCredito"].Width = 50;
            dgvGrilla.Columns["CodigoCredito"].HeaderText = @"Código";
            dgvGrilla.Columns["CodigoCredito"].DisplayIndex = 0;

            dgvGrilla.Columns["Monto"].Visible = true;
            dgvGrilla.Columns["Monto"].Width = 100;
            dgvGrilla.Columns["Monto"].HeaderText = @"Monto";
            dgvGrilla.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Monto"].DisplayIndex = 1;

            dgvGrilla.Columns["FechaEmision"].Visible = true;
            dgvGrilla.Columns["FechaEmision"].Width = 100;
            dgvGrilla.Columns["FechaEmision"].HeaderText = @"Emision";
            dgvGrilla.Columns["FechaEmision"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaEmision"].DisplayIndex = 2;

            dgvGrilla.Columns["CantidadCuotas"].Visible = true;
            dgvGrilla.Columns["CantidadCuotas"].Width = 100;
            dgvGrilla.Columns["CantidadCuotas"].HeaderText = @"Cuotas";
            dgvGrilla.Columns["CantidadCuotas"].DisplayIndex = 3;

            dgvGrilla.Columns["MontoCuota"].Visible = true;
            dgvGrilla.Columns["MontoCuota"].Width = 100;
            dgvGrilla.Columns["MontoCuota"].HeaderText = @"Valor Cuota";
            dgvGrilla.Columns["MontoCuota"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["MontoCuota"].DisplayIndex = 4;

            dgvGrilla.Columns["TotalAbonado"].Visible = true;
            dgvGrilla.Columns["TotalAbonado"].Width = 100;
            dgvGrilla.Columns["TotalAbonado"].HeaderText = @"Total Abonado";
            dgvGrilla.Columns["TotalAbonado"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["TotalAbonado"].DisplayIndex = 5;

            dgvGrilla.Columns["FechaCancelacion"].Visible = true;
            dgvGrilla.Columns["FechaCancelacion"].Width = 100;
            dgvGrilla.Columns["FechaCancelacion"].HeaderText = @"Cancelacion";
            dgvGrilla.Columns["FechaCancelacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaCancelacion"].DisplayIndex = 6;

            dgvGrilla.Columns["Estado"].Visible = true;
            dgvGrilla.Columns["Estado"].Width = 100;
            dgvGrilla.Columns["Estado"].HeaderText = @"Estado";
            dgvGrilla.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["Estado"].DisplayIndex = 7;

            dgvGrilla.Columns["ApyNomCliente"].Visible = true;
            dgvGrilla.Columns["ApyNomCliente"].Width = 100;
            dgvGrilla.Columns["ApyNomCliente"].HeaderText = @"Cliente";
            dgvGrilla.Columns["ApyNomCliente"].DisplayIndex = 8;

            dgvGrilla.Columns["TipoCredito"].Visible = true;
            dgvGrilla.Columns["TipoCredito"].Width = 100;
            dgvGrilla.Columns["TipoCredito"].HeaderText = @"Tipo";
            dgvGrilla.Columns["TipoCredito"].DisplayIndex = 9;

            dgvGrilla.Columns["Interes"].Visible = true;
            dgvGrilla.Columns["Interes"].Width = 100;
            dgvGrilla.Columns["Interes"].HeaderText = @"Interes";
            dgvGrilla.Columns["Interes"].DisplayIndex = 10;

            dgvGrilla.Columns["RefinanciadoStr"].Visible = true;
            dgvGrilla.Columns["RefinanciadoStr"].Width = 100;
            dgvGrilla.Columns["RefinanciadoStr"].HeaderText = @"Refinanciado";
            dgvGrilla.Columns["RefinanciadoStr"].DisplayIndex = 11;
        }

        public override bool EjecutarComandoNuevo()
        {
            var formularioElegirOpcion = new _6_FormularioCreditoTipoTransaccion();
            formularioElegirOpcion.ShowDialog();

            if (formularioElegirOpcion.realizoAlgunaOperacion)
            {
                VerificarFechaCancelacionCredito();
            }

            return formularioElegirOpcion.realizoAlgunaOperacion;
        }

        public override bool EjecutarComandoModificar()
        {

            _lista = _reciboServicio.ObtenerPorCredito(_credito.Id, string.Empty).ToList();

            if (_credito.Refinanciado == true)
            {
                Mensaje.Mostrar("No se puede Modificar el Credito porque ya fue Refinanciado ", Mensaje.Tipo.Advertencia);

                return false;
            }

            if (_credito.Estado == Constante.EstadoCredito.PagadoParcial || _credito.Estado == Constante.EstadoCredito.Impago)
            {
                foreach (var item in _lista)
                {
                    if (item.Atraso > 0 || item.Pagado > 0)
                    {
                        Mensaje.Mostrar("No se puede Modificar el Credito porque ya fue abonado en parte o tiene uno o mas Recibos Atrasados."
                                        , Mensaje.Tipo.Advertencia);

                        return false;
                    }
                }

                if (_credito.FechaCancelacion < DateTime.Now)
                {
                    Mensaje.Mostrar("No se puede Modificar el Credito porque ya Vencio su Fecha de Cancelacion "
                        + _credito.FechaCancelacion.ToShortDateString(), Mensaje.Tipo.Advertencia) ;

                    return false;
                }

            }

            var formularioModificar = new _4_FormularioCreditoABM(Constante.TipoOperacion.Modificar, _credito.TipoCredito, EntidadId);
            formularioModificar.ShowDialog();

            return formularioModificar.RealizoAlgunaOperacion;
        }

        public override bool EjecutarComandoEliminar()
        {

            _lista = _reciboServicio.ObtenerPorCredito(_credito.Id, string.Empty).ToList();

            foreach (var item in _lista)
            {
                _puedeEliminar = true;

                if  (item.Pago > 0m || item.Atraso > 0)
                {
                    _puedeEliminar = false;

                    break;
                }
            }

            if (_credito.Refinanciado == true)
            {
               if( Mensaje.Mostrar("Este Credito ya ha sido Refinanciado, Si lo Elimina se Borrara Todo Registro de el Credito y su Refinanciacion. \n" +
                                " Seguro desea Eliminarlo?", Mensaje.Tipo.Pregunta) == DialogResult.Yes)
                {
                    var formularioEliminar = new _4_FormularioCreditoABM(Constante.TipoOperacion.Eliminar, _credito.TipoCredito, EntidadId);
                    formularioEliminar.ShowDialog();

                    return formularioEliminar.RealizoAlgunaOperacion;
                }
                else
                {
                    return false;
                }

                
            }

            if (_puedeEliminar == false)
            {
                if (Mensaje.Mostrar("Este Credito ya ha sido abonado en parte o en su totalidad. Si lo borra se perderan sus registros, Desea Eliminarlo?", Mensaje.Tipo.Pregunta) == DialogResult.Yes)
                {
                    var formularioEliminar = new _4_FormularioCreditoABM(Constante.TipoOperacion.Eliminar, _credito.TipoCredito, EntidadId);
                    formularioEliminar.ShowDialog();

                    return formularioEliminar.RealizoAlgunaOperacion;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                var formularioEliminar = new _4_FormularioCreditoABM(Constante.TipoOperacion.Eliminar, _credito.TipoCredito, EntidadId);
                formularioEliminar.ShowDialog();

                return formularioEliminar.RealizoAlgunaOperacion;
            }
        }

        public override bool EjecutarComandoExtra()
        {

            var formularioReciboCredito = new _7_FormularioConsultaRecibosCredito(_credito);
            formularioReciboCredito.ShowDialog();

            return formularioReciboCredito.RealizoAlgunaOperacion;
        }

        public override void VerificarFechaCancelacionCredito()
        {
            _listaCredito = _creditoServicio.ObtenerPorFiltro(string.Empty).ToList();


            foreach (var item in _listaCredito)
            {

                if (DateTime.Now > item.FechaCancelacion && item.Extension == null && item.TotalAbonado < item.Monto) // si el credito se pago completamente no se extiende
                {
                    var credito = _creditoServicio.obtenerPorId(item.Id);

                    credito.FechaCancelacion = item.FechaCancelacion.AddDays(7);
                    credito.Extension = true;

                    _creditoServicio.Modificar(credito);
                }

            }
        }

        public override bool EjecutarComandoRefinanciar()
        {
            _mensaje = "El Credito N° " + _credito.CodigoCredito + " Perteneciente al Cliente: "
                     + _credito.ApyNomCliente.ToUpper() + " Vencio el: "
                     + _credito.FechaCancelacion.AddDays(-7).ToShortDateString() + " y su Extension" +
                     " Vencio el " + _credito.FechaCancelacion.ToShortDateString() + ". \n" +
                     "Desea Refinanciar El Credito?";

            if (_credito.FechaCancelacion < DateTime.Now
                && _credito.Extension == true && _credito.Refinanciado != true)
            {
                if (Mensaje.Mostrar(_mensaje, Mensaje.Tipo.Pregunta) == DialogResult.Yes)
                {

                    var formulario = new _12_FormularioRefinanciacionCredito(_credito, Constante.TipoOperacion.Nuevo,
                                                                             Constante.TipoCredito.Refinanciado, null);
                    formulario.ShowDialog();

                    if (formulario.realizoAlgunaOperacion)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public override bool EjecutarComandoReciboRefinanciar()
        {
            var formularioReciboCredito = new _7_FormularioConsultaRecibosCredito(_creditoRefinanciado);
            formularioReciboCredito.ShowDialog();

            return formularioReciboCredito.RealizoAlgunaOperacion;
        }

        private void MostrarRefinanciacion()
        {

          dgvGrillaRefinanciacion.DataSource = _creditoServicio.obtenerRefinanciacion(_credito.CodigoCredito, _credito.ClienteId).ToList();

          FormatearGrillaRefinanciados(dgvGrillaRefinanciacion);
        }

        private void FormatearGrillaRefinanciados(DataGridView dgvGrilla)
        {
            dgvGrilla.Columns["Id"].Visible = false;
            dgvGrilla.Columns["ClienteId"].Visible = false;
            dgvGrilla.Columns["Extension"].Visible = false;
            dgvGrilla.Columns["Refinanciado"].Visible = false;
            dgvGrilla.Columns["CodigoCreditoBase"].Visible = false;
            dgvGrilla.Columns["ApyNomCliente"].Visible = false;
            dgvGrilla.Columns["TipoCredito"].Visible = false;
            dgvGrilla.Columns["RefinanciadoStr"].Visible = false;
            

            dgvGrilla.Columns["CodigoCredito"].Visible = true;
            dgvGrilla.Columns["CodigoCredito"].Width = 50;
            dgvGrilla.Columns["CodigoCredito"].HeaderText = @"Código";
            dgvGrilla.Columns["CodigoCredito"].DisplayIndex = 0;

            dgvGrilla.Columns["Monto"].Visible = true;
            dgvGrilla.Columns["Monto"].Width = 100;
            dgvGrilla.Columns["Monto"].HeaderText = @"Monto";
            dgvGrilla.Columns["Monto"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["Monto"].DisplayIndex = 1;

            dgvGrilla.Columns["FechaEmision"].Visible = true;
            dgvGrilla.Columns["FechaEmision"].Width = 100;
            dgvGrilla.Columns["FechaEmision"].HeaderText = @"Emision";
            dgvGrilla.Columns["FechaEmision"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaEmision"].DisplayIndex = 2;

            dgvGrilla.Columns["CantidadCuotas"].Visible = true;
            dgvGrilla.Columns["CantidadCuotas"].Width = 100;
            dgvGrilla.Columns["CantidadCuotas"].HeaderText = @"Cuotas";
            dgvGrilla.Columns["CantidadCuotas"].DisplayIndex = 3;

            dgvGrilla.Columns["MontoCuota"].Visible = true;
            dgvGrilla.Columns["MontoCuota"].Width = 100;
            dgvGrilla.Columns["MontoCuota"].HeaderText = @"Valor Cuota";
            dgvGrilla.Columns["MontoCuota"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["MontoCuota"].DisplayIndex = 4;

            dgvGrilla.Columns["TotalAbonado"].Visible = true;
            dgvGrilla.Columns["TotalAbonado"].Width = 100;
            dgvGrilla.Columns["TotalAbonado"].HeaderText = @"Total Abonado";
            dgvGrilla.Columns["TotalAbonado"].DefaultCellStyle.Format = "C2";
            dgvGrilla.Columns["TotalAbonado"].DisplayIndex = 5;

            dgvGrilla.Columns["FechaCancelacion"].Visible = true;
            dgvGrilla.Columns["FechaCancelacion"].Width = 100;
            dgvGrilla.Columns["FechaCancelacion"].HeaderText = @"Cancelacion";
            dgvGrilla.Columns["FechaCancelacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvGrilla.Columns["FechaCancelacion"].DisplayIndex = 6;

            dgvGrilla.Columns["Estado"].Visible = true;
            dgvGrilla.Columns["Estado"].Width = 100;
            dgvGrilla.Columns["Estado"].HeaderText = @"Estado";
            dgvGrilla.Columns["Estado"].DefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
            dgvGrilla.Columns["Estado"].DisplayIndex = 7;

            dgvGrilla.Columns["Interes"].Visible = true;
            dgvGrilla.Columns["Interes"].Width = 100;
            dgvGrilla.Columns["Interes"].HeaderText = @"Interes";
            dgvGrilla.Columns["Interes"].DisplayIndex = 8;

        }

        public override void dgvGrilla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvGrilla_RowEnter(sender, e);
       
            _credito = (CreditoDto)elementoSeleccionado;
    
            Redimensionar();

        }
    
        public void Redimensionar()
        {
            

            if (_credito != null && _credito.TipoCredito == Constante.TipoCredito.Efecitvo &&
                _credito.FechaCancelacion < DateTime.Now && _credito.Extension == true && _credito.Refinanciado != true)
            {
                btnRefinanciar.Visible = true;
            }
            else
            {
                btnRefinanciar.Visible = false;
            }

            if (_credito != null && _credito.codigoCreditoBase == null && _credito.Extension == true && _credito.Refinanciado == true)
            {
             
                MostrarRefinanciacion();

                lblTituloRefinanciacion.Visible = true;
                pnlRefinanciacion.Visible = true;
                dgvGrillaRefinanciacion.Visible = true;
                btnRecibosRefinanciar.Visible = true;

            }

            else
            {
                lblTituloRefinanciacion.Visible = false;
                pnlRefinanciacion.Visible = false;
            }
        }

        public override void dgvGrillaRefinanciacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            base.dgvGrillaRefinanciacion_RowEnter(sender, e);

            _creditoRefinanciado = (CreditoDto)elementoSeleccionado2;
        }

        public override void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            base.txtBuscar_TextChanged(sender, e);

            if (dgvGrilla.RowCount == 0)
            {
                _credito = null;
            }

            Redimensionar();


        }

        public override void dgvGrilla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrilla.Rows)
            {
                if (Convert.ToString(row.Cells["Estado"].Value) != "Pagado")
                {

                    row.Cells["Estado"].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells["Estado"].Style.ForeColor = Color.Green;
                }
            }
        }

        public override void dgvGrillaRefinanciacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvGrillaRefinanciacion.Rows)
            {
                if (Convert.ToString(row.Cells["Estado"].Value) != "Pagado")
                {

                    row.Cells["Estado"].Style.ForeColor = Color.Red;
                }
                else
                {
                    row.Cells["Estado"].Style.ForeColor = Color.Green;
                }
            }
        }
    }
     
}
