using System;

class Produto
{

    private string Name;
    private double Price;
    private int Quantity;



    public string Nome
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

}
