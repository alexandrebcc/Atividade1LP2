using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    public class Agencia
    {
        string Nome;
        List<ContaCorrente> contasCorrentes = new List<ContaCorrente>();
        List<ContaPoupanca> contasPoupancas = new List<ContaPoupanca>();


        public Agencia(string nome)
        {
            Nome = nome;
        }
        public string nome
        {
            get{return Nome;}
        }
        public void AdicionarContaCorrente(ContaCorrente add)
        {
            contasCorrentes.Add(add);
        }
        public void AdicionarContaPoupanca(ContaPoupanca add)
        {
            contasPoupancas.Add(add);
        }
        public ContaCorrente BuscarCliente(string identificador)
        {
            ContaCorrente busca = new ContaCorrente("ds");

            for (int a = 0; a < contasCorrentes.Count; a++)
            {
                busca = contasCorrentes[a];
                if (busca.Titular.Equals(identificador))
                    return busca;
            }
            Console.WriteLine("Conta Não Identificada");
            return null;
        }
        public ContaPoupanca BuscarClienteP(string identificador)
        {
            ContaPoupanca busca = new ContaPoupanca(10,DateTime.Now,"s");

            for (int a = 0; a < contasPoupancas.Count; a++)
            {
                busca = contasPoupancas[a];
                if (busca.Titular.Equals(identificador))
                    return busca;
            }
            Console.WriteLine("Conta Não Identificada");
            return null;
        }
       public void Excluirconta(string nome)
        {
            ContaCorrente excluir;
            for (int a = 0; a<contasCorrentes.Count;a++)
            {
                excluir = contasCorrentes[a];
                if(excluir.Titular.Equals(nome))
                {
                    contasCorrentes.Remove(excluir);
                    Console.WriteLine("A conta do Sr(a) " + nome + " Foi removida com Sucesso");
                    return;
                }
            }
            Console.WriteLine("Conta Não encontrada");
            return;
        }
        public void ExcluircontaP(string nome)
        {
            ContaPoupanca excluir;
            for (int a = 0; a < contasPoupancas.Count; a++)
            {
                excluir = contasPoupancas[a];
                if (excluir.Titular.Equals(nome))
                {
                    contasPoupancas.Remove(excluir);
                    Console.WriteLine("A conta do Sr(a) " + nome + " Foi removida com Sucesso");
                    return;
                }
            }
            Console.WriteLine("Conta Não encontrada");
            return;
        }
    }
}
