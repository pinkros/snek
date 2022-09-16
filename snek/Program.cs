// Använd DrawBox-metoden i föregående uppgift för att rita en box.
// Placera sedan ett @ i mitten av boxen.
// Om man använder piltangenterna ska man kunna flytta runt @.
// När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.
// Hint: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
// Spara bredd och höjd på boxen så du vet när den ska stanna.


Console.WriteLine("Hello, World!");

Console.ReadLine();

var box = DrawBox(5, 5);


Print2DArray(box);

string[,] DrawBox(int width, int height)
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


    Console.Clear();
    return box;
}

void Print2DArray<T>(T[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}