using System;

namespace Atividade1POO
{
    class Program
    {


        static void Main(string[] args)
        {
            Banco zueira = new Banco("Zueira");
            Agencia um = new Agencia("um");
            Agencia dois = new Agencia("dois");
            Agencia tres = new Agencia("tres");

            //ADICIONANDO AS AGENCIAS NO BANCO
            zueira.AdicionarAgencia(um);
            zueira.AdicionarAgencia(dois);
            zueira.AdicionarAgencia(tres);

            //ADICIONANDO CLIENTES NAS AGENCIAS
            ContaCorrente pessoa1 = new ContaCorrente("João");
            ContaPoupanca pessoa2 = new ContaPoupanca(100, DateTime.Now, "Maria");
            ContaCorrente pessoa3 = new ContaCorrente("Carlos");
            ContaPoupanca pessoa4 = new ContaPoupanca(100, DateTime.Now, "Julia");
            ContaCorrente pessoa5 = new ContaCorrente("Mateus");
            ContaPoupanca pessoa6 = new ContaPoupanca(100, DateTime.Now, "Ana");

            //DEPOSITANDO DINHEIRO PARA TESTES
            pessoa1.Depositar(100);
            pessoa2.Depositar(150);
            pessoa3.Depositar(200);
            pessoa4.Depositar(250);
            pessoa5.Depositar(300);
            pessoa6.Depositar(350);
            //ADICIONANDO CLIENTES NAS AGÊNCIAS
            um.AdicionarContaCorrente(pessoa1);
            um.AdicionarContaPoupanca(pessoa2);
            dois.AdicionarContaCorrente(pessoa3);
            dois.AdicionarContaPoupanca(pessoa4);
            tres.AdicionarContaCorrente(pessoa5);
            tres.AdicionarContaPoupanca(pessoa6);

            //INICIANDO INTERFACE DO CLIENTE
            int opcao = 1, redundancia = 0;
            while (opcao != 0)
            {
                Console.WriteLine("BEM VINDO AO BANCO DA ZUEIRA");
                Console.WriteLine("MENU: ----- DIGITE:");
                Console.WriteLine("Abrir Conta ------1");
                Console.WriteLine("Fechar Conta -----2");
                Console.WriteLine("Consultar Saldo---3");
                Console.WriteLine("Depositar Saldo---4");
                Console.WriteLine("Sacar Saldo ------5");
                Console.WriteLine("Transferir Saldo--6");
                Console.WriteLine("Para sair --------0");

                opcao = Int32.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("Banco zueira sempre Seu dispor");
                    return;
                }
                else if (opcao == 1)
                {
                    //ABRINDO CONTA
                    Console.Clear();
                    int aux;
                    string nomeAgencia;
                    Agencia novaconta;
                    Console.WriteLine("Abrindo Conta");
                    Console.WriteLine("Listas de Agências Disponíveis");
                    zueira.ListarAgencia();
                    Console.WriteLine("Digite o Nome da Agencia que deseja abrir uma conta:\n");
                    nomeAgencia = Console.ReadLine();
                    Console.Clear();
                    novaconta = zueira.BuscarAgencia(nomeAgencia);

                    if (novaconta == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    //DEFININDO TIPO DE CONTA
                    Console.WriteLine("Para conta Poupança Digite 1");
                    Console.WriteLine("Para conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        //Conta Poupança

                        string nome;
                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        ContaPoupanca nova = new ContaPoupanca(100, DateTime.Now, nome);
                        novaconta.AdicionarContaPoupanca(nova);
                        Console.Clear();
                        Console.WriteLine("Parabéns " + nome + " Você agora é um Cliente do Banco Zueira");
                        Console.ReadKey();
                        continue;
                    }
                    else if (aux == 2)
                    {
                        //Conta Corrente
                        string nome;

                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        ContaCorrente nova = new ContaCorrente(nome);
                        novaconta.AdicionarContaCorrente(nova);
                        Console.Clear();
                        Console.WriteLine("Parabéns " + nome + " Você agora é um Cliente do Banco Zueira");
                        Console.ReadKey();
                        continue;
                    }


                }
                else if (opcao == 2)
                {
                    //FECHANDO CONTA
                    Console.Clear();
                    int aux;
                    string nomeAgencia;
                    Agencia excluirconta;
                    Console.WriteLine("Fechando Conta");
                    Console.WriteLine("Listas de Agências Disponíveis");
                    zueira.ListarAgencia();
                    Console.WriteLine("Digite o Nome da Agencia que sua conta é cadastrada:\n");
                    nomeAgencia = Console.ReadLine();
                    Console.Clear();
                    excluirconta = zueira.BuscarAgencia(nomeAgencia);

                    if (excluirconta == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    //DEFININDO TIPO DE CONTA
                    Console.WriteLine("Para conta Poupança Digite 1");
                    Console.WriteLine("Para conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        //Conta Poupança

                        string nome;
                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        excluirconta.ExcluircontaP(nome);
                        Console.ReadKey();
                        continue;
                    }
                    else if (aux == 2)
                    {
                        //Conta Corrente
                        string nome;
                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        excluirconta.Excluirconta(nome);
                        Console.ReadKey();
                        continue;

                    }


                }
                else if (opcao == 3)
                {
                    //CONSULTANDO SALDO
                    Console.Clear();
                    Console.WriteLine("CONSULTANDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia consultarsaldo;
                    Console.WriteLine("Listas de Agências");
                    zueira.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    consultarsaldo = zueira.BuscarAgencia(nomeAgencia);
                    if (consultarsaldo == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Consultar Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Consultar Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        //CONSULTANDO SALDO CONTA POUPANÇA
                        ContaPoupanca consultar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        consultar = consultarsaldo.BuscarClienteP(cliente);
                        if (consultar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Seu Saldo é: " + consultar.Saldo);
                            Console.ReadKey();
                        }

                    }
                    if (aux == 2)
                    {
                        //CONSULTANDO SALDO CONTA POUPANÇA
                        ContaCorrente consultar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        consultar = consultarsaldo.BuscarCliente(cliente);
                        if (consultar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Seu Saldo é: " + consultar.Saldo);
                            Console.ReadKey();
                        }

                    }

                }
                else if (opcao == 4)
                {
                    //DEPOSITAR SALDO
                    Console.Clear();
                    Console.WriteLine("DEPOSINTANDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia depositandosaldo;
                    Console.WriteLine("Listas de Agências");
                    zueira.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    depositandosaldo = zueira.BuscarAgencia(nomeAgencia);
                    if (depositandosaldo == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Consultar Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Consultar Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        //DEPOSITANDO SALDO CONTA POUPANÇA
                        ContaPoupanca depositar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        depositar = depositandosaldo.BuscarClienteP(cliente);
                        if (depositar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            depositar.Depositar(valor);
                            Console.WriteLine(valor + " Foi depositado com Sucesso na conta do Sr " + depositar.Titular);
                            Console.ReadKey();
                            continue;
                        }

                    }
                    if (aux == 2)
                    {
                        ContaCorrente depositar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        depositar = depositandosaldo.BuscarCliente(cliente);
                        if (depositar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            depositar.Depositar(valor);
                            Console.WriteLine(valor + " Foi depositado com Sucesso na conta do Sr" + depositar.Titular);
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (opcao == 5)
                {
                    //SACAR SALDO
                    Console.Clear();
                    Console.WriteLine("SACANDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia sacandosaldo;
                    Console.WriteLine("Listas de Agências");
                    zueira.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    sacandosaldo = zueira.BuscarAgencia(nomeAgencia);
                    if (sacandosaldo == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Sacar Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Sacar Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        //DEPOSITANDO SALDO CONTA POUPANÇA
                        ContaPoupanca sacar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        sacar = sacandosaldo.BuscarClienteP(cliente);
                        if (sacar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            sacar.Sacar(valor);
                            Console.WriteLine(valor + " Foi sacado com Sucesso da conta do Sr " + sacar.Titular);
                            Console.ReadKey();
                            continue;
                        }

                    }
                    if (aux == 2)
                    {
                        ContaCorrente sacar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        sacar = sacandosaldo.BuscarCliente(cliente);
                        if (sacar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            sacar.Sacar(valor);
                            Console.WriteLine(valor + " Foi sacado com Sucesso da conta do Sr" + sacar.Titular);
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (opcao == 6)
                {
                    //TRANSFERINDO SALDO
                    Console.WriteLine("TRANSFERINDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia trasnferir;
                    Console.WriteLine("Listas de Agências");
                    zueira.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    trasnferir = zueira.BuscarAgencia(nomeAgencia);
                    if (trasnferir == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Trasferir Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Transferir Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        //CONSULTANDO SALDO CONTA POUPANÇA
                        ContaPoupanca trasferirP;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        trasferirP = trasnferir.BuscarClienteP(cliente);
                        if (trasferirP == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor a Ser tranferido: ");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            //Buscando Conta para fazer tranferência
                            Console.Clear();
                            Console.WriteLine("BUSCANDO CONTA A TRANSFERIR DINHEIRO");
                            Agencia trasnferir2;
                            Console.WriteLine("Listas de Agências");
                            zueira.ListarAgencia();
                            Console.WriteLine("Digite o Nome da sua Agencia");
                            nomeAgencia = Console.ReadLine();
                            trasnferir2 = zueira.BuscarAgencia(nomeAgencia);
                            if (trasnferir2 == null)
                            {
                                Console.WriteLine("Voltando Para o menu inicial");
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Para Trasferir Saldo para conta Poupança Digite 1");
                            Console.WriteLine("Para Transferir Saldo para conta Corrente Digite 2");
                            aux = Int32.Parse(Console.ReadLine());
                            if (aux == 1)
                            {
                                ContaPoupanca receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarClienteP(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                //FAZENDO A TRANSFERÊNCIA
                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta do Sr(a) " + trasferirP.Titular + " e " + valor + "Foi depositado na conta do Sr(a) " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else if (aux == 2)
                            {
                                ContaCorrente receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarCliente(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                //FAZENDO A TRANSFERÊNCIA
                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta do Sr(a) " + trasferirP.Titular + " e " + valor + "Foi depositado na conta do Sr(a) " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.WriteLine("Voltando ao menu iniciar");
                                Console.ReadKey();
                                continue;
                            }

                        }

                    }
                    if (aux == 2)
                    {
                        //CONSULTANDO SALDO CONTA CORRENTE
                        ContaCorrente trasferirP;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        trasferirP = trasnferir.BuscarCliente(cliente);
                        if (trasferirP == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor a Ser tranferido: ");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            //Buscando Conta para fazer tranferência
                            Console.Clear();
                            Console.WriteLine("BUSCANDO CONTA A TRANSFERIR DINHEIRO");
                            Agencia trasnferir2;
                            Console.WriteLine("Listas de Agências");
                            zueira.ListarAgencia();
                            Console.WriteLine("Digite o Nome da sua Agencia");
                            nomeAgencia = Console.ReadLine();
                            trasnferir2 = zueira.BuscarAgencia(nomeAgencia);
                            if (trasnferir2 == null)
                            {
                                Console.WriteLine("Voltando Para o menu inicial");
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Para Trasferir Saldo para conta Poupança Digite 1");
                            Console.WriteLine("Para Transferir Saldo para conta Corrente Digite 2");
                            aux = Int32.Parse(Console.ReadLine());
                            if (aux == 1)
                            {
                                ContaPoupanca receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarClienteP(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                //FAZENDO A TRANSFERÊNCIA
                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta do Sr(a) " + trasferirP.Titular + " e " + valor + "Foi depositado na conta do Sr(a) " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else if (aux == 2)
                            {
                                ContaCorrente receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarCliente(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                //FAZENDO A TRANSFERÊNCIA
                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta do Sr(a) " + trasferirP.Titular + " e " + valor + "Foi depositado na conta do Sr(a) " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }    
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.WriteLine("Voltando ao menu iniciar");
                                Console.ReadKey();
                                continue;
                            }
                        }

                    }
                }
            }
        }
    }
}