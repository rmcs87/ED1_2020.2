﻿using System;
class Program
{
    static void Main(string[] args)
    {
        AvaliaNotas avaliaNotas = new AvaliaNotas();

        avaliaNotas.LerNotas();
        avaliaNotas.CalculaMedia();
        avaliaNotas.MostraNotas();
    }
}
