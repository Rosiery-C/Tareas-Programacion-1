using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Tarea_Herencia;

namespace Tarea_Herencia
{


    public class Menu
    {
        //arreglo
        public Inventario[] Menu_Inventario { set; get; }
        public Inventario [] Estado { set; get; }
        public int Dimension { set; get; }
       

        //declaramos constructor
        public Menu()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            Dimension = Convert.ToInt32(Console.ReadLine());
            Menu_Inventario = new Inventario[Dimension];
            Estado = new Inventario[Dimension];

        }

        //declarar metodos
        public void Administrar()
        {
            for (int r = 0; r < Dimension; r++)
            {
                Menu_Inventario[r] = new Inventario();
                Console.WriteLine("Ingrese Datos Producto" + (r + 1));
                Menu_Inventario[r].Administrar();

            }
        }
        public void Consultar()
        {
            for (int t = 0; t < Dimension; t++)
            {
                Menu_Inventario.Union(Estado).ToArray()[t].Consultar();
                
            }
        }

        public void Ts(string Codigo_almacen) 
        {
            for (int e = 0; e < Dimension; e++)
            {
                if (Codigo_almacen == Menu_Inventario[e].Codigo_almacen)
                {
                    Menu_Inventario[e].Consultar();
                }
            }
        }

        public void Ingreso_sistema()
        {
            for (int p = 0; p < Dimension; p++)
            {
                Estado[p] = new Inventario();
                Console.WriteLine("Ingrese Mercancia a Registrar" + (p + 1));
                Estado[p].Ingreso_sistema(); 

            }
        }

    }

    public class Menu2
    {
        public int Dimension { set; get; }

        //arreglo
        public Producto [] Submenu { set; get; }
      
        //declarar constructor
        public Menu2 ()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            Dimension = Convert.ToInt32(Console.ReadLine());
            Submenu = new Producto[Dimension];
        }


        //declar los metodos leer, mostrar y buscar 
        public void Ingresar()
        {
            for (int a = 0; a < Dimension; a++)
            {
                Submenu[a] = new Producto();
                Console.WriteLine("Ingrese Datos Producto" + (a + 1));
                Submenu[a].Ingresar();

            }
        }
        public void Visualizar() 
        {
            
            for (int t = 0; t < Dimension; t++)
            {
                Submenu[t].Visualizar();
            }
        }
        public void Bs(string Codigo_producto) 
        {
            for (int e = 0; e < Dimension; e++)
            {
                if (Codigo_producto == Submenu[e].Codigo_producto)
                {
                    Submenu[e].Ingreso_sistema(); 
                }
            }
        }
    }




    public class Menu3
    {
        //arreglo
        public Producto.Vendedor [] Subt { set; get; }
        public Producto.Ventas[] Submenu3 { set; get; }
        public int Dimension { set; get; }

        //declarar constructor
        public Menu3()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            Dimension = Convert.ToInt32(Console.ReadLine());
            Submenu3 = new Producto.Ventas [Dimension];
            Subt = new Producto.Vendedor[Dimension];
        }


        //declar los metodos leer, mostrar y buscar 
        public void Factura()
        {
            for (int r = 0; r < Dimension; r++)
            {
                Subt[r] = new Producto.Vendedor();
                Console.WriteLine("Ingrese Codigo Vendedor" + (r + 1));
                Subt[r].Factura();

            }
        }

        public void Preventa()
        {
            for (int r = 0; r < Dimension; r++)
            {
                Submenu3[r] = new Producto.Ventas();
                Console.WriteLine("Registre Venta" + (r + 1));
                Submenu3[r].PreVenta();

            }
        }

        public void Producto_Vendido() 
        {
            for (int t = 0; t < Dimension; t++)
            {
                Submenu3[t].Producto_Vendido();
            }
        }
        public void Rs(string Compra) 
        {
            for (int e = 0; e < Dimension; e++)
            {
                if ( Compra== Submenu3[e].Compra)
                {
                    Submenu3[e].Producto_Vendido(); 
                }
            }
        }
    }

    public class Menu4
    {
        //arreglo
        public Producto.Empleado[] Submenu4 { set; get; }
        public int Dimension { set; get; }

        //declarar constructor
        public Menu4()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            Dimension = Convert.ToInt32(Console.ReadLine());
            Submenu4 = new Producto.Empleado [Dimension];
        }

        //declar los metodos leer, mostrar y buscar 
        public void Leer() 
        {
            for (int r = 0; r < Dimension; r++)
            {

                // instanciar como un objeto 
                Submenu4[r] = new Producto.Empleado();
                Console.WriteLine("Ingrese Datos Empleado" + (r + 1));
                Submenu4[r].Leer();


            }
        }
        public void Mostrar() 
        {
            for (int s = 0; s < Dimension; s++)
            {
                Submenu4[s].Mostrar();
            }
        }
        public void Buscar(string Nombre_apellido) 
        {
            for (int e = 0; e < Dimension; e++)
            {
                if (Nombre_apellido == Submenu4[e].Nombre_apellido)
                {
                    Submenu4[e].Mostrar();
                }
            }
        }

}   }

