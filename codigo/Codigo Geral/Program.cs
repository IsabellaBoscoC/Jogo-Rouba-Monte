using System;
using System.Collections.Generic; //Usar colleções


//CLASSES ******************************

//Classe para criar um baralho
class Carta // o baralho sera uma lista/vetor
{
    //Cada baralho tem 13*4 = 52 cartas (13 cartas com 4 naipes. 13*4 = 52 cartas)
    public string numCarta;
    public string naipeCarta;
    public List<Carta> Baralho = new List<Carta>();//Instanciando Lista para criar baralho com o numero de cartas pedido 

    public Carta() //Construtor
    {
        numCarta = " ";
        naipeCarta = " ";
    }

    public Carta(string num, string naipe) //Construtor
    {
        numCarta = num;
        naipeCarta = naipe;
    }

    public List<Carta> CriarBaralho(int quantidadeBaralhos)
    {
        int quantCartas = 0;

        if (quantidadeBaralhos == 0)
        {
            Console.WriteLine("A quantidade deve ser maior que (0)!");
            return null!;

        }
        else
        {
            int j = 0;

            while (j < quantidadeBaralhos) // enquanto for menor q o n de baralho escolhido
            {
                naipeCarta = "Copas";

                for (int i = 1; i <= 13; i++)
                {
                    if (i == 1)
                    {
                        numCarta = "A";
                    }
                    else if (i >= 2 && i <= 9)
                    {
                        numCarta = i.ToString(); // Converte o valor de i para string
                    }
                    else if (i == 10)
                    {
                        numCarta = "10";
                    }
                    else if (i == 11)
                    {
                        numCarta = "J";
                    }
                    else if (i == 12)
                    {
                        numCarta = "Q";
                    }
                    else if (i == 13)
                    {
                        numCarta = "K";
                    }

                    Carta carta1 = new Carta(numCarta, naipeCarta);
                    Baralho.Add(carta1);
                }

                naipeCarta = "Espadas";

                for (int i = 1; i <= 13; i++)
                {
                    if (i == 1)
                    {
                        numCarta = "A";
                    }
                    else if (i >= 2 && i <= 9)
                    {
                        numCarta = i.ToString(); // Converte o valor de i para string
                    }
                    else if (i == 10)
                    {
                        numCarta = "10";
                    }
                    else if (i == 11)
                    {
                        numCarta = "J";
                    }
                    else if (i == 12)
                    {
                        numCarta = "Q";
                    }
                    else if (i == 13)
                    {
                        numCarta = "K";
                    }

                    Carta carta1 = new Carta(numCarta, naipeCarta);
                    Baralho.Add(carta1);
                }

                naipeCarta = "Ouros";

                for (int i = 1; i <= 13; i++)
                {
                    if (i == 1)
                    {
                        numCarta = "A";
                    }
                    else if (i >= 2 && i <= 9)
                    {
                        numCarta = i.ToString(); // Converte o valor de i para string
                    }
                    else if (i == 10)
                    {
                        numCarta = "10";
                    }
                    else if (i == 11)
                    {
                        numCarta = "J";
                    }
                    else if (i == 12)
                    {
                        numCarta = "Q";
                    }
                    else if (i == 13)
                    {
                        numCarta = "K";
                    }

                    Carta carta1 = new Carta(numCarta, naipeCarta);
                    Baralho.Add(carta1);
                }

                naipeCarta = "Paus";

                for (int i = 1; i <= 13; i++)
                {
                    if (i == 1)
                    {
                        numCarta = "A";
                    }
                    else if (i >= 2 && i <= 9)
                    {
                        numCarta = i.ToString(); // Converte o valor de i para string
                    }
                    else if (i == 10)
                    {
                        numCarta = "10";
                    }
                    else if (i == 11)
                    {
                        numCarta = "J";
                    }
                    else if (i == 12)
                    {
                        numCarta = "Q";
                    }
                    else if (i == 13)
                    {
                        numCarta = "K";
                    }

                    Carta carta1 = new Carta(numCarta, naipeCarta);
                    Baralho.Add(carta1);
                }

                j++;
            }

            quantCartas = Baralho.Count; // ver a quantidade de baralho da partida

            Console.WriteLine("\n░░░░░░░ BARALHO CRIADO! ░░░░░░░\n");
            Console.WriteLine("\nQuantidade de cartas no baralho: " + quantCartas);

            /*for (int i=0; i<Baralho.Count; i++){
              Console.WriteLine("NAIPE: " + Baralho[i].naipeCarta + " NÚMERO: " + Baralho[i].numCarta);
            }*/

            return Baralho;
        }
    }

    // metodo para embaralhar e tranformar a fila de cartas embaralhadas em pilha

    public Stack<Carta> Embaralhar(List<Carta> Baralho)
    {
        Random random = new Random();
        List<Carta> baralhoEmbaralhado = new List<Carta>();

        while (Baralho.Count > 0) // Enquanto a lista ainda tiver carta...
        {
            int index = random.Next(0, Baralho.Count); // posição aleatória de 0 até Baralho.Count
            Carta carta = Baralho[index]; // pega o valor da carta na posição aleatória
            Baralho.RemoveAt(index); // remove da lista baralho o elemento no indice de valor aleatório
            baralhoEmbaralhado.Add(carta); // adiciona a carta removida na pilha de cartas embaralhadas
        }

        Stack<Carta> BaralhoEmbaralhado = new Stack<Carta>(baralhoEmbaralhado);

        Console.WriteLine("\nBaralho está embaralhado!\n");
        return BaralhoEmbaralhado;
    }

}


class Jogador
{
    public string nome;
    public int Id; // Criar um id unico para cada jogador
    public int posicao;// posição na ultima partida
    public int numCartasMao; //total de cartas na ultima partida
    public Queue<int> rankingUltimas5 = new Queue<int>(); //FILA -->ranking do jogador nas ultimas 5 partidas


    public Jogador(int Id, string nomeEscolhido) //Construtor 01
    {
        nome = nomeEscolhido;
        this.Id = Id;
        posicao = 0;
        numCartasMao = 0;
    }

    //Metodo roubar!!!!!

    public void MostrarJogadorCadastrados() //Mostrar jogador recem cadastrado
    {
        Console.WriteLine("\nJogador cadastrados:");
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("ID: " + Id);
        }
    }
}
//Fim Classes

class Program
{   //LISTA, PILHAS E FILAS GLOBAIS *********************

    static List<Jogador> ListaJogadoresCadastrados = new List<Jogador>(); //Lista de jogadores cadastrados tipo jogador

    static List<Jogador> ListaJogadoresPartida = new List<Jogador>(); //Lista para os criar os jogadores da partida do tipo int

    static List<Jogador> RankingG = new List<Jogador>();// lista do rank geral 


    // MÉTODOS ****************************

    static public void MostrarMenu()
    {
        int opcao = 0;

        while (opcao != 7)
        {
            Console.WriteLine("\n---------- ROUBA MONTE ----------");
            Console.WriteLine("MENU: ");
            Console.WriteLine("1- JOGAR");
            Console.WriteLine("2- RANKING GERAL");
            Console.WriteLine("3- PESQUISAR RANKING JOGADOR");
            Console.WriteLine("4- CADASTRAR NOVO JOGADOR");
            Console.WriteLine("5- REGRAS");
            Console.WriteLine("6- DESENVOLVEDORES");
            Console.WriteLine("7- ENCERRAR O JOGO \n");

            Console.Write("Escolha a opção desejada: ");
            opcao = int.Parse(Console.ReadLine()!); //Ler resposta do usuario

            switch (opcao)
            {
                case 1:
                    IniciarJogo(); //chamar metodo
                    break;

                case 2:
                    AtualizarRanking(ListaJogadoresCadastrados); // pegar lista dos cadastrados e passar p lista ranking
                    ExibirRankingGeral();
                    break;

                case 3:
                    PesquisaRanking(); //chamar metodo
                    break;

                case 4:
                    CadastrarJogador(); //chamar metodo
                    break;

                case 5:
                    int voltar = 0;

                    MostrarRegras();//chamar metodo
                    Console.WriteLine("Aperte 1 para voltar ao menu principal");
                    voltar = int.Parse(Console.ReadLine()!); //Ler resposta do usuario

                    switch (voltar)
                    {
                        case 1:
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;

                case 6:
                    MostrarDesenvolvedores();//chamar metodo
                    Console.WriteLine("Aperte 1 para voltar ao menu principal");
                    voltar = int.Parse(Console.ReadLine()!); //Ler resposta do usuario

                    switch (voltar)
                    {
                        case 1:
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;

                case 7:
                    Console.WriteLine("--- Fim do Programa ---");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static public void CadastrarJogador()
    {
        int opcaoCadastrar = 0;

        Console.WriteLine("\n----- MENU DE CADASTRO ----- ");
        Console.WriteLine("\n1- Cadastrar novo jogador ");
        Console.WriteLine("2- Mostrar jogadores Cadastrados ");
        Console.WriteLine("3- Digite 3 para voltar ao MENU \n");

        Console.Write("Escolha a opção desejada:");
        opcaoCadastrar = int.Parse(Console.ReadLine()!); //Ler resposta do usuario

        //colocar erro caso coloque resporta de outro tipo !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        switch (opcaoCadastrar)
        {
            case 1: //CADASTRAR JOGADOR

                string resposta = "s";

                while (resposta == "s")
                {
                    string nomeJogador;

                    Console.WriteLine("----- CADASTRO DE JOGADOR -----");

                    Console.WriteLine("\nDigite o nome do Jogador:");
                    nomeJogador = Console.ReadLine()!;

                    Jogador novoJogador = new Jogador(ListaJogadoresCadastrados.Count + 1, nomeJogador); // INSTANCIAR novo jogador

                    ListaJogadoresCadastrados.Add(novoJogador);// add jogador na lista

                    novoJogador.MostrarJogadorCadastrados();// mostra nome e id do jogador recem cadastrado

                    Console.WriteLine("\nGostaria de cadastra mais um jogador digite? s ou n");
                    resposta = Console.ReadLine()!;
                }
                CadastrarJogador();   // voltar menu cadastrar jogador        
                break;

            case 2:
                string resp = "n";

                Console.WriteLine("\n----- JOGADORES JÁ CADASTRADOS ----- \n");

                foreach (Jogador jogador in ListaJogadoresCadastrados)
                {
                    Console.WriteLine("Nome: " + jogador.nome + " - ID: " + jogador.Id);
                }

                Console.WriteLine("        -----   -----   -----       ");
                
                Console.WriteLine("\nDigite v para voltar ao menu de cadastro");
                resp = Console.ReadLine()!;

                if (resp == "v")
                {
                    CadastrarJogador();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
                break;


            case 3:
                break;

            default:

                Console.WriteLine("Opção inválida!");
                Console.WriteLine(" ");
                CadastrarJogador();
                break;
        }
    }

    public static void MostrarCartasTopoDosJogadores(Dictionary<string, Stack<Carta>> BaralhoDosJogadores)
    {
        foreach (var jogador in BaralhoDosJogadores)
        {
            string nomePilhaDoJogador = jogador.Key;
            Stack<Carta> pilhaCartasJogador = jogador.Value;

            if (pilhaCartasJogador.Count > 0)
            {
                Carta cartaTopo = pilhaCartasJogador.Peek(); // pega a carta do topo do jogador

                Console.WriteLine($"Topo do baralho do jogador {nomePilhaDoJogador}:");
                Console.WriteLine($"Naipe: {cartaTopo.naipeCarta}, Carta: {cartaTopo.numCarta}");
            }
            else// alterando o id pelo nome
            {
                Console.WriteLine($"O baralho do jogador {nomePilhaDoJogador} está vazio.");
            }
        }
    }

    public static void EscreveArquivo(string mensagem)
    {
        using (StreamWriter writer = new StreamWriter("acoesJogadores.txt", true))
        {
            writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensagem}");
        }
    }

    public static void MostrarCartasOrdenadasVencedor(Dictionary<string, Stack<Carta>> BaralhoDosJogadores, string idJogadorVencedor)
    {
        // Verifica se o ID do jogador vencedor está no dicionário de baralhos dos jogadores
        if (BaralhoDosJogadores.TryGetValue(idJogadorVencedor, out Stack<Carta> baralhoVencedor))
        {
            Console.WriteLine($"\nCartas ordenadas do jogador vencedor (ID: {idJogadorVencedor}):");
            EscreveArquivo($"\nCartas ordenadas do jogador vencedor (ID: {idJogadorVencedor}):");

            // Ordena as cartas do baralho do jogador vencedor por número e naipe
            var cartasOrdenadas = baralhoVencedor.OrderBy(carta => carta.numCarta).ThenBy(carta => carta.naipeCarta);

            // Itera sobre as cartas ordenadas e as exibe na tela
            foreach (var carta in cartasOrdenadas)
            {
                Console.WriteLine($"Naipe: {carta.naipeCarta} - Número: {carta.numCarta}");
                EscreveArquivo($"Naipe: {carta.naipeCarta} - Número: {carta.numCarta}");
            }
        }
        else
        {
            Console.WriteLine("Erro: Jogador vencedor não encontrado no dicionário de baralhos dos jogadores.");
        }
    }

    public static void JogoRolando(Stack<Carta> MontedeCompras, Dictionary<string, Stack<Carta>> BaralhoDosJogadores, List<Carta> AreaDescarte)
    {
        // enquanto o monte de compras tiver cartas
        while (MontedeCompras.Count > 0)
        {

            if (AreaDescarte.Count != 0)
            {
                Console.WriteLine("Cartas na área de descarte:");
                foreach (var cartas in AreaDescarte) //mostra cartas na mesa
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("Carta: " + cartas.numCarta);
                    Console.WriteLine("  ");
                }
                Console.WriteLine("\n");
            }

            // mostrar cartas do topo das pilhas dos jogadores
            MostrarCartasTopoDosJogadores(BaralhoDosJogadores);
            Console.WriteLine("\n");

            // for para passar pelos jogadores da partida
            for (int i = 0; i < ListaJogadoresPartida.Count; i++)
            {
                bool JogaNovamente;

                /* enquanto jogador tirar uma carta igual a da área de descarte, igual a do topo do baralho de outro 
                   jogador ou do topo do próprio baralho ele jogará novamente*/
                do
                {
                    JogaNovamente = false;

                    Console.WriteLine("Vez do jogador de id: " + ListaJogadoresPartida[i].Id);
                    EscreveArquivo("Vez do jogador de id: " + ListaJogadoresPartida[i].Id);
                    Console.WriteLine("E nome: " + ListaJogadoresPartida[i].nome);
                    EscreveArquivo("E nome: " + ListaJogadoresPartida[i].nome + "\n");
                    Console.WriteLine("\n");

                    Console.WriteLine("Digite 1 para tirar uma carta.");
                    int opcao;

                    // Garantir que o numero e valido
                    while (!int.TryParse(Console.ReadLine(), out opcao))
                    {
                        Console.WriteLine("Opção inválida. Digite novamente.");
                    }
                    switch (opcao)
                    {
                        case 1:
                            if (MontedeCompras.Count > 0)//Garantir que o jogo so rode enquanto houver cartas
                            {
                                Carta cartaDaVez = MontedeCompras.Pop();
                                Console.WriteLine("Carta da vez: " + cartaDaVez.numCarta);
                                Console.Write(" Naipe: " + cartaDaVez.naipeCarta);
                                EscreveArquivo("Jogador: " + ListaJogadoresPartida[i].nome + " tirou a carta: " + cartaDaVez.numCarta + "/" + cartaDaVez.naipeCarta + "\n");

                                Console.WriteLine("\n");

                                // pega id do jogador da vez e transforma em string
                                string idJogadorDaVez = ListaJogadoresPartida[i].Id.ToString();

                                // itera pelos baralhos dos jogadores
                                foreach (var kvp in BaralhoDosJogadores.ToList())
                                {
                                    string nomePilhaDoJogador = kvp.Key;
                                    Stack<Carta> pilhaCartasJogador = kvp.Value;

                                    if (nomePilhaDoJogador != idJogadorDaVez && pilhaCartasJogador.Count > 0)
                                    {
                                        Carta cartaDoTopo = pilhaCartasJogador.Peek();

                                        if (cartaDaVez.numCarta == cartaDoTopo.numCarta)
                                        {
                                            while (pilhaCartasJogador.Count > 0)
                                            {
                                                Carta cartaRemovida = pilhaCartasJogador.Pop();
                                                BaralhoDosJogadores[idJogadorDaVez].Push(cartaRemovida);
                                            }

                                            Console.WriteLine("Carta da vez é igual a carta do topo do baralho de outro jogador.");
                                            BaralhoDosJogadores[idJogadorDaVez].Push(cartaDaVez);
                                            Console.WriteLine("Jogador de id: " + idJogadorDaVez + " roubou o monte do jogador de id: " + nomePilhaDoJogador);

                                            EscreveArquivo("Carta da vez é igual a carta do topo do baralho de outro jogador.");
                                            EscreveArquivo("Jogador: " + ListaJogadoresPartida[i].nome + " roubou o monte do jogador de id: " + nomePilhaDoJogador + "\n");
                                            Console.WriteLine("\n");
                                            JogaNovamente = true;
                                        }
                                    }
                                    else if (nomePilhaDoJogador == idJogadorDaVez && pilhaCartasJogador.Count > 0)
                                    {
                                        Carta cartaDoTopo = pilhaCartasJogador.Peek();

                                        if (cartaDaVez.numCarta == cartaDoTopo.numCarta)
                                        {
                                            Console.WriteLine("Carta da vez é igual a carta do topo de seu baralho.");
                                            BaralhoDosJogadores[idJogadorDaVez].Push(cartaDaVez);
                                            Console.WriteLine("Jogador de id: " + idJogadorDaVez + " adicionou a carta da vez ao topo do seu baralho");

                                            EscreveArquivo("Carta da vez é igual a carta do topo de seu baralho.");
                                            EscreveArquivo("Jogador de id: " + idJogadorDaVez + " adicionou a carta da vez ao topo do seu baralho\n");
                                            Console.WriteLine("\n");
                                            JogaNovamente = true;
                                        }
                                    }
                                }

                                List<Carta> cartasRemover = new List<Carta>();

                                foreach (Carta cartaNaDescarte in AreaDescarte.ToList())
                                {
                                    if (AreaDescarte.Count != 0 && (cartaDaVez.numCarta == cartaNaDescarte.numCarta))
                                    {
                                        Console.WriteLine("Carta da vez é igual a uma carta da área de descarte.");
                                        EscreveArquivo("Carta da vez é igual a uma carta da área de descarte.");
                                        idJogadorDaVez = ListaJogadoresPartida[i].Id.ToString();
                                        BaralhoDosJogadores[idJogadorDaVez].Push(cartaDaVez);
                                        BaralhoDosJogadores[idJogadorDaVez].Push(cartaNaDescarte);
                                        cartasRemover.Add(cartaNaDescarte);
                                        Console.WriteLine("Jogador de id: " + idJogadorDaVez + " adicionou ao topo do seu baralho a carta da área de descarte e a carta da vez.");
                                        EscreveArquivo("Jogador de id: " + idJogadorDaVez + " adicionou ao topo do seu baralho a carta da área de descarte e a carta da vez.\n");
                                        Console.WriteLine("\n");
                                        JogaNovamente = true;
                                    }
                                }

                                foreach (var cartaRemover in cartasRemover)
                                {
                                    AreaDescarte.Remove(cartaRemover); //tirar do descarte as cartas que tem que remover/foram pegas
                                }

                                if (!JogaNovamente)
                                {
                                    // Verifica se a carta da vez não é igual às cartas nos montes dos jogadores e da área de descarte
                                    if (!ExisteCartaNosMontes(cartaDaVez, BaralhoDosJogadores) && !AreaDescarte.Contains(cartaDaVez))
                                    {
                                        // Se for diferente, a carta da vez vai para a área de descarte
                                        Console.WriteLine("Carta da vez diferente das cartas na área de descarte e das cartas do topo do baralho de outros jogadores.");
                                        AreaDescarte.Add(cartaDaVez);
                                        Console.WriteLine("Jogador de id: " + idJogadorDaVez + " adicionou a carta da vez na área de descarte.");

                                        EscreveArquivo("Carta da vez diferente das cartas na área de descarte e das cartas do topo do baralho de outros jogadores.");
                                        EscreveArquivo("Jogador de id: " + idJogadorDaVez + " adicionou a carta da vez na área de descarte." + "\n");
                                        Console.WriteLine("\n");
                                    }
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                } while (JogaNovamente);
            }
        }

        Console.WriteLine("\nAs cartas do baralho acabaram...\n");
        EscreveArquivo("\nAs cartas do baralho acabaram...\n");

        Console.WriteLine("\n ----- FIM DO JOGO ------\n");
        EscreveArquivo("\n ----- FIM DO JOGO ------\n");

        Console.WriteLine("Quantidade de cartas na mão dos jogadores:");
        EscreveArquivo("Quantidade de cartas na mão dos jogadores:");
        string jogadorVencedor = "";
        int maiorQuantidadeCartas = -1;
        int h = 1;
        foreach (var jogador in BaralhoDosJogadores.OrderByDescending(c => c.Value.Count))
        {
            string nomePilhaDoJogador = jogador.Key;
            Stack<Carta> pilhaCartasJogador = jogador.Value;

            int quantidadeCartas = pilhaCartasJogador.Count;

            Console.WriteLine($"Jogador {nomePilhaDoJogador} tem {quantidadeCartas} cartas, e está em {h}º lugar");
            EscreveArquivo($"Jogador {nomePilhaDoJogador} tem {quantidadeCartas} cartas, e está em {h}º lugar");

            if (quantidadeCartas > maiorQuantidadeCartas)
            {
                maiorQuantidadeCartas = quantidadeCartas;
                jogadorVencedor = nomePilhaDoJogador;
            }

            int idj;
            // TryParse passa de string para int
            if (int.TryParse(nomePilhaDoJogador, out idj))
            {
                // Encontra o jogador correspondente na ListaJogadoresPartida e atualiza numCartasMao
                var jogadorPartida = ListaJogadoresPartida.FirstOrDefault(j => j.Id == idj);

                if (jogadorPartida != null)
                {
                    jogadorPartida.numCartasMao = quantidadeCartas;
                    jogadorPartida.rankingUltimas5.Enqueue(h);
                }
            }
            else
            {
                Console.WriteLine($"Erro: Não foi possível analisar o ID do jogador {nomePilhaDoJogador} como um número inteiro.");
            }

            h++;
        }

        Console.WriteLine($"\n O JOGADOR VENCEDOR É O DE ID: {jogadorVencedor} com {maiorQuantidadeCartas} cartas.");
        EscreveArquivo($"\n O JOGADOR VENCEDOR É O DE ID: {jogadorVencedor} com {maiorQuantidadeCartas} cartas.");
        // metodo de ordenar cartas do vencedor da partida e mostrar elas ordenadas
        MostrarCartasOrdenadasVencedor(BaralhoDosJogadores, jogadorVencedor);
        ListaJogadoresPartida.Clear();
    }


    // Função auxiliar para verificar se a carta existe nos montes dos jogadores
    private static bool ExisteCartaNosMontes(Carta carta, Dictionary<string, Stack<Carta>> BaralhoDosJogadores)
    {
        foreach (var kvp in BaralhoDosJogadores)
        {
            Stack<Carta> pilhaCartasJogador = kvp.Value;

            if (pilhaCartasJogador.Contains(carta))
            {
                return true;
            }
        }

        return false;
    }


    static public void IniciarJogo()
    {
        int numJogadores = 0, numBaralhos = 0;
        // usar ListaJogadores --> ista para os criar os jogadores da partida

        Console.WriteLine("Vamos começar!");
        Console.WriteLine(" ");

        while (numJogadores <= 1)
        {
            Console.WriteLine("Escolha o número de jogadores?");
            numJogadores = int.Parse(Console.ReadLine()!); //Ler resposta do usuario

            if (numJogadores <= 1)
            {
                Console.WriteLine("\nO jogo deve ter no mínimo 2 jogadores!");
            }
            Console.WriteLine(" ");
        }

        for (int i = 1; i <= numJogadores; i++) //repetir o numero de jogadores que vao jogar
        {
            int idJogador;

            Console.WriteLine("Digite o id do " + i + "º jogador");
            idJogador = int.Parse(Console.ReadLine()!);

            Jogador jogadorEncontrado = null!; // Inicializa como null, indicando que não foi encontrado

            foreach (Jogador jogador in ListaJogadoresCadastrados)
            {
                if (jogador.Id == idJogador) // se tiver o jogador cadastrado add na lista de jogadores da partida
                {
                    jogadorEncontrado = jogador;
                    ListaJogadoresPartida.Add(jogadorEncontrado);
                }
            }
        }

        Console.WriteLine("Jogadores da partida:");//Mostrar jogadores da partida
        EscreveArquivo("Jogadores da partida:");
        Console.WriteLine(" ");

        foreach (Jogador jogador in ListaJogadoresPartida)
        {
            Console.WriteLine("Nome: " + jogador.nome + " - ID: " + jogador.Id);
            EscreveArquivo("Nome: " + jogador.nome + " - ID: " + jogador.Id);
        }


        Console.WriteLine(" ");
        Console.WriteLine("Quantos baralhos?");
        numBaralhos = int.Parse(Console.ReadLine()!); //Ler resposta do usuario

        Carta cartasPartida = new Carta();
        List<Carta> pegaValorLista = new List<Carta>();
        Stack<Carta> BaralhoEmbaralhado = new Stack<Carta>();

        EscreveArquivo("\nQuantidade de baralhos da partida: "+numBaralhos+"\n");
        pegaValorLista = cartasPartida.CriarBaralho(numBaralhos);
        BaralhoEmbaralhado = cartasPartida.Embaralhar(pegaValorLista);

        // copia o Baralho embaralhado para "MontedeCompras" que é o monte que será utilizado na partida
        Stack<Carta> MontedeCompras = new Stack<Carta>();
        MontedeCompras = BaralhoEmbaralhado;


        // Cria um dicionário para armazenar os baralhos dos jogadores
        Dictionary<string, Stack<Carta>> baralhosDosJogadores = new Dictionary<string, Stack<Carta>>();

        // Itera sobre os jogadores
        for (int i = 0; i < ListaJogadoresPartida.Count; i++)
        {
            // Obtém o ID do jogador como string
            string id = ListaJogadoresPartida[i].Id.ToString();


            // Cria uma nova pilha de cartas para o jogador
            Stack<Carta> baralhoJogador = new Stack<Carta>();

            // Adiciona o baralho ao dicionário usando o nome como chave
            baralhosDosJogadores[id] = baralhoJogador;
        }
        int t = 0;
        foreach (var kvp in baralhosDosJogadores)
        {
            string nomePilhaDoJogador = kvp.Key;
            Stack<Carta> pilhaCartasJogador = kvp.Value;

            // Faça o que for necessário com cada pilha de cartas
            Console.WriteLine($"\nPilha de cartas do jogador de ID {nomePilhaDoJogador} nome {ListaJogadoresPartida[t].nome}");
            Console.WriteLine($"Quantidade de cartas na pilha do jogador: {pilhaCartasJogador.Count}\n");

            foreach (Carta carta in pilhaCartasJogador)
            {
                Console.WriteLine($"Número da Carta: {carta.numCarta}");
                Console.WriteLine($"Naipe da Carta: {carta.naipeCarta}");
            }
            t++;
        }

        // área de descarte, onde irão ficar as cartas que não são iguais a do topo do monte dos jogadores e que não são iguais as cartas da própria área de descarte
        List<Carta> AreaDescarte = new List<Carta>();
        JogoRolando(MontedeCompras, baralhosDosJogadores, AreaDescarte);

        Console.WriteLine(" ");
    }



    static public void MostrarRegras()
    {
        //int voltar = 0;
        
        Console.WriteLine("\n►►►►► REGRAS ◄◄◄◄◄");

        Console.WriteLine(" O jogador que tem a vez de jogar retira a carta de cima do monte de compras " +
            "e a mostra aos outros jogadores; vamos chamar essa carta de carta da vez.\n");


        Console.WriteLine(" Se a carta da vez for igual a alguma carta presente na área de descarte, " +
            "o jogador retira essa carta da área de descarte colocando-a, juntamente com a carta da vez, " +
            "no topo de seu monte, com as faces voltada para cima, e continua a jogada (ou seja, retira " +
            "outra carta do monte de compras e repete o processo).  \n");

        Console.WriteLine(" Se a carta da vez for igual à carta de cima de um monte de um outro jogador, " +
            "o jogador \"rouba\" esse monte, colocando-o em seu próprio monte, coloca a carta da vez no " +
            "topo do seu monte, face para cima, e continua a jogada.   \n");

        Console.WriteLine(" Se a carta da vez for igual à carta no topo de seu próprio monte, o jogador " +
            "coloca a carta da vez no topo de seu próprio monte, com a face para cima, e continua a jogada. \n");

        Console.WriteLine(" Se a carta da vez for diferente das cartas da área de descarte e das cartas nos" +
            " topos dos montes, o jogador a coloca na área de descarte, face para cima, e a jogada se " +
            "encerra (ou seja, o próximo jogador efetua a sua jogada). Note que esse é o único caso em " +
            "que o jogador não continua a jogada.  \n");


        Console.WriteLine(" O jogo termina quando não há mais cartas no monte de compras. O jogador que tiver " +
            "o maior monte (o monte contendo o maior número de cartas) ganha o jogo. Se houver empate, todos" +
            " os jogadores com o monte contendo o maior número de cartas ganham o jogo. \n");
        
    }

    static public void MostrarDesenvolvedores()
    {
        Console.WriteLine("----- DESENVOLVEDORES -----");
        Console.WriteLine("Este programa foi desenvolvido por:");
        Console.WriteLine("ADRIELLY COELHO JULIÃO");
        Console.WriteLine("ARTHUR TRINDADE BICALHO MAGALHÃES");
        Console.WriteLine("ISABELLA BOSCO CLEMENTE\n");

    }
    // metodos ranking

    public static void AtualizarRanking(List<Jogador> lista)
    {


        RankingG.AddRange(lista); // Adiciona jogadores da lista de entrada ao Ranking

        // Junta os jogadores por Id e mantem o com maior numero de Cartas na Mao para cada Id
        var jogadoresDistintos = RankingG.GroupBy(j => j.Id).Select(group => group.OrderByDescending(j => j.numCartasMao).First()).ToList();

        jogadoresDistintos.Sort((jogadorX, jogadorY) => jogadorY.numCartasMao.CompareTo(jogadorX.numCartasMao));     // Classifica a lista em ordem decrescente com base no numero de Cartas na Mao

        int MaximoDeJogadoresAMostrar = 10;  // Vai mostrar somente ate 10 jogadores no ranking
        jogadoresDistintos = jogadoresDistintos.Take(MaximoDeJogadoresAMostrar).ToList();

        //
        RankingG = jogadoresDistintos;

    }


    public static void ExibirRankingGeral()
    {
        Console.WriteLine("\n►►►►► RANKING GERAL ◄◄◄◄◄");

        for (int i = 0; i < RankingG.Count; i++)
        {
            Console.WriteLine((i + 1) + "º lugar - " + RankingG[i].nome + " - " + RankingG[i].numCartasMao);
        }
    }

    public static void PesquisaRanking()
    {
        Console.Clear();
        Console.WriteLine("►►►►► RANKING POR PESQUISA ◄◄◄◄◄");
        Console.WriteLine("Digite o ID do jogador:");
        string IdJogador;

        do
        {
            IdJogador = Console.ReadLine()!;

            if (string.IsNullOrEmpty(IdJogador)) // Confere se está vazio ou se é null
            {
                Console.WriteLine("Erro!!! É preciso digitar o Id do jogador");
            }

        } while (string.IsNullOrEmpty(IdJogador));

        if (int.TryParse(IdJogador, out int JogadorID)) // ultiliza o tryparse pra garantir que seja um numero
        {
            Jogador jogador = ListaJogadoresCadastrados.FirstOrDefault(JCP => JCP.Id == JogadorID)!; // Procura de jogador a jogador na lista de cad e retorna primeiro com o Id igual ao escolhido.

            // jogador da instância
            if (jogador != null)
            {
                if (jogador.rankingUltimas5 != null && jogador.rankingUltimas5.Count > 0)
                {
                    Console.WriteLine($"Rankings de {jogador.nome} nas últimas partidas");

                    foreach (int RanK in jogador.rankingUltimas5)
                    {
                        Console.WriteLine($"► {RanK}º ◄"); // Mostra o ranking da pessoa nas últimas partidas
                    }
                }
                else // caso não tenha rankings
                {
                    Console.WriteLine("\nVocê não jogou nenhuma partida!\n");
                }
            }
            else
            {
                Console.WriteLine("\n O Id do jogador não foi encontrado.\n");
            }
        }
        else
        {
            Console.WriteLine("Erro!!! O Id do jogador deve ser um número inteiro.");
        }
    }

    public static void exibirTitulo(){
    Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░  ███╗░░░███╗░█████╗░███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗  ████╗░████║██╔══██╗████╗░██║╚══██╔══╝██╔════╝██╔════╝
██████╔╝██║░░██║██║░░░██║██████╦╝███████║  ██╔████╔██║██║░░██║██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██╔══██╗██║░░██║██║░░░██║██╔══██╗██╔══██║  ██║╚██╔╝██║██║░░██║██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
██║░░██║╚█████╔╝╚██████╔╝██████╦╝██║░░██║  ██║░╚═╝░██║╚█████╔╝██║░╚███║░░░██║░░░███████╗██████╔╝
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═════╝░╚═╝░░╚═╝  ╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░ ");
  }

    //INÍCIO DO JOGO ***************************
    public static void Main(string[] args)
    {
        exibirTitulo();
        MostrarMenu();
    }
}