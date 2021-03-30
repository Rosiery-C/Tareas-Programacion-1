using System;

namespace Tarea_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu opciones = new Menu();
            Menu2 segunda_opcion = new Menu2();
            Menu3 tercera_opcion = new Menu3();
            Menu4 cuarta_opcion = new Menu4();
            int op = 0, op1, op2, op3, op4;

            while (op != 4)
            {


                Console.Clear();
                Console.WriteLine("                        ");
                Console.WriteLine("---Menu Min & Asoc.----");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Sistema Almacen General");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1.-----Inventario------");
                Console.WriteLine("2.-----Producto--------");
                Console.WriteLine("3.-----Ventas----------");
                Console.WriteLine("4.-----Empleados-------");
                Console.WriteLine("5.-----Salir-----------");
                Console.WriteLine("------------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("---Ingreso Mercancia---------");
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("1.-Registrar Mercancia-------");
                            Console.WriteLine("2.-Ingresar Mercancia Almacen");
                            Console.WriteLine("3.-Lista de Mercancia------- ");
                            Console.WriteLine("4.-Buscar Almacen------------");
                            Console.WriteLine("-----------------------------");
                            op1 = Convert.ToInt32(Console.ReadLine());

                            switch (op1)
                            {
                                case 1:
                                    {
                                        opciones.Ingreso_sistema();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        opciones.Administrar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        opciones.Consultar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string Codigo_almacen = Console.ReadLine();

                                        opciones.Ts(Codigo_almacen);
                                    }
                                    break;
                            }
                        }
                        break;


                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("---------------------");
                            Console.WriteLine("---Menu Producto-----");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("1. Registrar Producto");
                            Console.WriteLine("2. Lista de Productos");
                            Console.WriteLine("3. Buscar Producto");
                            Console.WriteLine("---------------------");
                            op2 = Convert.ToInt32(Console.ReadLine());

                            switch (op2)
                            {
                                case 1:
                                    {
                                        segunda_opcion.Ingresar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        segunda_opcion.Visualizar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Ingrese su Codigo a Buscar");
                                        string codigo_producto = Console.ReadLine();
                                        segunda_opcion.Bs(codigo_producto);

                                    }
                                    break;

                            }

                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("--------Menu Ventas-----------");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("1.-Registrar Codigo Vendedor--");
                            Console.WriteLine("2.-Registrar Venta------------");
                            Console.WriteLine("3.-Factura Final--------------");
                            Console.WriteLine("4.-Buscar Factura-------------");
                            Console.WriteLine("------------------------------");
                            op3 = Convert.ToInt32(Console.ReadLine());

                            switch (op3)
                            {
                                case 1:
                                    {
                                        tercera_opcion.Factura();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        tercera_opcion.Preventa();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {
                                        tercera_opcion.Producto_Vendido();
                                        Console.ReadLine();

                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string Compra = Console.ReadLine();
                                        tercera_opcion.Rs(Compra); 
                                    }
                                    break;
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("----Menu Empleado------");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("1.--Registrar Empleado-");
                            Console.WriteLine("2.--Lista de Empleados-");
                            Console.WriteLine("3.-Buscar Empleado-----");
                            Console.WriteLine("-----------------------");
                            op4 = Convert.ToInt32(Console.ReadLine());

                            switch (op4)
                            {
                                case 1:
                                    {
                                        cuarta_opcion.Leer();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        cuarta_opcion.Mostrar();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 3:
                                    {

                                        Console.WriteLine("Ingrese su codigo a buscar");
                                        string Nombre_apellido = Console.ReadLine();
                                        cuarta_opcion.Buscar(Nombre_apellido);

                                    }
                                    break;


                            }
                            break;

                        }


                    case 5:
                        {

                        }
                        break;




                }
}    }  }   }
