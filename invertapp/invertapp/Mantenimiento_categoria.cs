using System;
using System.Collections.Generic;
using System.Text;

namespace invertapp
{
    class Mantenimiento_categoria
    {
        string nombre { get; set; }
        public Mantenimiento_categoria(string nueva_categoria)
        {
            nombre = nueva_categoria;
        }
        public List<Mantenimiento_categoria> listado_categoria { get; set; } = new List<Mantenimiento_categoria>();
        public void menu_Mantenimiento_categoria()
        {
            MenuPrincipal menu = new MenuPrincipal();
            Console.WriteLine("Menu Mantenimiento de categoria\n-------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Elige unas de estas opciones:\n1- Agregar categoría\n2- Editar categoría\n3- Eliminar categoría\n4- Listar categorías\n5- Volver atrás");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre de la nueva categoria: ");
                string nombre = Console.ReadLine();
                Mantenimiento_categoria mantenimiento_categoria = new Mantenimiento_categoria(nombre);
                listado_categoria.Add(mantenimiento_categoria);
                Console.WriteLine("El nombre de la categoria se agrego correctamente");
            }
            else if(opcion == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("En que posicion esta la categoria que desea editar? : ");
                int editar_posicion = int.Parse(Console.ReadLine());
                listado_categoria[editar_posicion].nombre

                Console.WriteLine("Cual es el nuevo nombre de categoria: ");
                string editar_nombre = Console.ReadLine();
                //2-Editar categoría ( seleccionar la que desea editar al seleccionarla pues se nos pregunta el nuevo nombre de esa categoría y se edita y se guarda el cambio).
            }
            else if (opcion == "3")
            {
                Console.WriteLine("");
                Console.WriteLine("En que posicion esta la categoria que desea editar? : ");
                int eliminar_posicion = int.Parse(Console.ReadLine());
                //3- luego selecciona la que deseas eliminar, luego de seleccionar la que desea borrar el sistema te 
                Console.WriteLine("Estás seguro que desea eliminar esa categoría?\nS para si N para no");
                string eliminar = Console.ReadLine();
            }
            else if (opcion == "4")
            {
                for (int i = 0; i < listado_categoria.Count; i++)
                {
                    Console.WriteLine((i+1) + "- " + listado_categoria[i].nombre);
                }
            }
            else if (opcion == "5")
            {
                menu.menu();
            }
        }
    }
}
