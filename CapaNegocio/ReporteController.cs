using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class ReporteController
    {
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<ListaVenta> ListandoVentas { get; private set; }
        public List<ListaVentaPorPeriodo> ListandoVentasPorPeriodo { get; private set; }
        public decimal TotalVentas { get; private set; }

        public void CreateReportePorVentas(DateTime fromDate, DateTime ToDate)
        {
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = ToDate;

            var orderData = new ReportesDataAccess();
            var result = orderData.ObtnerSaldoDiario(fromDate, ToDate);

            ListandoVentas = new List<ListaVenta>();

            foreach(System.Data.DataRow rows in result.Rows)
            {
                var ventasModal = new ListaVenta()
                {
                    FacturacionId = (Guid)rows[0],//new Guid(Convert.ToString(rows[0])), 
                    AbonoId = (Guid)rows[1],
                    Creado = Convert.ToDateTime(rows[2]),
                    Fecha = Convert.ToDateTime(rows[3]),
                    Abono = Convert.ToDecimal(rows[4])
                };

                ListandoVentas.Add(ventasModal);
                TotalVentas = Convert.ToDecimal(rows[4]);
            }

            var listasaldoventapordias = (from ventas in ListandoVentas
                                     group ventas by ventas.Creado
                                     into listventas
                                     select new {
                                        date = listventas.Key,
                                        amount = listventas.Sum(x => x.Abono)
                                     }).AsEnumerable();

            int totaldias = Convert.ToInt32((ToDate - fromDate).Days);

            if (totaldias <= 7)
            {
                ListandoVentasPorPeriodo = (from ventas in listasaldoventapordias
                                            group ventas by ventas.date.ToString("dd-MMM-yyyy")
                                            into listventas
                                            select new ListaVentaPorPeriodo
                                            {
                                                periodo = listventas.Key,
                                                ventasnetas = listventas.Sum(item => item.amount)
                                            }).ToList();
            }
            else if (totaldias <= 30)
            {
                ListandoVentasPorPeriodo = (from ventas in listasaldoventapordias
                                            group ventas by System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                               ventas.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into listventas
                                            select new ListaVentaPorPeriodo
                                            {
                                                periodo = "Week " + listventas.Key.ToString(),
                                                ventasnetas = listventas.Sum(item => item.amount)
                                            }).ToList();
            }
            else if (totaldias <= 365)
            {
                ListandoVentasPorPeriodo = (from ventas in listasaldoventapordias
                                            group ventas by ventas.date.ToString("dd-MMM-yyyy")
                                            into listventas
                                            select new ListaVentaPorPeriodo
                                            {
                                                periodo = listventas.Key,
                                                ventasnetas = listventas.Sum(item => item.amount)
                                            }).ToList();
            }
            else
            {
                ListandoVentasPorPeriodo = (from ventas in listasaldoventapordias
                                            group ventas by ventas.date.ToString("dd-MMM-yyyy")
                                            into listventas
                                            select new ListaVentaPorPeriodo
                                            {
                                                periodo = listventas.Key,
                                                ventasnetas = listventas.Sum(item => item.amount)
                                            }).ToList();
            }
        }
    }
}
