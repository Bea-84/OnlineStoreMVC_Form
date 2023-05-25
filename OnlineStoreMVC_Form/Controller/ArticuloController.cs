using OnlineStoreMVC_Form.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreMVC_Form.Controller
{
    internal class ArticuloController
    {
        Datos datos;

        public ArticuloController(Datos pDatos) 
        {
            datos = pDatos;
        }

        public string getArticulo(string codigo)
        {
            string descrip_Articulo = datos.getDescripcionArticulo(codigo);
            return descrip_Articulo;
        } 

        public void añadirArticulo(Hashtable articuloHash)
        {
            datos.addArticulo(articuloHash);
        } 

        public List<string>getlistaArticulos()
        {
            return datos.listaArticulos(); 
        }

    
    }
}
