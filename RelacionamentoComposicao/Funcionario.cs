using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RelacionamentoComposicao
{
    internal class Funcionario
    {
        public string Nome  { get; set; }

        //Composição: o funcionário é o "dono" dos dependentes

        private List<Dependente> dependentes;

        //Diferente da agregação, aqui a lista é private.
        //Isso garante que ninguém fora da classe Funcionario consiga manipular os dependentes diretamente.
        //O controlo é exclusivo do "dono".

        public Funcionario(string nome)
        {
            Nome = nome;

            //criação interna da lista de dependentes (controlo do ciclo de vida)
            //Este código exemplifica a Composição, onde o Funcionario(o "todo")
            //controla totalmente a existência dos Dependentes(as "partes").

            dependentes = new List<Dependente>();
        }

        //Método para adicionar dependente
        public void AdicionarDependente (string nome,int idade)
        {
            //o cuncionario cria o dependente
            Dependente d = new Dependente(nome, idade);
            dependentes.Add(d);
        }
        public void ListarDependentes()
        {
            Console.WriteLine($"Dependentes de {Nome}");
            foreach(Dependente d in dependentes)
            {
                Console.WriteLine($"-{d.Nome}, {d.Idade} anos");
            }
        }
    }
}
