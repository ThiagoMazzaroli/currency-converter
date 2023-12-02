
Console.WriteLine("Escolha uma conversão de moeda \n 1 - Real para Dólar \n 2 - Dólar para Real \n 3 - Real para Euro \n 4 - Euro para Real \n 5 - Dolar pra Euro \n 6 - Euro pra dólar");
int valorDigitado = int.Parse(Console.ReadLine());
Moedas conversao = (Moedas)valorDigitado;

if (conversao < Moedas.RealPraDolar || conversao > Moedas.EuroPraDolar)
{
    Console.WriteLine("Opção inválida");
    return;
}

Console.WriteLine("Digite o valor pra conversão");
decimal valorMoeda = decimal.Parse(Console.ReadLine());

if (conversao == Moedas.RealPraDolar)
{
    string texto = " Dólar";
    if (RealPraDolar(valorMoeda) > 1)
    {
        texto = " Dólares";
    }
    else if (RealPraDolar(valorMoeda) < 1)
    {
        texto = " Cents";
    }
    Console.WriteLine("O valor convertido é: " + RealPraDolar(valorMoeda).ToString("N2") + texto);
}
else if (conversao == Moedas.DolarPraReal)
{
    string texto = " Real";
    if (DolarPraReal(valorMoeda) > 1)
    {
        texto = " Reais";
    }
    else if (DolarPraReal(valorMoeda) < 1)
    {
        texto = " Centavos";
    }
    Console.WriteLine("O valor convertido é: " + DolarPraReal(valorMoeda).ToString("N2") + texto);
}
else if (conversao == Moedas.RealPraEuro)
{
    string texto = " Euro";
    if (RealPraEuro(valorMoeda) > 1)
    {
        texto = " Euros";
    }
    else if (RealPraEuro(valorMoeda) < 1)
    {
        texto = " Cents";
    }
    Console.WriteLine("O valor convertido é: " + RealPraEuro(valorMoeda).ToString("N2") + texto);
}
else if (conversao == Moedas.EuroPraReal)
{
    string texto = " Real";
    if (EuroPraReal(valorMoeda) > 1)
    {
        texto = " Reais";
    }
    else if (EuroPraReal(valorMoeda) < 1)
    {
        texto = " Centavos";
    }
    Console.WriteLine("O valor convertido é: " + EuroPraReal(valorMoeda).ToString("N2") + texto);
}
else if (conversao == Moedas.DolarPraEuro)
{
    string texto = " Euro";
    if (EuroPraReal(valorMoeda) > 1)
    {
        texto = " Euros";
    }
    else if (EuroPraReal(valorMoeda) < 1)
    {
        texto = " Cents";
    }
    Console.WriteLine("O valor convertido é: " + DolarPraEuro(valorMoeda).ToString("N2") + texto);
}
else if (conversao == Moedas.EuroPraDolar)
{
    string texto = " Dolar";
    if (EuroPraDolar(valorMoeda) > 1)
    {
        texto = " Dolares";
    }
    else if (EuroPraDolar(valorMoeda) < 1)
    {
        texto = " Cents";
    }
    Console.WriteLine("O valor convertido é: " + EuroPraDolar(valorMoeda).ToString("N2") + texto);
}


decimal RealPraDolar(decimal valor)
{
    return valor / Constantes.DOLAR;
}

decimal DolarPraReal(decimal valor)
{
    return valor * Constantes.DOLAR;
}

decimal RealPraEuro(decimal valor)
{
    return valor / Constantes.EURO;
}

decimal EuroPraReal(decimal valor)
{
    return valor * Constantes.EURO;
}

decimal DolarPraEuro(decimal valor)
{
    return DolarPraReal(valor) / Constantes.EURO;
}

decimal EuroPraDolar(decimal valor)
{
    return EuroPraReal(valor) / Constantes.DOLAR;
}

