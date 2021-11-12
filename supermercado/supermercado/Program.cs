using System;
using System.Globalization;

class Program {
    public static void Main(string[] args) {

        Mercado superMercado = new Mercado();

        int Escolha;


        do {
            Console.WriteLine("Escolha uma das opções do super mercado " + superMercado.Nome);

            Console.WriteLine("0- Sair \n 1-Cadastrar produto \n 2-Expediente atendente \n 3-Compra\n 4-Listar produtos\n 5-valor que o caixa possui");

            Escolha = int.Parse(Console.ReadLine());

            switch (Escolha) {
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

                case 3:
                    Console.WriteLine("Digite o nome do produto que será comprado");
                    // captura o nome do produto
                    string ProdutoComprado = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade comprada do produto");
                    // captura a quantidade
                    int QuantidadeClienteCompra = int.Parse(Console.ReadLine());


                    foreach (Produto produto in superMercado.getProduto()) {


                        if (produto.Nome == ProdutoComprado) {
                            if (QuantidadeClienteCompra > produto.Quantidade) {
                                Console.WriteLine("Não tem essa quantidade de produto");
                            }
                            else {
                                produto.Quantidade = -(QuantidadeClienteCompra);
                                superMercado.ValorCaixa = produto.Preco * QuantidadeClienteCompra;

                            }


                        }
                    }
                    break;
                case 4:
                    foreach (Produto w in superMercado.getProduto()) {
                        Console.WriteLine("================================================");
                        Console.WriteLine(w.Nome);
                        Console.WriteLine(w.Preco);
                        Console.WriteLine(w.Quantidade);
                        Console.WriteLine("================================================");
                    }
                    break;
                case 5:
                    Console.WriteLine("O valor de dinheiro no caixa eh: " + superMercado.ValorCaixa );
                    break;
            }

        } while (Escolha != 0);


    }
}
