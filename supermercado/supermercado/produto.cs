using System;

class Produto
{

    private string Name;
    private double Price;
    private int Quantity;



    public string Nome // property
    {
        get
        {
            return this.Name;
        }

        set
        {
            this.Name = value;
        }
    }


    public double Preco
    {
        get
        {
            return this.Price;
        }

        set
        {
            this.Price = value;
        }
    }

    public int Quantidade
    {
        get
        {
            return this.Quantity;
        }
        set
        {
            this.Quantity = value;
        }
    }

    public Produto(string nome, double preco, int quantidade)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Quantidade = quantidade;
    }
    

}
