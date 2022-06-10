using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECCIONPOO
{
    class rectangulo:figura, Calculo_de_Area
    {
        public int Base { get; set; }
        public int altura { get; set; }
        public rectangulo(string nombre, string color, int Base,int altura):base (nombre, color)
        {
            this.Base= Base;
            this.altura= altura;    
        }
        public void calcular()
        {
            int area = 0;
            area = Base * altura;
            Console.WriteLine("El area del rectangulo es "+area);
        }
    }
}
