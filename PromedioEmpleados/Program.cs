//Jhonatan Fernandez
//Grupo: 213022_15  
//Programa Ing. Sistemas
//Código Fuente: autoría propia

using System;
using System.Linq;


namespace Paso4
{
	class Program
	{
		static void Main()
		{
			Operaciones operaciones = new Operaciones();
			operaciones.definirCantidadEmpleados();
			operaciones.ingresarEmpleados();
			float promedioEdadEmpleados = operaciones.calcularPromedio();
			Console.WriteLine("La edad promedio de sus empleados es " + promedioEdadEmpleados);
		}
	}

	class Operaciones
	{
		public int cantidadEmpleados;
		List<int> empleados = new List<int>();


		public void definirCantidadEmpleados()
		{
			Console.WriteLine("Por favor digite el número de empleados a procesar ");
			cantidadEmpleados = int.Parse(Console.ReadLine());

			Console.WriteLine("Usted va a procesar la edad de: " + cantidadEmpleados + " empleados");
		}

		public void ingresarEmpleados()
		{			
			for (int i = 0; i < cantidadEmpleados; i++)
			{
				Console.WriteLine("Por favor ingrese la edad de su " + (i + 1) + " empleado");
				int empleado = int.Parse(Console.ReadLine());
				empleados.Add(empleado);
			}
		}

		public float calcularPromedio()
		{
			float result = 0.0f;

			for (int i = 0; i < cantidadEmpleados; ++i)
			{
				result = result + empleados[i];
			}
			result = result / cantidadEmpleados;
			return result;
		}
	}
}