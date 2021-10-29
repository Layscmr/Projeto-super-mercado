using System;

class Mercado
{

    private string _Nome;
    private Atendente _Atendente;
    private Produto[] _Produto;


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


    public Produto[] produto
    {
        get
        {
            return this._Produto;
        }

        set
        {
          // this._Produto[this._Produto.Length]= value;
        }
    }

}
