using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fugurasGeo
{
    internal class Esfera: Figuras
    {
        public Esfera(float radio)
        { //radio se va a leer de la caja de texto con 
            //usando el boton guardar
            Lado1 = radio;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return 4 * 3.1416F * (Lado1 *Lado1) ;
            //AGREGAMOS F AL FINAL DE UN NUMERO CUANDO
            //ES CONSTANTE NO DEFINITIVA EN UNA VARIABLE
            //PREVIAMENTE, ASI EL PROGRAMA SABE QUE ES UN #
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            return (4 * 3.1416F * (Lado1 * Lado1 * Lado1)) / 3;
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
