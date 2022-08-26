int row = 3;
int column = 3;
int oldRow = 0;
int oldColumn = 0;
int countCherry = 0;



int[,] CreateGameField(int row, int column) 
{
    int[,] gameField = new int[6, 7];
    
    int person = 1;
    int wall = 2;
    int cherry = 3;    
    int cherryRow = new Random().Next(0, 6);
    int cherryColumn = new Random().Next(0, 7);

    gameField[row, column] = person;
    gameField[1, 4] = wall;
    gameField[2, 4] = wall;
    gameField[3, 4] = wall;    
    while (true)
    {
    if (gameField[cherryRow, cherryColumn] == 0) 
    {
        gameField[cherryRow, cherryColumn] = cherry;
        break;
    }     
    else 
    {
    cherryRow = new Random().Next(0, 6);
    cherryColumn = new Random().Next(0, 7);
    }   
    } 
    return gameField;    
}

int[,] gameField = CreateGameField(row, column);

while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    gameField[row, column] = 0;
    oldRow = row;
    oldColumn = column;
    if (key.Key == ConsoleKey.W)
    {
        row--;
    }
    if (key.Key == ConsoleKey.S)
    {
        row++;
    }

    if (key.Key == ConsoleKey.A)
    {
        column--;
    }

    if (key.Key == ConsoleKey.D)
    {
        column++;
    }
    if (row > gameField.GetLength(0) - 1)
    {
        row = gameField.GetLength(0) - 1;
    }
    if (row < 0)
    {
        row = 0;
    }
    if (column > gameField.GetLength(1) - 1)
    {
        column = gameField.GetLength(1) - 1;
    }
    if (column < 0)
    {
        column = 0;
    }
    Console.Clear();
    if (gameField[row, column] == 2)
    {
        row = oldRow;
        column = oldColumn;
    }
    if (gameField[row, column] == 3)
    {
        countCherry++;
        gameField = CreateGameField(row, column);
    }
    gameField[row, column] = 1;


Console.WriteLine($"Вы собрали {countCherry} вишенок.");
for (int i = 0; i < gameField.GetLength(0); i++)
    {
        for (int j = 0; j < gameField.GetLength(1); j++)
        {
            Console.Write(gameField[i, j] + " ");
        }
        Console.WriteLine();
    }
}
