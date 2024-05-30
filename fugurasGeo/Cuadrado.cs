using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fugurasGeo
{
    internal class Cuadrado: Figuras
    {

        public Cuadrado(float lado1)
        {
            this.Lado1 = lado1;

        }
        public override float area() //aqui lo que hara es realizar las operaciones que solicita el usuario
        {
            return Lado1 * Lado1; //es la formula general para sacar el area
        }
        public override float perimetro()
        {
            return Lado1 * 4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
