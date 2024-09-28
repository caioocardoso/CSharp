using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // TIPOS INTERNOS

            bool estachovendo = true;
            Console.WriteLine("Está chovendo " + estachovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Basileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("populacao Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("preco Computador " + precoComputador);

            double valorDeMercadoApple = 1000000000000.00; // Mais usado dos reais!!
            Console.WriteLine("valor Apple " + valorDeMercadoApple);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string texto = "texto legal heheeee";
            Console.WriteLine(texto);
        }
    }
}
