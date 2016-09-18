using System;


namespace RMMSA.PadroesProjeto.Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var Calc = new Calculadora();

            int x = 10;
            int y = 20;
            int r1 = Calc.Somar (x, y);

            int v1 = 56;
            int v2 = 90;
            int r2 = Calc.Somar(v1, v2);

            Console.WriteLine("A soma de x e y é : " + r1);
            Console.WriteLine("A soma de x e y é : " + r2);
            Console.ReadLine();
        }

      
    }
}
