using System;
using System.Collections.Generic;
using System.Text;

class Solution
{
    private object antalTärningsögon;

    // konstruktor
    public Solution()
    {
    }
    public void Uppgift_1A()
    {
        Console.WriteLine("Hej Ada. Varmt välkommen.");
    }

    public void Uppgift_1B()
    {
        double bredd = 9.6;
        double höjd = 5.4;
        double area;
        area = bredd * höjd;
        Console.WriteLine("rektangel");
        Console.WriteLine("bredd: " + bredd);
        Console.WriteLine("höjd: " + höjd);
        Console.WriteLine("area: " + area);
    }

    public void Uppgift_1C()
    {

        Console.WriteLine("Bredd");
        String text = Console.ReadLine();
        double decimaltal = Convert.ToDouble(text);
        Console.WriteLine("Höjd");
        String text2 = Console.ReadLine();
        double decimaltal2 = Convert.ToDouble(text2);

    }

    public void Uppgift_1D()
    {
        Console.WriteLine("Ett");
        String text = Console.ReadLine();
        int tal = Convert.ToInt32(text);

        Console.WriteLine("Två");
        String text2 = Console.ReadLine();
        int tal2 = Convert.ToInt32(text2);
        Console.WriteLine(tal + tal2);
    }

    public void Uppgift_2A()
    {
        Console.WriteLine("Skriv ut gissa mitt favorittal.");
        String text3 = Console.ReadLine();
        double decimaltal = Convert.ToDouble(text3);

        int antalTärningsögon = Convert.ToInt32(text3);


        if (antalTärningsögon == 3)
        {
            Console.WriteLine("Du gissade rätt!");
        }
        else
        {
            Console.WriteLine("Du gissade fel!");
        }

        Console.WriteLine();

    }
    public void Uppgift_2B()
    {

        Random randomGenerator = new Random();
        int antalTärningsögon = randomGenerator.Next(1, 7);
        int antalTärningsögon2 = randomGenerator.Next(1, 7);

        Console.WriteLine("Visar tärningarna samma ger det vinst");
        Console.WriteLine("Tärningen visar: " + antalTärningsögon);
        Console.WriteLine("Tärningen visar: " + antalTärningsögon2);

        if (antalTärningsögon == antalTärningsögon2)
        {
            Console.WriteLine("Vinst.");
        }
        else
        {
            Console.WriteLine("Förlust.");
        }


    }

    public void Uppgift_3A()
    {
        int räknare = 0;
        while (räknare < 6)
        {
            Console.WriteLine(räknare);
            räknare = räknare + 1;
        }
        Console.WriteLine();
    }

    public void Uppgift_3B()
    {
        int räknare = 5;
        while (räknare < 21)
        {
            Console.WriteLine(räknare);
            räknare = räknare + 3;
        }
        Console.WriteLine();
    }

    public void Uppgift_3C()
    {
        int räknare = 10;
        while (räknare > -1)
        {
            Console.WriteLine(räknare);
            räknare = räknare - 1;
        }
        Console.WriteLine();
    }

    public void Uppgift_4A()
    {

        for (int räknare = 0; räknare < 6; räknare = räknare + 1)
        {
            Console.WriteLine("" + räknare);
            Console.WriteLine();
        }
    }

    public void Uppgift_4B()
    {

        for (int räknare = 5; räknare < 21; räknare = räknare + 3)
        {
            Console.WriteLine("" + räknare);
            Console.WriteLine();
        }
    }

    public void Uppgift_4C()
    {

        for (int räknare = 10; räknare > -1; räknare = räknare - 1)
        {
            Console.WriteLine("" + räknare);
            Console.WriteLine();
        }
    }

    public void Uppgift_5A()
    {
        bool input = true;
        while (input)
        {
            Console.WriteLine("Gissa på ett tal");
            string input2 = Console.ReadLine();

            if (input2 == "15")
            {
                Console.WriteLine("Du gissade rätt.");
                input = false;
            }


        }
        Console.WriteLine();
    }

    public void Uppgift_6A()
    {

        Random randomGenerator = new Random();
        int antalTärningsögon = randomGenerator.Next(1, 7);
        int antalTärningsögon2 = randomGenerator.Next(1, 7);

        Console.WriteLine("Visar tärningarna två sexor blir det Stor vinst, två ettor blir det Liten vinst, annars förlust");
        Console.WriteLine("Tärningen visar: " + antalTärningsögon);
        Console.WriteLine("Tärningen visar: " + antalTärningsögon2);


        if (antalTärningsögon + antalTärningsögon2 == 12)
        {
            Console.WriteLine("Stor vinst.");
        }

        else if (antalTärningsögon == antalTärningsögon2)
        {
            Console.WriteLine("Liten vinst.");
        }

        else
        {
            Console.WriteLine("Förlust.");
        }


    }

    public void Uppgift_7A()

    {
        String[] lista = { "3", "5", "7", "9", "11", "13" };
        Console.WriteLine(lista[0]);
        Console.WriteLine(lista[1]);
        Console.WriteLine(lista[2]);
        Console.WriteLine(lista[3]);
        Console.WriteLine(lista[4]);
        Console.WriteLine(lista[5]);
        Console.WriteLine();

    }

    public void Uppgift_8A()
    {

        int[] tal = new int[6];
        tal[0] = 3;
        tal[1] = 5;
        tal[2] = 7;
        tal[3] = 9;
        tal[4] = 11;
        tal[5] = 13;

        foreach (int talet in tal)

            Console.Write(talet + ", ");

        Console.WriteLine();
        Console.WriteLine();

    }

    public void Uppgift_8B()
    {

        int[] tal = new int[6];
        tal[0] = 3;
        tal[1] = 5;
        tal[2] = 7;
        tal[3] = 9;
        tal[4] = 11;
        tal[5] = 13;

        foreach (int talet in tal)

            Console.Write(talet + 1 + ", ");

        Console.WriteLine();
        Console.WriteLine();

    }

    public void välkommen_agent()
    {

        Console.WriteLine("Välkommen Agent X. Ditt uppdrag är ...");
    
    }

    public void Uppgift_9A()

    {
        välkommen_agent();

    }

    public void Uppgift_9B()

    {
        Console.WriteLine("Skriv ett tal");
        string tal1 = Console.ReadLine();
        int tal4 = Convert.ToInt32(tal1);
        Console.WriteLine("Skriv ett tal till");
        string tal2 = Console.ReadLine();
        int tal3 = Convert.ToInt32(tal2);
        Console.WriteLine("Summan blir: " + (tal3 + tal4));
        Console.WriteLine();

    }

    public void addera()
    {
        Console.WriteLine("Skriv ett tal");
        string tal1 = Console.ReadLine();
        int tal4 = Convert.ToInt32(tal1);
        Console.WriteLine("Skriv ett tal till");
        string tal2 = Console.ReadLine();
        int tal3 = Convert.ToInt32(tal2);
        Console.WriteLine("Skriv ytterliga ett tal till");
        string tal5 = Console.ReadLine();
        int tal6 = Convert.ToInt32(tal5);
        Console.WriteLine("Summan blir: " + (tal3 + tal4 + tal6));
        Console.WriteLine();


    }

    public void Uppgift_9B3()
    {

        addera();

    }


    public void Uppgift_10()
    {

        String[] lista = new String [100];
        String input = "j";
        int räknare = 0;



        while (input.Equals("j"))
        {
            Console.WriteLine("Lägg till något på listan");
            lista[räknare] = Console.ReadLine();
            räknare = räknare + 1;

            Console.WriteLine("Vill du fortsätta j/n?");
            input = Console.ReadLine();

        }


        foreach (string mat in lista)
        {
            if (mat != null)
            {
                Console.Write(mat + ", ");
            }
            

        }
       

    }
}