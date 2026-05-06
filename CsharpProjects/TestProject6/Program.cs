/*
Role playing game battle challenge

In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they lose the game.

In this challenge, we boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they generate a random value that is subtracted from the monster's health. If the monster's health is greater than zero, they take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle resumes.
Code challenge - write code to implement the game rules

Here are the rules for the battle game that you need to implement in your code project:

    You must use either the do-while statement or the while statement as an outer game loop.
    The hero and the monster start with 10 health points.
    All attacks are a value between 1 and 10.
    The hero attacks first.
    Print the amount of health the monster lost and their remaining health.
    If the monster's health is greater than 0, it can attack the hero.
    Print the amount of health the hero lost and their remaining health.
    Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    Print the winner.

*/

/*
int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();

while (heroHealth > 0 && monsterHealth > 0)
{
    // Hero attacks
    int heroAttack = random.Next(1, 11); // Generates a random value between 1 and 10
    monsterHealth -= heroAttack; // Subtract the attack value from the monster's health
    Console.WriteLine($"Hero attacks! Monster loses {heroAttack} health and has {monsterHealth} health remaining.");

    // Check if the monster is still alive
    if (monsterHealth > 0)
    {
        // Monster attacks
        int monsterAttack = random.Next(1, 11); // Generates a random value between 1 and 10
        heroHealth -= monsterAttack; // Subtract the attack value from the hero's health
        Console.WriteLine($"Monster attacks! Hero loses {monsterAttack} health and has {heroHealth} health remaining.");
    } else
    {
        Console.WriteLine("Monster has been defeated! Hero wins!");
        break; // Exit the loop if the monster is defeated
    }
}
*/

/*
Code project - write code that validates integer input

Here are the conditions that your first coding project must implement:

    Your solution must include either a do-while or while iteration.

    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

    Inside the iteration block:
        Your solution must use a Console.ReadLine() statement to obtain input from the user.
        Your solution must ensure that the input is a valid representation of an integer.
        If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
        Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

    Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

string? input;
string userInput = "";
int userValue = 0;
bool isInputValid = false;

Console.WriteLine("Please enter an integer between 5 & 10");

do
{
    input = Console.ReadLine();

    if (input != null)
    {
        userInput = input;
    }

    isInputValid = int.TryParse(userInput, out userValue);

    if (isInputValid == true)
    {
        if (userValue < 5 || userValue > 10)
        {
            isInputValid = false;
            Console.WriteLine($"You entered {userValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (isInputValid == false);

Console.WriteLine($"Your input value ({userValue}) has been accepted.");

input = Console.ReadLine();