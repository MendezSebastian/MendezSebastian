using System.Reflection.Metadata;
using System;

namespace cfeApp.Domain
{
    public class CalResistencia: IopeElectrica
    {
        private string _bn1;
        private string _bn2;
        private int _bn3 = 0;
        private string _bn4;
        private double _resultado = 0.0;
        public string Calcular(string bn1, string bn2, int bn3, string bn4)
        
        {
                  _bn1 = bn1;
                  _bn2 = bn2;
                  _bn3 = bn3;
                  _bn4 = bn4;
              string aux2="";
              double aux=0.0;
            if (!(validar()))
            {
                return ("Parametros incorrectos");
            }

                int num= int.Parse(_bn1 + _bn2);

               if (_bn4=="DORADO")
               {
                    
                    if (_bn3==2)
                    {
                      _bn3=100;
                    }

                    if (_bn3 == 5)
                    {
                      _bn3 = 100000;
                     
                    }
                    if (_bn3==7)
                    {
                        _bn3 =10000000;           
                    }      
                    
                    _resultado = num * _bn3;
                    aux = (_resultado*0.05);
               }


                if (_bn4=="PLATEADO")

               {
                    
                    if (_bn3==2)
                    {  
                        _bn3=100;
                    }
                    if (_bn3 == 5)
                    {  
                        _bn3 = 100000;
                    }

                    if (_bn3==7)
                    { 
                       _bn3 =10000000;
                    }      
                        _resultado = num * _bn3;
                        aux = (_resultado*0.10);
               }
            aux2= $"El valor de esta resistencia {_resultado} y tiene una tolerancia de maxima que es {_resultado + aux} y una tolerancia minima que es {_resultado - aux}";
            return aux2;
               
        }

        private bool validar ()
        {
                if (!(_bn3 == 2 || _bn3 == 5 || _bn3 ==7))
                {
                   return false;
                }

                if (!(_bn4=="PLATEADO" || _bn4 =="DORADO"))
                {
                    return false;
                }
                return true;
        }

    }
}