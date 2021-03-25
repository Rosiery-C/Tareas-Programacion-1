using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_2_Prueba_5252
{
    public class Menu1
    {
        //arreglo
        public Empleado [] Menu_principal { set; get; }
        public int dimension { set; get; }

        //declarar constructor
        public Menu1()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            dimension = Convert.ToInt32(Console.ReadLine());
            Menu_principal = new Empleado[dimension];
        }

        //declar los metodos leer, mostrar y buscar 
        public void leer()
        {
            for (int r = 0; r < dimension; r++)
            {
                
                // instanciar como un objeto 
                Menu_principal[r] = new Empleado();
                Console.WriteLine("Ingrese Datos Empleado"+ (r + 1));
                Menu_principal[r].leer();
                

            }
        }
        public void mostrar ()
        {
            for (int s = 0; s < dimension; s++)
            {
                Menu_principal[s].mostrar();
            }
        }
        public void buscar(string codigo_empleado)
        {
            for (int e = 0; e < dimension; e++)
            {
                if (codigo_empleado == Menu_principal[e].Codigo_empleado)
                {
                    Menu_principal[e].mostrar();
                }
            }
        }

        
    }

    public class Menu2
    {
        //arreglo
        public Producto[] submenu { set; get; }
        public int dimension { set; get; }

        //declarar constructor
        public Menu2()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            dimension = Convert.ToInt32(Console.ReadLine());
            submenu = new Producto [dimension];
        }


        //declar los metodos leer, mostrar y buscar 
        public void ingresar()
        {
            for (int a = 0; a < dimension; a++)
            {
                submenu[a] = new Producto();
                Console.WriteLine("Ingrese Datos Producto" + (a + 1));
                submenu[a].ingresar();

            }
        }
        public void visualizar() 
        {
            for (int t = 0; t < dimension; t++)
            {
                submenu[t].visualizar();
            }
        }
        public void bs(string codigo_producto)
        {
            for (int e = 0; e < dimension; e++)
            {
                if (codigo_producto == submenu[e].Codigo_producto)
                {
                    submenu[e].visualizar();
                }
            }
        }
    }

    public class Menu3
    {
        //arreglo
        public Inventario[] submenu2 { set; get; }
        public int dimension { set; get; }

        //declarar constructor
        public Menu3()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            dimension = Convert.ToInt32(Console.ReadLine());
            submenu2 = new Inventario[dimension];
        }


        //declar los metodos leer, mostrar y buscar 
        public void administrar()
        {
            for (int r = 0; r < dimension; r++)
            {
                submenu2[r] = new Inventario();
                Console.WriteLine("Ingrese Datos Producto" + (r + 1));
                submenu2[r].administrar();

            }
        }
        public void consultar()
        {
            for (int t = 0; t < dimension; t++)
            {
                submenu2[t].consultar();
            }
        }
        public void ts(string proveedor)
        {
            for (int e = 0; e < dimension; e++)
            {
                if (proveedor == submenu2[e].proveedor)
                {
                    submenu2[e].consultar();
                }
            }
        }

    }

    public class Menu4
    {
        //arreglo
        public Ventas[] submenu3 { set; get; }
        public int dimension { set; get; }

        //declarar constructor
        public Menu4()
        {
            Console.WriteLine("Ingrese la dimension del arreglo");
            dimension = Convert.ToInt32(Console.ReadLine());
            submenu3 = new Ventas[dimension];
        }


        //declar los metodos leer, mostrar y buscar 
        public void preventa()
        {
            for (int r = 0; r < dimension; r++)
            {
                submenu3[r] = new Ventas();
                Console.WriteLine("Ingrese Datos Producto" + (r + 1));
                submenu3[r].preVenta();

            }
        }
        public void producto_Vendido()
        {
            for (int t = 0; t < dimension; t++)
            {
                submenu3[t].producto_Vendido();
            }
        }
        public void bs(string producto)
        {
            for (int e = 0; e < dimension; e++)
            {
                if (producto == submenu3[e].producto)
                {
                    submenu3[e].producto_Vendido();
                }
            }
        }
    }
}
