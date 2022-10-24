using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo.Metodos
{
    /// <summary>
    /// Somar(param1, param2) e Somar(param1, param2, param3)
    /// estes dois métodos caracterizam uma sobrecarga
    /// </summary>
    public class Calculadora
    {
        public static decimal Somar(decimal valorUm,
            decimal valorDois)
        {
            return valorUm + valorDois;
        }

        //não é possivel trocar o tipo de retorno de um método
        //ao criar uma sobrecarga
        //public static void Somar(decimal valorUm, decimal valorDois)
        //{

        //}

        public static decimal Somar(decimal valorUm,
            decimal valorDois, decimal valorTres)
        {
            decimal resultado = valorUm + valorDois + valorTres;

            return resultado;
        }

        //metodo com parâmetro valorTres não obrigatorio
        public static decimal Subtrair(decimal valorUm,
            decimal valorDois, decimal valorTres = 0.0m)
        {
            if (valorUm <= 0.00m)
                throw new ArgumentException("Variavel valorUm inválida!");

            decimal resultado = valorUm - valorDois - valorTres;

            return resultado;
        }
    }
}