using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class VentaModel
    {
        public Producto producto { get; set; }
        public Cliente cliente { get; set; }
        public Client_Produc clientProduc { get; set; }
        public ClientProducView clientProducView { get; set; }
        public Recibo recibo { get; set; }
        public ReciboView reciboView { get; set; }
        public VentaModel()
        {
            this.producto = new Producto();
            this.cliente = new Cliente();
            this.clientProduc = new Client_Produc();
            this.clientProducView = new ClientProducView();
            this.recibo = new Recibo();
            this.reciboView = new ReciboView();
        }
    }

    public class Producto
    {
       public Guid ProductoId { get; set; }
       public string Codigo { get; set; }
       public int ProductoCategoriaId { get; set; }
       public string ProveedorId { get; set; }
       public string Nombre { get; set; }
       public int Cantidad { get; set; }
       public string Descripcion { get; set; }
       public decimal Monto { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
    }

    public class Cliente
    {
       public Guid ClienteId { get; set; }
       public string Cedula { get; set; }
       public string PrimerNombre { get; set; }
       public string SegundoNombre { get; set; }
       public string PrimerApellido { get; set; }
       public string SegundoApellido { get; set; }
       public string Direccion { get; set; }
       public string Telefono { get; set; }
       public DateTime Creado { get; set; }
       public DateTime Modificado { get; set; }
    }

    #region Vendedor

    public class VendedorModel
    {
        public Guid VendedorId { get; set; }
        public string Codigo { get; set; }
        public string vendedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
    }

    #endregion

    #region Client_Produc

    #region Proveedor
    public class ProveedorModel
    {
        public Guid ProveedorId { get; set; } 
        public string Proveedor { get; set; }
        public string Correo { get; set; }
        public string Contacto { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
    }
    #endregion

    public class Client_Produc
    {
       public Guid ClientProducId { get; set; }
        public Guid ClienteId { get; set; }
        public Guid ProductoId { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public int MesesPagar { get; set; }
        public decimal Monto { get; set; }
        public decimal Nuevo_Saldo { get; set; }
        public decimal MontoPrima { get; set; }
        public int FrecuenciaId { get; set; }
        public int DiaSemana { get; set; }
        public int DiaPrimeraQuincena { get; set; }
        public int DiaSegundaQuincena { get; set; }
        public int DiaMes { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
    }
    public class ClientProducView
    {
       public Guid ClientProducId { get; set; }
        public decimal Monto { get; set; }
        public decimal Nuevo_Saldo { get; set; }
        public DateTime FechaPagos { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public Guid Clienteid { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Guid ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Creado { get; set; }
        public DateTime Modificado { get; set; }
    }

    #endregion

    #region
    public class Recibo
    {
       public Guid ReciboId { get; set; }
	   public string Codigo { get; set; }
        public Guid ClienteId { get; set; }
        public Guid ClientProducId { get; set; }
        public string Compra { get; set; }
        public string Concepto { get; set; }
       public DateTime FechaAbono { get; set; }
       public decimal MontoAbono { get; set; }
       public decimal NuevoSaldo { get; set; }
       public DateTime Creado { get; set; }
       public DateTime Modificado { get; set; }
    }

    public class ReciboView
    {
       public Guid ReciboId { get; set; }
       public string Codigo { get; set; }
       public string Concepto { get; set; }
       public DateTime FechaAbono { get; set; }
       public decimal MontoAbono { get; set; }
       public decimal NuevoSaldo { get; set; }
       public Guid ClienteId { get; set; }
       public string PrimerNombre { get; set; }
       public string SegundoNombre { get; set; }
       public string PrimerApellido { get; set; }
       public string SegundoApellido { get; set; }
       public string Telefono { get; set; }
       public string Direccion { get; set; }
       public DateTime Creado { get; set; }
       public DateTime Modificado { get; set; }
    }
    #endregion
}
