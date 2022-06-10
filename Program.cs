using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LECCIONPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            cuadrado ocuadrado = new cuadrado("Cuadrado","Verde",5,5,5,5);
            ocuadrado.imprimir();
            rectangulo orectangulo = new rectangulo("Rectangulo","Azul",5,3);
            orectangulo.imprimir();
            circulo ocirculo = new circulo("Circulo","Cafe",5.4);
            ocirculo.imprimir();
            List<Calculo_de_Area> listaformas =new List<Calculo_de_Area>();
            listaformas.Add(ocuadrado);
            listaformas.Add(orectangulo);
            listaformas.Add(ocirculo);
            foreach(Calculo_de_Area figura in listaformas)
            {
                figura.calcular();
            }
        }
    }
}
