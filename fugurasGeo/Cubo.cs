using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fugurasGeo
{
    internal class Cubo: Figuras
    {
        public Cubo(float lado1)
        {
            this.Lado1 = lado1;

        }
        public override float area() //aqui lo que hara es realizar las operaciones que solicita el usuario
        {
            return 6 * (Lado1 * Lado1); //es la formula general para sacar el area
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
          return Lado1 * Lado1 * Lado1;
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
