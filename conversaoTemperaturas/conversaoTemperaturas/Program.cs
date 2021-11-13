/*
 * Criado por SharpDevelop.
 * Usuário: Família
 * Data: 13/11/2021
 * Hora: 17:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace conversaoTemperaturas
{
	class Program
	{
		public static void Main(string[] args)
		{
			int escolha;
			Console.WriteLine("Conversão de temperaturas");
			Console.WriteLine("---------------------------");
			
			Console.Write("1) Celcius para fahrenheit \n2) Celsius para Kelvin " +
			                  "\n3) Fahrenheit para Kelvin \n4) Fahrenheit para Celcius" +
			                  "\n5) Kelvin para celsius \n6)Kelvin para Fahrenheit \n>"
			              );
			escolha = int.Parse(Console.ReadLine());
			
			switch(escolha){
				case 1:
					CpF();
					break;
				case 2:
					CpK();
					break;
				case 3:
					FpK();
					break;
				case 4:
					FpC();
					break;
				case 5:
					KpC();
					break;
				case 6:
					KpF();
					break;
			}
			
			Console.Write("\nAperte qualquer tecla para fechar. . . ");
			Console.ReadKey(true);
		}
		
		public static void CpF()
		{
			double celsius, fahrenheit;
			
			Console.WriteLine("------------------------");
			Console.WriteLine("Celsius para Fahrenheit");
			Console.WriteLine("------------------------");			
			
			Console.Write("Temperatura em Celsius: ");
			celsius = double.Parse(Console.ReadLine());
			
			fahrenheit = celsius * 1.8 + 32;
			Console.WriteLine("[-] Resultado: " +celsius + "C° = " + fahrenheit + "F°");
		}
		
		public static void CpK()
		{
			double celsius, kelvin;
			
			Console.WriteLine("------------------------");
			Console.WriteLine("Celsius para Kelvin");
			Console.WriteLine("------------------------");			
			
			Console.Write("Temperatura em Celsius: ");
			celsius = double.Parse(Console.ReadLine());
			
			kelvin = celsius + 273;
			Console.WriteLine("[-] Resultado: " + celsius + "C° = " + kelvin + "K°");
		}
		public static void FpK()
		{
			double fahrenheit, kelvin;
			
			Console.WriteLine("------------------------");
			Console.WriteLine("Fahrenheit para Kelvin");
			Console.WriteLine("------------------------");			
			
			Console.Write("Temperatura em Fahrenheit: ");
			fahrenheit = double.Parse(Console.ReadLine());
			
			kelvin = (fahrenheit - 32) * 5/9 + 273;
			Console.WriteLine("[-] Resultado: " + fahrenheit + "F° = " + kelvin + "K°");
		}
		public static void FpC()
		{
			double fahrenheit, celsius;
			
			Console.WriteLine("------------------------");
			Console.WriteLine("Fahrenheit para Celsius");
			Console.WriteLine("------------------------");			
			
			Console.Write("Temperatura em Fahrenheit: ");
			fahrenheit = double.Parse(Console.ReadLine());
			
			celsius = (fahrenheit - 32) / 1.8;
			Console.WriteLine("[-] Resultado: " + fahrenheit + "F° = " + celsius + "C°");
		}
		public static void KpC()
		{
			double celsius, kelvin;
			
			Console.WriteLine("------------------------");
			Console.WriteLine("Kelvin para Celsius");
			Console.WriteLine("------------------------");			
			
			Console.Write("Temperatura em Kelvin: ");
			kelvin = double.Parse(Console.ReadLine());
			
			celsius = kelvin - 273;
			Console.WriteLine("[-] Resultado: " + kelvin + "K° = " + celsius + "C°");
		}
		public static void KpF()
		{
			double fahrenheit, kelvin;
			
			Console.WriteLine("------------------------");
			Console.WriteLine("Kelvin para Fahrenheit");
			Console.WriteLine("------------------------");			
			
			Console.Write("Temperatura em Kelvin: ");
			kelvin = double.Parse(Console.ReadLine());
			
			fahrenheit = (kelvin - 273) * 1.8 + 32;
			Console.WriteLine("[-] Resultado: " + kelvin + "K° = " + fahrenheit + "F°");
		}
	}
}