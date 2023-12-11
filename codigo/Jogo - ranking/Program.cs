using System;
using System.Collections.Generic; //Usar colleções
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;


class Jogador //*************************************************************************************************
{
    public string nome;
    public int Id; // Criar um id unico para cada jogador
    public int posicao;// posição na ultima partida
    public int numCartasMao; //total de cartas na ultima partida
    public Queue<int> rankingUltimas5 = new Queue<int>(); //FILA -->ranking do jogador nas ultimas 5 partidas


    public Jogador(int Id, string nomeEscolhido, int numCartasMao) //Construtor 01
    {
        nome = nomeEscolhido;
        this.Id = Id;
        posicao = 0;
        this.numCartasMao = numCartasMao;
        rankingUltimas5 = new Queue<int>(); //inicializar a fila
    }
    //Metodo roubar!!!!!

    public void MostrarJogadorCadastrados() //Mostrar jogador recem cadastrado
    {
        Console.WriteLine("\nJogador cadastrados:");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("ID: " + Id);
    }
}
class Program //************************************************************************************************
{
    //global 
    static List<Jogador> RankingG = new List<Jogador>();
    static List<Jogador> ListaJogadoresCadastrados = new List<Jogador>(); //Lista de jogadores cadastrados tipo jogador

    // Explicação da Ordenação Decrescente:
    //O método Sort em C# permite personalizar a maneira como os elementos são comparados para realizar a ordenação.
    //Quando você fornece uma função de comparação personalizada para o Sort, como você fez com (jogadorX, jogadorY)
    //=> jogadorY.numCartasMao.CompareTo(jogadorX.numCartasMao), está especificando como comparar dois elementos
    //da lista para determinar a ordem.
    //A expressão jogadorY.numCartasMao.CompareTo(jogadorX.numCartasMao) realiza a comparação entre as cartas
    //na mão do jogador Y e as cartas na mão do jogador X.O método CompareTo retorna um valor negativo se o
    //jogadorY for menor que o jogadorX, um valor positivo se for maior e zero se forem iguais.
    //Ao inverter a ordem da comparação (anteriormente, comparávamos X com Y e agora estamos comparando Y com X),
    //estamos basicamente invertendo a lógica de ordenação.Assim, ao ordenar em ordem decrescente, estamos dizendo
    //ao método de ordenação que queremos os elementos com valores maiores de numCartasMao primeiro, o que resulta
    //na ordenação decrescente da lista.


    //metodos*************************************************************************************************

    public static void OrdenarPosicoes(List<Jogador> lista) // pegar a lista jogadores cadastrados
    {
        RankingG.AddRange(lista); //Adicionar os jogadores da Lista JogadoresCadastrados na lista RankingG

        RankingG.Sort((jogadorX, jogadorY) => jogadorY.numCartasMao.CompareTo(jogadorX.numCartasMao)); //ORDENAR A LISTA DE JOGADORES de acordo com as cartas na mao DE FORMA DECRESCENTE (O Y ANTES DO X)
    }

    public static void ExibirRankingGeral()
    {
        Console.WriteLine("----- RANKING GERAL -----");

        for (int i = 0; i < RankingG.Count; i++)
        {
            Console.WriteLine((i + 1) + "º lugar - " + RankingG[i].nome);
        }
    }

    public static void Main(string[] args) //****************************************************************
    {

        Jogador jogador1 = new Jogador(1, "Isa", 45);
        Jogador jogador2 = new Jogador(2, "Vitor", 60);
        Jogador jogador3 = new Jogador(3, "Adrielly", 59);
        Jogador jogador4 = new Jogador(4, "Adri", 90);
        Jogador jogador5 = new Jogador(5, "Ad", 2);

        ListaJogadoresCadastrados.Add(jogador1);
        ListaJogadoresCadastrados.Add(jogador2);
        ListaJogadoresCadastrados.Add(jogador3);
        ListaJogadoresCadastrados.Add(jogador4);
        ListaJogadoresCadastrados.Add(jogador5);

        OrdenarPosicoes(ListaJogadoresCadastrados);

        ExibirRankingGeral();
    }
}

