using System;
using System.Collections.Generic;

class Mercado
{

    private string _Nome;
    private Atendente _Atendente;
    private List<Produto> _Produto = new();
    private double _ValorCaixa;


    public string Nome
    {
        get
        {
            return _Nome;
        }

        set
        {
            this._Nome = value;
        }
    }
    public Atendente atendente
    {
        get
        {
            return this._Atendente;
        }

        set
        {
            this._Atendente = value;
        }
    }
    public double ValorCaixa {
        get {
            return this._ValorCaixa;
        }
        set
        {
            this._ValorCaixa += value;
        }
    }


   public List<Produto> getProduto() {
        return this._Produto;
   }

    public void setProduto(Produto novoProduto)
    {
        this._Produto.Add(novoProduto);
    }

    public void cadastrarProduto (string nome , double preco, int quantidade)// metodo
    {
        Produto novoProduto = new Produto(nome, preco, quantidade);
        setProduto(novoProduto);
    }

}
