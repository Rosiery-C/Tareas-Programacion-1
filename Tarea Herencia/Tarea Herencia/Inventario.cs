using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Herencia
{
    public class Inventario
    {
        // atributo
        private string codigo_almacen = String.Format("{0:(###) ###-####}", 80055);
        private string cantidad_disponible_producto = String.Format("{0:(###) ###-####}", 8005551212);
        private string precio_compra = String.Format("{0:(###) ###-####}", 8005551212);
        private string precio_venta = String.Format("{0:(###) ###-####}", 8005551212);
        private string proveedor;
        private string localidad;
        private string codigo_producto = String.Format("{0:(###) ###-####}", 8005);
        private string nombre_producto;

        public string Cantidad_disponible_producto { get => cantidad_disponible_producto; set => cantidad_disponible_producto = value; }
        public string Precio_compra { get => precio_compra; set => precio_compra = value; }
        public string Precio_venta { get => precio_venta; set => precio_venta = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Codigo_almacen { get => codigo_almacen; set => codigo_almacen = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }

        //constructor
        public Inventario()
        {
            Codigo_almacen = "";
            Cantidad_disponible_producto = "";
            Precio_compra = "";
            Precio_venta = "";
            Proveedor = "";
            Localidad = "";
            Codigo_producto = "";
            Nombre_producto = "";
        }

        //Metodos
        public void Administrar()
        {

            Console.WriteLine("Cantidad Disponible");
            Cantidad_disponible_producto = Console.ReadLine();
            Console.WriteLine("Precio de Compra");
            Precio_compra = Console.ReadLine();
            Console.WriteLine("Precio de Venta");
            Precio_venta = Console.ReadLine();
            Console.WriteLine("Proveedor");
            Proveedor = Console.ReadLine();
            Console.WriteLine("Localidad");
            Localidad = Console.ReadLine();
            Console.WriteLine("Area Almacen");
            Codigo_almacen = Console.ReadLine();
        }

        public void Consultar()
        {
            Console.WriteLine("Codigo Producto\n" + Codigo_producto);
            Console.WriteLine("Nombre Producto\n" + Nombre_producto);
            Console.WriteLine("Disponible en Inventario\n " + cantidad_disponible_producto);
            Console.WriteLine("Precio de Compra\n" + precio_compra);
            Console.WriteLine("Precio de Venta\n" + precio_venta);
            Console.WriteLine("Codio en Almacen\n" + codigo_almacen);
            Console.WriteLine("Proveedor\n" + proveedor);
            Console.WriteLine("Localidad\n" + localidad);
        }

        public void Ingreso_sistema ()
        {
            Console.WriteLine("Ingresar Producto");
            Nombre_producto = Console.ReadLine();
            Console.WriteLine("Codigo Nuevo Producto");
            Codigo_producto = Console.ReadLine();
        }
     }

    public class Producto : Inventario
    {
        private string tipo_producto;
        private string precio_producto = String.Format("{0:(###) ###-####}", 8005);
        private Inventario inventario;

        public string Tipo_producto { get => tipo_producto; set => tipo_producto = value; }
        public string Precio_producto { get => precio_producto; set => precio_producto = value; }

        public Producto()
        {
            tipo_producto = "";
            Precio_producto = "";
        }

        public void Ingresar()
        {
            Console.WriteLine("Ingrese Tipo de Producto");
            tipo_producto = Console.ReadLine();
            Console.WriteLine("Ingrese Precio Producto");
            Precio_producto = Console.ReadLine();
        }

        public void Visualizar()
        {
            Console.WriteLine("Precio Producto\n" + Nombre_producto);
            Console.WriteLine("Precio Producto\n" + Codigo_producto);
            Console.WriteLine("Tipo de Producto\n" + tipo_producto);
            Console.WriteLine("Precio Producto\n" + Precio_producto);
            
        }

        public class Ventas : Inventario
        {
            private string compra;

            internal Inventario Inventario { get => inventario; set => inventario = value; }
            public string Compra { get => compra1; set => compra1 = value; }
            private string compra1 = String.Format("{0:(###) ###-####}", 8005);
            private Vendedor GetVendedor;
            private Inventario inventario;
            private Vendedor vendedor;
            private Producto Producto;
            private string Precio_producto;

            public Ventas()
            {
                Compra = "";
            }

            public void PreVenta()
            {
                Console.WriteLine("Ingrese Producto a Vender");
                 Compra= Console.ReadLine();
                 Compra = Codigo_producto;
             
            }

            public void Producto_Vendido()
            {
                Console.WriteLine("Factura Final\n" + vendedor + Codigo_producto + Nombre_producto + Precio_producto + Cantidad_disponible_producto);
            }


        }

        public class Vendedor: Ventas
        {
            private string codigo_vendedor = String.Format("{0:(###) ###-####}", 8005);
            public string Codigo_vendedor { get => codigo_vendedor; set => codigo_vendedor = value; }
            private Empleado Empleado { get => empleado; set => empleado = value; }
            private Empleado empleado;

            public Vendedor()
            {
                Codigo_vendedor = "";
            }

            public void Factura()
            {
                Console.WriteLine("Codigo Vendedor");
                Codigo_vendedor = Console.ReadLine();
            }

        }

        public class Empleado: Vendedor
        {
            private string nombre_apellido;
            private string telefono = String.Format("{0:(###) ###-####}", 8005551212);
            private string salario = String.Format("{0:(###) ###-####}", 8005551212);
            private string direccion = String.Format("{0:(###) ###-####}", 80);
            private string area;
            private Vendedor Vendedor;
            

            public string Nombre_apellido { get => nombre_apellido; set => nombre_apellido = value; }
            public string Telefono { get => telefono; set => telefono = value; }
            public string Salario { get => salario; set => salario = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public string Area { get => area; set => area = value; }

            public Empleado()
            {
                nombre_apellido = "";
                Telefono = "";
                Salario = "";
                Direccion = "";
                Area = "";

            }

            //metodos
            public void Leer()
            {
                Console.WriteLine("Ingrese Nombre y Apellido");
                nombre_apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Telefono");
                Telefono = Console.ReadLine();
                Console.WriteLine("Ingrese Salario");
                Salario = Console.ReadLine();
                Console.WriteLine("Ingrese Cargo");
                Direccion = Console.ReadLine();
                Console.WriteLine("Ingrese Cargo");
                Area = Console.ReadLine();

            }

            public void Mostrar() 
            {
                Console.WriteLine("Nombre Empleado\n" + Codigo_vendedor + nombre_apellido);
                Console.WriteLine("Numero de Contacto\n" + Telefono);
                Console.WriteLine("Pago Salarial\n" + Salario);
                Console.WriteLine("Puesto en la Empresa\n" + Direccion);
                Console.WriteLine("Codigo Empleado\n" + Area);

            }

        }

    }







}
