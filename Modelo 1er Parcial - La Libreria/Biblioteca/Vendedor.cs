using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;


        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }


        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (vendedor is not null && publicacion is not null && publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }


        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            if (vendedor is not null)
            {
                float totalVentas = 0;
                StringBuilder text = new StringBuilder();
                text.AppendLine($"{vendedor.nombre.ToUpper()}");
                foreach (Publicacion publicacionVendida in vendedor.ventas)
                {
                    text.AppendLine($"----------------------------------------")
                        .AppendLine($"Publicación: {publicacionVendida.ObtenerInformacion()}");
                    totalVentas += publicacionVendida.Importe;
                }
                text.AppendLine($"{Environment.NewLine}Ganancia Total: {totalVentas:C2}")                    ;
                return text.ToString();
            }
            return "No existe el vendedor.";
        }






    }
}
