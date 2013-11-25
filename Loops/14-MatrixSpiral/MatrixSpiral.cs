using System;

class MatrixSpiral
{
    static void Main(string[] args)
    {
        string firstInput;
        int N;

        do
        {
            Console.WriteLine("Please input the first int number: ");   //user input for three numbers
            firstInput = Console.ReadLine();

        } while (!int.TryParse(firstInput, out N)); //check for correct input

        int[,] spiral = new int[N,N];           //create a new array

        string direction = "right";         //a string with the direction, we start moving to the right

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= N*N; i++)      //we start filling the array
        {
            //when we reach the last column of the array, we start moving down
            //each time we check if we have reached a filled cell
            if (direction == "right" && (currentCol >= N || spiral[currentRow,currentCol] != 0))
            {
                currentCol--;           //we go one column back, because we are out of the array
                currentRow++;           //we go one row down, to start filling the next row
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= N || spiral[currentRow, currentCol] != 0))
            {       //same logic applies in all the ifs
                direction = "left"; 
                currentRow--;
                currentCol--;
            }
            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentRow--;
                currentCol++;
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            spiral[currentRow, currentCol] = i; //we fill the current cell

            if (direction == "right")   //we increment or decrement, the row or the column, depending on the direction
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }
         
        for (int i = 0; i < N; i++)         //display the array
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0,4}",spiral[i, j]);
            }
            Console.WriteLine();
        }
    }
}

