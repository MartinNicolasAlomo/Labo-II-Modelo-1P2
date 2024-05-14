using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteca
{
    public class Biografia : Publicacion
    {

        public Biografia(string nombre) : base(nombre)
        {
        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }


        public override bool HayStock
        {
            get { return Stock > 0; }
        }

        protected override bool EsColor
        {
            get { return false; }
        }


        public static explicit operator Biografia?(string nombre)
        {
            return new Biografia(nombre);
        }




    }
}
