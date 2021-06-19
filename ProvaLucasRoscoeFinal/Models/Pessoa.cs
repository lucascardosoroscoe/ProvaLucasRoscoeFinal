using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pessoa
{
    public interface IVerificaIdade
    {
        string VerificaIdade(Pessoa p);
    }

    public class Pessoa : IVerificaIdade
    {
        public string ePrimo { get; set; }
        public int idade { get; set; }

        public string VerificaIdade(Pessoa p)
        {
            try
            {
                for (int i = 2; i < p.idade; i++)
                {
                    int resto = p.idade % i;
                    if (resto == 0)
                    {
                        p.ePrimo = p.idade + " não é um número primo";
                        i = p.idade;
                    }
                    else
                    {
                        p.ePrimo = p.idade + " é um número primo";
                    }
                }
            }
            catch (Exception e)
            {
                ePrimo = "Erro ao Verificar nº primo";
            }
            return p.ePrimo;
        }
    }
}