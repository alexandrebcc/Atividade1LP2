using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    public class Banco
    {
        private string nome;
        List<Agencia> Agencias = new List<Agencia>();

        public Banco(string t)
        {
            nome = t;
        }

        public void AdicionarAgencia(Agencia add)
        {
            Agencias.Add(add);
        }
        public void ListarAgencia()
        {
            Agencia auxiliar;
             for (int a = 0; a<Agencias.Count; a++)
            {
                auxiliar = Agencias[a];
                Console.WriteLine("Agencia: " + auxiliar.nome);
            }
            return;
        }
        public Agencia BuscarAgencia(string identificador)
        {
            Agencia busca;

            for (int a = 0; a < Agencias.Count; a++)
            {
                busca = Agencias[a];
                if (busca.nome.Equals(identificador))
                    return busca;
            }
            Console.WriteLine("Agência Não Identificada");
            return null;
        }
    }
}
