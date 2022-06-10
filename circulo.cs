using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECCIONPOO
{
    class circulo: figura, Calculo_de_Area
    {
        public double Pi;
        public double R {get; set; }
        public circulo(string nombre, string color, double R):base(nombre,color)
        {
            this.Pi = 3.14;
            this.R = R;
        }
        public void calcular()
        {
            double area = 0;
            area=Pi*(R*R);
            Console.WriteLine("El area del circulo es: "+area);
        }
    }
}
