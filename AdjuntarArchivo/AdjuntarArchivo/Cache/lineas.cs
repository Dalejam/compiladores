using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjuntarArchivo.Cache
{
    public class lineas
    {
        private int numeroLinea;
        private string contenido;

        private lineas (int numeroLinea, string contenido)
        {
            this.numeroLinea = numeroLinea;
            this.contenido = contenido;
        }
        public static lineas Crear(int numeroLinea,string contenido)
        {
            return new lineas(numeroLinea, contenido);
        }

        public string getContenido()
        {
            if(contenido == "")
            {
                contenido = "";
            }
            return contenido;
        }

        public int getNumeroLinea()
        {
            if(numeroLinea < 0)
            {
                numeroLinea = 0;
            }
            return numeroLinea;
        }

        public bool esFinArchivo()
        {
            return "@EOF".Equals(getContenido());
        }

        public int obtenerLongitudContenido()
        {
            return getContenido().Length;
        }
    }
}
