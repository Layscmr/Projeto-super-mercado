using System;
 class Program{
    public static void Main(string[] args)
    {

        Mercado superMercado = new Mercado();

        int Escolha;


        do
        {
            Console.WriteLine("Escolha uma das opções do super mercado " + superMercado.Nome);

            Console.WriteLine("0- Sair \n 1-Cadastrar produto \n 2-Expediente atendente \n 3-Compra");

            Escolha = int.Parse(Console.ReadLine());



        } while (Escolha != 0);


    }
}
