// Init
#nullable disable
Random rnd = new Random();
bool rollDice = true;

while(rollDice){
    // Menu
    Console.Clear();
    Console.WriteLine("Dice Roll Simulator Menu \n 1. Roll Dice Once \n 2. Roll Dice 5 Times \n 3. Roll Dice ‘n’ Times \n 4. Roll Dice until Snake Eyes \n 5. Exit");
    Console.Write("Select an option (1-5): "); int optionNumber = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"Loading Option {optionNumber}..."); Thread.Sleep(1500);
    Console.Clear();

    // Option #1
    if(optionNumber == 1){
        Console.WriteLine("Option 1: Roll Dice Once"); 
        int randomNum1 = rnd.Next(1,7);
        int randomNum2 = rnd.Next(1,7);
        Console.WriteLine($"{randomNum1}, {randomNum2} (sum: {randomNum1 + randomNum2})");
    }

    // Option #2
    if(optionNumber == 2){
        Console.WriteLine("Option 2: Roll Dice Five Times"); 
        for(int i = 0; i < 5; i++){
            int randomNum1 = rnd.Next(1,7);
            int randomNum2 = rnd.Next(1,7);
            Console.WriteLine($"{randomNum1}, {randomNum2} (sum: {randomNum1 + randomNum2})");
        }
    }

    // Option #3
    if(optionNumber == 3){
        Console.WriteLine("Option 2: Roll Dice 'n' Times"); 
        Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++){
            int randomNum1 = rnd.Next(1,7);
            int randomNum2 = rnd.Next(1,7);
            Console.WriteLine($"{randomNum1}, {randomNum2} (sum: {randomNum1 + randomNum2})");
        }
    }

    // Option #4
    if(optionNumber == 4){
        Console.WriteLine("Option 4: Roll Dice  until Snake Eyes"); 
        int rollNum = 0;
        bool option = true;
        while(option){
            int randomNum1 = rnd.Next(1,7);
            int randomNum2 = rnd.Next(1,7);
            rollNum++;
            Console.WriteLine($"{randomNum1}, {randomNum2} (sum: {randomNum1 + randomNum2})");

            if(randomNum1 == 1 && randomNum2 == 1){
                Console.WriteLine($"Snake Eyes @ Roll Number {rollNum}");
                option = false;
            }
        }
    }

    // Option #5
    if(optionNumber == 5){
        rollDice = false;
    }

    Console.WriteLine("\nPRESS ANY LETTER TO COUNTINUE"); 
    Console.Write("   -> ");Console.ReadLine(); 
}

Console.Clear();
