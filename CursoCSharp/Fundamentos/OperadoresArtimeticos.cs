﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresArtimeticos {
        public static void Executar() {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço final é {totalComDesconto}");

            // IMC
            double peso = 60;
            double altura = 1.73;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");

            //Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
