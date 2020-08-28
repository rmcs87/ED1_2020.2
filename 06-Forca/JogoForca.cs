using System;
using System.Collections;

public class JogoForca
{
    //Atributos
    string palavraAlvo;
    string palavraExibida; //_ _ A _ _
    string[] listaPalavras;
    ArrayList chutesCertos;
    ArrayList chutesErrados;
    int maxErros = 5;
    //Metodos
    public JogoForca()
    {
        listaPalavras = new string[] { "uvv", "casa", "borboleta" };
        chutesCertos = new ArrayList();
        chutesErrados = new ArrayList();
    }
    public string SortearPalavra()
    {
    }
    public bool ChutarLetra(char chute)
    {
    }
    public bool IsFimDeJogo()
    {
    }
    public void ExibirStatusDoJogo()
    {
    }
}
