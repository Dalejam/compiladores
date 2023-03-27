using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjuntarArchivo.Cache
{
    public class Cache
    {
        private static Cache INSTANCIA = new Cache();

        private IDictionary<int,lineas> linea = new Dictionary<int, lineas>();

        private Cache()
        {

        }

        public static Cache GetCache()
        {
            return INSTANCIA;
        }

        public void Reiniciar()
        {
            linea.Clear();
        }

        private int obtenerNumeroLineas()
        {
            return linea.Keys.Count;
        }

        public void agregarContenido(string contenido)
        {
            if(contenido != null)
            {
                int numeroLineas = obtenerNumeroLineas()+1;
                linea.Add(numeroLineas,lineas.Crear(numeroLineas,contenido));
            }
        }

        public lineas ObtenerContenido(int numeroLinea)
        {
            lineas Retorno = lineas.Crear(obtenerNumeroLineas()+1,"@EOF@");
            if (linea.ContainsKey(numeroLinea))
            {
                Retorno = linea[numeroLinea];
            }
            return Retorno;
        }
    }
}
