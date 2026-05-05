using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoComposicao
{
    internal class Dependente  ///simboliza os filhos =dependente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependente(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
