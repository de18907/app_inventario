using System;
using System.Collections.Generic;
using System.Text;

namespace invertapp
{
    class MenuPrincipal
    {
        public void menu()
        {
            try
            {
                Mantenimiento_categoria mantenimiento_categoria = new Mantenimiento_categoria(true);
                Mantenimiento_productos mantenimiento_productos = new Mantenimiento_productos();
                Entrada_inventario entrada_inventario = new Entrada_inventario();
                Salida_inventario salida_inventario = new Salida_inventario();
                Console.WriteLine("Menu\n-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Elige unas de estas opciones:\n1- Mantenimiento de categoria\n2- Mantenimiento de productos\n3- Entrada de inventario\n4- Salida de inventario\n5- Salir");
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.Clear();
                    mantenimiento_categoria.menu_Mantenimiento_categoria();
                }
                else if (opcion == "2")
                {
                    Console.Clear();
                }
                else if (opcion == "3")
                {
                    Console.Clear();
                }
                else if (opcion == "4"){}
                else
                {
                    Console.Clear();
                    Console.WriteLine("Algo salio mal vuelve al menu presione enter");
                    Console.ReadKey();
                    menu();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal vuelve al menu presione enter");
            }
        }
    }
}
