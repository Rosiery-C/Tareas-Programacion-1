using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_2_Prueba_5252
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu1 opciones = new Menu1();
            Menu2 segunda_opcion = new Menu2();
            Menu3 tercera_opcion = new Menu3();
            Menu4 cuarta_opcion = new Menu4();
            int op=0, op1, op2, op3, op4;

            while (op != 4)
            {


                Console.Clear();
                Console.WriteLine("----------------");
                Console.WriteLine("Menu Min & Asoc.");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Empleados");
                Console.WriteLine("2. Producto");
                Console.WriteLine("3. Inventario");
                Console.WriteLine("4. Ventas");
                Console.WriteLine("5. Salir");
                Console.WriteLine("------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {   
                            Console.Clear();
                            Console.WriteLine("----------------");
                            Console.WriteLine("Menu Empleados");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("1. Registrar Empleado");
                            Console.WriteLine("2. Lista de Empleados");
                            Console.WriteLine("3. Buscar Empleado");
                            Console.WriteLine("------------");
                            op1 = Convert.ToInt32(Console.ReadLine());

                            switch (op1)
                            {
                                case 1:
                                    {
                                        opciones.leer();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        opciones.mostrar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string codigo_empleado = Console.ReadLine();
                                        opciones.buscar(codigo_empleado);

                                    }
                                    break;

                            }
                        }break;


                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("----------------");
                            Console.WriteLine("Menu Producto");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("1. Registrar Producto");
                            Console.WriteLine("2. Lista de Productos");
                            Console.WriteLine("3. Buscar Producto");
                            Console.WriteLine("------------");
                            op2 = Convert.ToInt32(Console.ReadLine());

                            switch (op2)
                            {
                                case 1:
                                    {
                                        segunda_opcion.ingresar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        segunda_opcion.visualizar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string codigo_producto = Console.ReadLine();
                                        segunda_opcion.bs(codigo_producto);

                                    }
                                    break;

                            }

                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("----------------");
                            Console.WriteLine("Menu Inventario");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("1. Registrar Inventario");
                            Console.WriteLine("2. Lista de Inventario");
                            Console.WriteLine("3. Buscar Inventario");
                            Console.WriteLine("------------");
                            op3 = Convert.ToInt32(Console.ReadLine());

                            switch (op3)
                            {
                                case 1:
                                    {
                                        tercera_opcion.administrar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        tercera_opcion.consultar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string proveedor = Console.ReadLine();
                                        tercera_opcion.ts(proveedor);

                                    }
                                    break;

                            }
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("----------------");
                            Console.WriteLine("Menu Ventas");
                            Console.WriteLine("-----------------");
                            Console.WriteLine("1. Registrar Venta");
                            Console.WriteLine("2. Lista de Venta");
                            Console.WriteLine("3. Buscar Venta");
                            Console.WriteLine("------------");
                            op4 = Convert.ToInt32(Console.ReadLine());

                            switch (op4)
                            {
                                case 1:
                                    {
                                        cuarta_opcion.preventa();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        cuarta_opcion.producto_Vendido();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {

                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string producto = Console.ReadLine();
                                        cuarta_opcion.bs(producto);

                                    }
                                    break;


                            }break;

                        }
                       

                    case 5:
                        {
                            Console.ReadKey();
                        }break;


                }

               





             }


        }
    }
}

