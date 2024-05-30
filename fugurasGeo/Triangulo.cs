using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fugurasGeo
{
    class Triangulo : Figuras
    {
        private float lado2;
        
        public float Lado2   
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado2 = value;
                }
            }
            get //obtener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado1
            }

        }
       
        public Triangulo (float lado1,float lado2, float altura, float basebaja) 
        {  //la operacion que realiza es leer lo que ya se guardo en nuestra caja de texto
            this.Lado1 = lado1;// hace que unicamente el valor la
                               //cantidad del lado sea disponible
                               //para la clase triangulo, cuando no se usa triangulo
                               //la variable sera=0
            this.Lado2 = lado2;
           
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area() //aqui lo que hara es realizar las operaciones que solicita el usuario
        {
            return (Lado1 * Lado2) / 2; //es la formula general para sacar el area
        }
        public override float perimetro()
        {
            return Lado1 * 3;   
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}
