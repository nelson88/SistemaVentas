using System;
namespace CapaEntidad
{
    public class ListaVenta
    {
        public Guid FacturacionId { get; set; }
        public Guid AbonoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }
        public DateTime Creado { get; set; }
        
    }
}