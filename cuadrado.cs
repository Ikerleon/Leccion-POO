using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECCIONPOO
{
    class cuadrado:figura,Calculo_de_Area
    {
        public int lado1 { get; set; }
        public int lado2 { get; set; }
        public int lado3 { get; set; }
        public int lado4 { get; set; }
        public cuadrado(string nombre, string color,int lado1,int lado2,int lado3,int lado4): base(nombre,color)  
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.lado4 = lado4;
        }
        public void calcular()
        {
            int area = 0;
            area= lado1 + lado2 + lado3 + lado4;
            Console.WriteLine("El area del cuadrado es "+area);
        }

    }
}
