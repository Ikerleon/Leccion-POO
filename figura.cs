using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECCIONPOO
{
    class figura
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public figura(string nombre,string color)
        {
            this.nombre = nombre;   
            this.color = color;
        }
        public void imprimir()
        {
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Color: "+color);
        }
    }
}
