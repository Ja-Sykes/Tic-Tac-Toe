// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/// Though Process: Create 3 lines for the board. Top, mid, bottom.
/// 1,2,3 for top, 4,5,6, for mid, 7,8,9, for bottom
/// 
/// Have an empty string/array/list, but when a player presses either number it will
/// fill in either one of those boxes/spaces in the array with an "X" or an "O".
/// 
class program
{
    static void Main()
    {
        //Using Lists so when I can index into each one and change it's value. i.e.: "_" to an X or O
        List<string> topRow = new List<string> { "_", "|", "_", "|", "_" };
        List<string> midRow = new List<string> { "_", "|", "_", "|", "_" };
        List<string> botRow = new List<string> { "_", "|", "_", "|", "_" };
        //Visual Reference
        Console.WriteLine("1|2|3");
        Console.WriteLine("4|5|6");
        Console.WriteLine("7|8|9");
        Console.WriteLine("");

        //Writes Board
        //Extremely innefficient, but it should work alright...
        foreach (string t in topRow)
        {
            Console.Write(t);
        }
        Console.WriteLine();

        foreach (string m in midRow)
        {
            Console.Write(m);
        }
        Console.WriteLine();

        foreach (string b in botRow)
        {
            Console.Write(b);
        }
        Console.WriteLine();

        //Rules
        Console.WriteLine("Press 1 to go top left and 9 for bottom right, and so forth.");

        //Asks the player(s) where they want to go. 9 Times total.
        Console.WriteLine("Press a number for where you would like to go:");

        //Checks to see if players want to keep playing, if True, repeat the loop until it is false.
        bool keepPlaying = true;

        while(keepPlaying == true)
        {
            for (int i = 0; i < 10; i++)
            {
                //The placer is basically a way for me to check what number was pressed and place accoring from there
                //Symbol obv. gets placed when needed.
                string placer = Console.ReadLine();
                char symbol = ' ';
                if (i % 2 == 0)
                {
                    symbol = 'X';
                }
                else
                {
                    symbol = 'O';
                }

                /// Update the appropriate row based on the player's input...
                //Top Row
                if (placer == "1")
                {
                    topRow[0] = symbol.ToString();
                }
                if (placer == "2")
                {
                    topRow[2] = symbol.ToString();
                }
                if (placer == "3")
                {
                    topRow[4] = symbol.ToString();
                }
                //Mid Row
                if (placer == "4")
                {
                    midRow[0] = symbol.ToString();
                }
                if (placer == "5")
                {
                    midRow[2] = symbol.ToString();
                }
                if (placer == "6")
                {
                    midRow[4] = symbol.ToString();
                }
                //Bot Row
                if (placer == "7")
                {
                    botRow[0] = symbol.ToString();
                }
                if (placer == "8")
                {
                    botRow[2] = symbol.ToString();
                }
                if (placer == "9")
                {
                    botRow[4] = symbol.ToString();
                }

                //Prints the updated board each time
                foreach (string t in topRow)
                {
                    Console.Write(t);
                }
                Console.WriteLine();
                foreach (string m in midRow)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
                foreach (string b in botRow)
                {
                    Console.Write(b);
                }
                Console.WriteLine();

                //Tells which Player is up
                //Console.WriteLine("Player " + symbol[i + 1] + " is up!");

                ///Checks Win
                if ((topRow[0] == symbol.ToString() && topRow[2] == symbol.ToString() && topRow[4] == symbol.ToString()) ||
                    (midRow[0] == symbol.ToString() && midRow[2] == symbol.ToString() && midRow[4] == symbol.ToString()) ||
                    (botRow[0] == symbol.ToString() && botRow[2] == symbol.ToString() && botRow[4] == symbol.ToString()) ||
                    (topRow[0] == symbol.ToString() && midRow[0] == symbol.ToString() && botRow[0] == symbol.ToString()) ||
                    (topRow[2] == symbol.ToString() && midRow[2] == symbol.ToString() && botRow[2] == symbol.ToString()) ||
                    (topRow[4] == symbol.ToString() && midRow[4] == symbol.ToString() && botRow[4] == symbol.ToString()) ||
                    (topRow[0] == symbol.ToString() && midRow[2] == symbol.ToString() && botRow[4] == symbol.ToString()) ||
                    (topRow[4] == symbol.ToString() && midRow[2] == symbol.ToString() && botRow[0] == symbol.ToString()))
                {
                    Console.WriteLine(symbol + " wins!");

                    //After player wins, prompt to keep going or stop. Resets the for loop if yes...
                    //Also resets the board maually...
                    Console.WriteLine("Keep playing? (Y/N)");
                    string answer = Console.ReadLine();

                    if (answer == "y" || answer == "Y")
                    {
                        Console.WriteLine("Press a number to play again");
                        keepPlaying = true;
                        i = 0;

                        topRow[0] = "_";
                        topRow[2] = "_";
                        topRow[4] = "_";
                        midRow[0] = "_";
                        midRow[2] = "_";
                        midRow[4] = "_";
                        botRow[0] = "_";
                        botRow[2] = "_";
                        botRow[4] = "_";
                    }
                    else
                    {
                        keepPlaying = false;
                    }
                    if(keepPlaying == false)
                    {
                        break;
                    }
                }
                /* Tried to figure out how to call Cat
                else
                {
                    Console.WriteLine("No one wins, Cat");
                } */
            }
        }
    }
}