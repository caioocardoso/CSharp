using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativa = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativa); // (-) inverte a positividade
            Console.WriteLine(!booleano); // inverte se é verdadeiro pra falso e vice-versa

            num1++;
            Console.WriteLine(num1);

            --num1;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2); // baguio ruim de ler, melhore isso na hora
            Console.WriteLine($"{num1} e {num2}");
        }
    }
}
