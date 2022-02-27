static void desgloseconmonedas()
{
    float can, moneda;
    int c200, c100, c50, c20, c10, c5, c1, d50, d10, d5, d1, interruptor;
    moneda = can = c200 = c100 = c50 = c20 = c10 = c5 = c1 = d50 = d10 = d5 = d1  = 0;
    string linea;
    string numero = "";

    Console.WriteLine("Bienvenido a Su desglosador y conversor de monedas ");
    Console.WriteLine("Digite el numero de la opción que desee ");
    Console.WriteLine("#1 Desglosar Quetzales en Lempira Hodureña. ");  //3.19
    Console.WriteLine("#2 Desglosar Quetzales en dolares  "); //7.70
    Console.WriteLine("#3 Desglosar Quetzales en Peso Mexicano  ");//2.64
    Console.WriteLine("#4 Desglosar Lempiras Hondureñas en Quetzales "); //0.31
    Console.WriteLine("#5 Desglosar Dolares en Quetzales  ");//0.13
    Console.WriteLine("#6 Desglosar Peso Mexicano en Quetzales  ");
    numero = Console.ReadLine();
    interruptor = Convert.ToInt32(numero);

    switch (interruptor)
    {
        case 1:
            moneda = (float)3.19;
            break;
        case 2:
            moneda = (float)0.13;
            break;
        case 3:
            moneda = (float)2.65;
            break;
        case 4:
            moneda = (float)0.31;
            break;
        case 5:
            moneda = (float)7.7;
            break;
        case 6:
            moneda = (float)0.38;
            break;
        default:
            Console.WriteLine("Datos incorrectos");
            break;
    }

    Console.WriteLine("Ingrese una cantidad");
    linea = Console.ReadLine();
    can = float.Parse(linea);
    can = can * moneda;

    if ((can >= 200))
    {
        c200 = ((int)can / 200);
        can = can - (c200 * 200);
    }
    if ((can >= 100))
    {
        c100 = ((int)can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 100))
    {
        c100 = ((int)can / 100);
        can = can - (c100 * 100);
    }
    if ((can >= 50))
    {
        c50 = ((int)can / 50);
        can = can - (c50 * 50);
    }
    if ((can >= 20))
    {
        c20 = ((int)can / 20);
        can = can - (c20 * 20);
    }
    if ((can >= 10))
    {
        c10 = ((int)can / 10);
        can = can - (c10 * 10);
    }
    if ((can >= 5))
    {
        c5 = ((int)can / 5);
        can = can - (c5 * 5);
    }
    if ((can >= 1))
    {
        c1 = ((int)can / 1);
        can = can - (c1 * 1);
    }
    if ((can >= 0.5))
    {
        d50 = (int)(can / 0.50);
        can = can - (float)(d50 * 0.50);
    }
    if ((can >= 0.10))
    {
        d10 = (int)(can / 0.10);
        can = can - (float)(d10 * 0.10);
    }
    if ((can >= 0.05))
    {
        d5 = (int)(can / 0.05);
        can = can - (float)(d5 * 0.05);
    }
    if ((can >= 0.01))
    {
        d1 = (int)Math.Round(can / 0.01);
        can = can - (float)(d1 * 0.01);
    }


    Console.WriteLine($"BILLETES DE 200     {c200}");
    Console.WriteLine($"BILLETES DE 100     {c100}");
    Console.WriteLine($"BILLETES DE 50      {c50}");
    Console.WriteLine($"BILLETES DE 20      {c20}");
    Console.WriteLine($"BILLETES DE 10      {c10}");
    Console.WriteLine($"BILLETES DE 5       {c5}");
    Console.WriteLine($"BILLETES DE 1       {c1}");
    Console.WriteLine($"Monedas de 50 cent. {d50}");
    Console.WriteLine($"Monedas de 10 cent. {d10}");
    Console.WriteLine($"Monedas de 5  cent. {d5 }");
    Console.WriteLine($"Monedas de 1  cent. {d1}");
}// fin de desglose con monedas
desgloseconmonedas();
