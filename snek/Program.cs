// Använd DrawBox-metoden i föregående uppgift för att rita en box.
// Placera sedan ett @ i mitten av boxen.
// Om man använder piltangenterna ska man kunna flytta runt @.
// När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
// Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
// Spara bredd och höjd på boxen så du vet när den ska stanna.
// Skriv om DrawBox så den istället returnerar en 2D-array av char med tecknen som den tidigare skrev ut på displayen.
// Man ska också kunna mata in en tredje parameter för antal slumpade ‘#’.
// Om man anger t.ex 5 så ska 5 stycken extra ‘#’ slumpas ut på random ställen inne i boxen.
// Skriv sedan en annan metod som tar och ritar ut arrayen på skärmen.
// Fixa så man kan flytta runt @ med piltangenterna. Jämför positionen mot arrayen och gör så man inte kan gå på någon ‘#’.
// Extra utmaning: Gör en “orm” av ‘@’. När man flyttar positionen på @ så följer (t.ex) 5 andra @ efter i samma spår som man förflyttat sig.
// Extra utmaning 2: I det klassiska spelet “masken” (snake) förflyttar sig en mask i jämna tidsintervall i den riktning spelaren senast angav med piltangenterna.
// Någonstans på banan finns ett äpple masken ska äta.
// Det gäller för spelaren att ta sig dit utan att krocka med något hinder, eller sin egen svans.
// När man tar äpplet blir masken längre och ett nytt äpple dyker upp på slumpvis vald plats på banan.
// Implementera din egen version av spelet. Hint: Kolla upp Console.KeyAvailable och Thread.Sleep()
// Förslag: När du fått en första version av spelet att fungera, lägg till flera banor genom att hårdkoda in olika banlayout i olika 2D-arrayer. När man tagit ett visst antal äpplen på en bana så kommer man vidare till nästa.


using System.Diagnostics.Metrics;


var box = DrawBox(9, 9);

Print2DArray(box);

Thread.Sleep(500);

box[4, 4] = "@";

Print2DArray(box);


string[,] DrawBox(int height, int width)
{

    string[,] box = new string[height, width];


    for (int i = 0; i < height; i++)
    {
        if (i == 0 || i + 1 == height)
        {
            for (int j = 0; j < width; j++)
            {
                box[i, j] = "#";
            }

        }

        else
        {

            for (int j = 0; j < width; j++)
            {
                if (j == 0)
                {
                    box[i, j] = "#";
                }

                else if (j == width - 1)
                {
                    box[i, j] = "#";
                }

                else
                {
                    box[i, j] = "-";
                }
            }

        }

    }
    return box;
}

void Print2DArray<T>(T[,] matrix)
{
    Console.Clear();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}