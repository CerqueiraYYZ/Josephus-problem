using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    public static class GeneraNumeroDeSobrevivientes
    {
        public static int GeneraElNumeroDeSobrevivientes(int numeroDePersonas)
        {
            //crea el arreglo que seria el circulo
           Boolean[] circulodePersonas = new Boolean[numeroDePersonas];
            //enumera las personas
            for(int contador = 0;contador<numeroDePersonas;contador++){
                circulodePersonas[contador] = true;              
            }
            //Se empiezan a ejecutar aleatoriamente, saltando solo a 1 por turno
            int sobreviviente = 0;
            int personaEjecuta = 0;
            int variableAux = 0;
            bool meDetengo = true;
            while (meDetengo)
            {
                if (personaEjecuta < circulodePersonas.Length - 1 && circulodePersonas[personaEjecuta])
                {
                    sobreviviente = personaEjecuta;
                    for (int contador = personaEjecuta; contador<circulodePersonas.Length-1;contador++)
                    {
                        if (circulodePersonas[contador+1])
                        {
                            circulodePersonas[contador+1] = false;
                            break;
                        }
                        if (contador+1 == circulodePersonas.Length-1) {
                            contador = -1;
                        }
                       
                    }
                    
                }
                if (personaEjecuta == circulodePersonas.Length-1 && circulodePersonas[personaEjecuta])
                {
                    sobreviviente = personaEjecuta;
                    personaEjecuta = 0;
                    for (int contador = personaEjecuta; contador < circulodePersonas.Length - 1; contador++)
                    {
                        if (circulodePersonas[contador])
                        {
                            circulodePersonas[contador] = false;
                            break;
                        }

                    }
                    personaEjecuta--;
                }
                if (personaEjecuta == circulodePersonas.Length - 1 && circulodePersonas[personaEjecuta] == false)
                {
                    personaEjecuta = -1;
                }
                personaEjecuta++;
                foreach (bool contador in circulodePersonas)
                {
                    if (contador)
                    {
                        variableAux++;
                    }
                    if (variableAux > 1)
                    {
                        variableAux = 0;
                        break;
                    }

                }
                if (variableAux == 1)
                {
                    meDetengo = false;
                }
            }
            return sobreviviente+1;
        }

    }
}
