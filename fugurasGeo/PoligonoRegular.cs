using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fugurasGeo
{
     class PoligonoRegular: Figuras
    {
        private float apo, n;
        public float Apo
        {
            set
            { //PREGUNTA SI EL APOTEMA( ES EL # DEL CENTRO DEL POLIGONO)
                if (value <= 0)
                {
                    apo = 0;//manda el valor a 0 NO EXISTEN APOTEMAS NEGATIVOS
                }
                else
                {
                    apo = value; //value es el valor del exto
                }
            }
            get //obtener el valor
            {
                return apo; //regresa o cacha el valor de la variable apotema
            }
        }
           public float N //VALIDAR EL NUMERO DE LADOS >5
        {
          set 
          { //PREGUNTA si el # de lado (n) >5
            if (value < 5)
            {
                    n = 5; //manda el valor a 0 NO EXISTEN APOTEMAS NEGATIVOS
            }
            else 
            {
               n = value; //value es el valor del textbos
            }
          }
          get //obtener el valor
          {
            return n; //regresa o cacha el valor de la variable lado1
          }

    }
    //usamos el contructor de la clase poligono regular
    public PoligonoRegular(float lado, float apo, float n)
    {
      Lado1 = lado;
            Apo = apo;
      N = n;
    }
    public float area(float peri)//metodo sobrecargado que recibe el perimetro y lo utiliza
    {
      return (peri * apo) / 2;
    }
    public override float perimetro() //metodo con variable de paso que guarda el perimetro
    {
      float peri;
      peri = n * Lado1;
      return peri;
    }
    public override float volumen()
    {
      throw new NotImplementedException();
      //esto es una excepcion de uso default del sistema
      
    }
       public override float area()
    {
      throw new NotImplementedException();
    }
  } 
}
