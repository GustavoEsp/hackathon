/*
 * Criado por SharpDevelop.
 * Usuário: Família
 * Data: 13/11/2021
 * Hora: 17:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;

namespace imc
{
	class Program
	{
		public static void Main(string[] args)
		{
			float imc = 0;
			Console.WriteLine("---");
			Console.WriteLine("Imc");
			Console.WriteLine("---");			
			
			try{
				Console.Write("Insira sua Altura: [x.xx]");
				float altura = float.Parse(Console.ReadLine());
				
				Console.Write("Insira seu peso: [xx.x] ");
				float peso = float.Parse(Console.ReadLine());
				
				imc = peso / (altura*2);
				
				Console.WriteLine("--------------------------------");	
				Console.WriteLine("- Imc: "+ imc.ToString("F"));
				
				if(imc < 16){
					Console.WriteLine("- Magreza grave");	
				}
				else if(imc > 16 && imc < 17){
					Console.WriteLine("- Magreza moderada");
				}
				else if(imc > 16 && imc < 17){
					Console.WriteLine("- Magreza leve");
				}
				else if(imc >= 18.5 && imc < 25){
					Console.WriteLine("- Saudável");
				}
				else if(imc > 25 && imc < 30){
					Console.WriteLine("- Sobrepeso");
				}
				else if(imc > 30 && imc < 35){
					Console.WriteLine("- Obesidade grau 1");
				}
				else if(imc > 35 && imc < 40){
					Console.WriteLine("- Obesidade grau 2 (severa)");
				}
				else if(imc >= 40){
					Console.WriteLine("- Obesidade grau 3 (mórbida)");
				}
				Console.WriteLine("--------------------------------");	
				
				Console.Write("\nAperte qualquer tecla para fechar. . . ");
				Console.ReadKey(true);
			}
			
			catch{
				Console.WriteLine("Valores inválidos");
				Console.Write("\nAperte qualquer tecla para fechar. . . ");
				Console.ReadKey(true);
			}
			
			
		}
	}
}