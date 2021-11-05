using System;
using System.Globalization;

 class Program {
    public static void Main(string[] args)
    {

        Mercado superMercado = new Mercado();

        int Escolha;


        do
        {
            Console.WriteLine("Escolha uma das opções do super mercado " + superMercado.Nome);

            Console.WriteLine("0- Sair \n 1-Cadastrar produto \n 2-Expediente atendente \n 3-Compra");

            Escolha = int.Parse(Console.ReadLine());

            switch(Escolha)
            {
                case 1:
                    string nome;
                    double preco;
                    int quantidade;
                    Console.WriteLine("digite o nome , o preco e a quantidade respectivamente");
                    nome = Console.ReadLine();
                    preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    quantidade = int.Parse(Console.ReadLine());
                    superMercado.cadastrarProduto(nome, preco, quantidade);
                    break;

                case 2:
                    Console.WriteLine("digite o nome do atendente");
                    nome = Console.ReadLine();
                    Atendente x = new Atendente();

                    x.Nome = nome;
                   
                    break;

               /* case 3:
                    Console.WriteLine("Digite qual produto deseja comprar: 1- sabão\n  2- soja \n  3- Coca-cola ");
                    nome = Console.ReadLine();
                    Produto K = new Produto();

                    K.Nome = name; 

                    if(Console.ReadLine = "sabao")
                    {
                        K.Quantidade--;

                        double ValoremCaixa;
                        ValoremCaixa += 5.60;
                    }
                    break;*/

            }

        } while (Escolha != 0);


    }
}
