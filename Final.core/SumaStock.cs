using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.core
{
    public class SumaStock
    {
        public List<ItemsArticulo> Item { get; set; } = new List<ItemsArticulo>();

        public List<FuncionStock> sumas { get; set; } = new List<FuncionStock>();


        public void CargarArticulo(List<ItemsArticulo> NuevosArticulo)
        {
            Item = NuevosArticulo;
        }

        public string EncontrarArticulo(string Nombre)
        {
            string encontrado = "";

            foreach (var item in Item)
            {
                if (item.Nombre == Nombre)
                {
                    encontrado += " Nombre: " + item.Nombre + " Descripcion: " + item.descripcion + " Stock: " + item.stock + " Precio: " + item.Precio + " \n ";
                    break;
                }
            }

            return encontrado;

        }

        public double Obtenertotal()
        {
            return Item.Sum(FuncionStock => FuncionStock.stock);

        }



        public string mostrarlista() {

            string productos = "";

            foreach (var item in Item)
            {



                productos += " Nombre: " + item.Nombre + " Descripcion: " + item.descripcion + " Stock: " + item.stock + " Precio: " + item.Precio + " \n ";
                
            }


            return productos;
        }   







}
}
