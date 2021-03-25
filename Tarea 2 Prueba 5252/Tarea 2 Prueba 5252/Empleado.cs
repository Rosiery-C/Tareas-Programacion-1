using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_2_Prueba_5252
{
    public class Empleado

    {   //atributos clase

        public string nombre_apellido { set; get; }
        public string Telefono { get => telefono; set => telefono = value; }
        private string telefono = String.Format("{0:(###) ###-####}", 8005551212);
        private string salario = String.Format("{0:(###) ###-####}", 8005551212);
        public string cargo { set; get; }
        public string Salario { get => salario; set => salario = value; }
        public string Codigo_empleado { get => codigo_empleado; set => codigo_empleado = value; }
        private string codigo_empleado = String.Format("{0:(###) ###-####}", 80055);

        // constructor
        public Empleado()
        {
            Codigo_empleado = "";
            nombre_apellido = "";
            Telefono = "";
            Salario = "";
            cargo = "";

        }

        //metodos
        public void leer()
        {
            Console.WriteLine("Ingrese Codigo Empleado");
            Codigo_empleado = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre y Apellido");
            nombre_apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Telefono");
            Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese Salario");
            Salario = Console.ReadLine();
            Console.WriteLine("Ingrese Cargo");
            cargo = Console.ReadLine();

        }

        public void mostrar()
        {
            Console.WriteLine("Codigo Empleado" + Codigo_empleado);
            Console.WriteLine("Nombre Empleado" + nombre_apellido);
            Console.WriteLine("Numero de Contacto" + Telefono);
            Console.WriteLine("Pago Salarial" + Salario);
            Console.WriteLine("Puesto en la Empresa" + cargo);

        }

    }

    public class Producto : Empleado

    { //atributos

        private string codigo_producto = String.Format("{0:(###) ###-####}", 8005);
        public string nombre_producto { set; get; }
        public string tipo_producto { set; get; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Precio_producto { get => precio_producto; set => precio_producto = value; }
        private string precio_producto = String.Format("{0:(###) ###-####}", 8005551212);

        //constructor
        public Producto()
        {
            Codigo_producto = "";
            nombre_producto = "";
            tipo_producto = "";
            Precio_producto = "";

        }

        public void ingresar()
        {
            Console.WriteLine("Ingrese Codigo Producto");
            Codigo_producto = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre Producto");
            nombre_producto = Console.ReadLine();
            Console.WriteLine("Ingrese Tipo de Producto");
            tipo_producto = Console.ReadLine();
            Console.WriteLine("Ingrese Precio Producto");
            Precio_producto = Console.ReadLine();


        }

        public void visualizar()
        {
            Console.WriteLine("Codigo Producto" + Codigo_producto);
            Console.WriteLine("Nombre Producto" + nombre_producto);
            Console.WriteLine("Tipo de Producto" + tipo_producto);
            Console.WriteLine("Precio Producto" + Precio_producto);

        }
    }

    public class Inventario : Empleado
    {
        //atributos

        private string precio_compra = String.Format("{0:(###) ###-####}", 8005551212);
        private string precio_venta = String.Format("{0:(###) ###-####}", 8005551212);
        public string proveedor { set; get; }
        public string localidad { set; get; }
        public string Precio_compra { get => precio_compra; set => precio_compra = value; }
        public string Cantidad_disponible { get => cantidad_disponible; set => cantidad_disponible = value; }
        public string Precio_venta { get => precio_venta; set => precio_venta = value; }
        private string cantidad_disponible = String.Format("{0:(###) ###-####}", 8005551212);

        //constructor
        public Inventario()
        {
            Precio_compra = "";
            Precio_venta = "";
            proveedor = "";
            localidad = "";
            Cantidad_disponible = "";

        }

        public void administrar()
        {
            Console.WriteLine("Ingrese Precio Compra");
            Precio_compra = Console.ReadLine();
            Console.WriteLine("Ingrese Precio Venta");
            Precio_venta = Console.ReadLine();
            Console.WriteLine("Ingrese Proveedor");
            proveedor = Console.ReadLine();
            Console.WriteLine("Ingrese Localidad");
            localidad = Console.ReadLine();
            Console.WriteLine("Ingrese Cantidad en Inventario");
            Cantidad_disponible = Console.ReadLine();


        }

        public void consultar()
        {
            Console.WriteLine("Precio Compra" + Precio_compra);
            Console.WriteLine("Precio Venta" + Precio_venta);
            Console.WriteLine("Proveedor " + proveedor);
            Console.WriteLine("Localidad" + localidad);
            Console.WriteLine("Disponible en Inventario" + Cantidad_disponible);

        }

    }

    public class Ventas: Empleado
    {
        //atributos y campos de clases 
        public string producto { set; get; }
        public Empleado empleado;
        public Inventario inventario;
        internal Empleado Empleado { get => Empleado; set => Empleado = value; }
        internal Inventario Inventario { get => Inventario; set => Inventario = value; }
        public string Cantidad_disponible { get; private set; }

        //constructor
        public Ventas()
        {
            producto = "";
            Empleado = Empleado;
            Inventario = Inventario; 
            
        }

        public void preVenta()
        {
            Console.WriteLine("Ingrese Producto a Vender");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese Codigo Empleado");
            Empleado.Codigo_empleado = Console.ReadLine();
            Console.WriteLine("Ingrese Producto a Vender");
            Inventario.Cantidad_disponible = Console.ReadLine();
        }

        public void producto_Vendido()
        {
            Console.WriteLine("Precio Compra" + producto);
            Console.WriteLine("Precio Venta" + Codigo_empleado);
            Console.WriteLine("Proveedor " + Cantidad_disponible);
           

        }

    }
}
