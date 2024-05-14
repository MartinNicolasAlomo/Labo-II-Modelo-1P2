using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        /*
        
         Biblioteca: 47:41 Mins.
         Winforms: 36:26 Mins.
         Total: 1:24:07 Mins.
         
         */


        private string nombre;
        private float importe;
        private int stock;


        protected Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        protected Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        protected Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }


        protected abstract bool EsColor { get; }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
            }
        }

        public float Importe
        {
            get { return importe; }
        }

        public virtual bool HayStock
        {
            get { return stock > 0 && importe > 0; }
        }

        public virtual string ObtenerInformacion()
        {
            string esColor = EsColor ? "SI" : "NO";
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Nombre: {nombre}")
                .AppendLine($"Importe: {importe:C2}")
                .AppendLine($"Es Color: {esColor}")
                .AppendLine($"Stock: {stock.ToString()}")
                ;
            //text.AppendFormat("Nombre: {0}{1}", nombre, Environment.NewLine);
            //text.Append($"Stock: {Stock}{Environment.NewLine}");
            //text.AppendLine($"Es color: {esColor}");
            //text.AppendLine($"Valor: ${importe:c2}");
            return text.ToString();
        }


        public override string ToString()
        {
            return nombre;
        }





    }
}
