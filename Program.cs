/*Console.WriteLine("Enter start number : ");
int start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter end number : ");
int end = Convert.ToInt32(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} is Even ");
    }
    else
    {
        Console.WriteLine($"{i} is Odd ");
    }
}*/
/*Console.WriteLine("Enter start number : ");
int start = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter end number : ");
int end = Convert.ToInt32(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    string type = (i % 2 == 0) ? "Even" : "Odd";

    Console.WriteLine($"{i} is {type} ");
}*/

/*for (int i=1;i<=5;i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
   
}
for (int i = 5; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

*/

//While loop

/*Console.WriteLine("Enter start number : ");
int start = Convert.ToInt32(Console.ReadLine());

int continueLoop = 1;
while(continueLoop<=10)
{
    Console.WriteLine($"{start} * {continueLoop} = {start * continueLoop}");
    continueLoop++;

}*/
// while loop 
/*string password = "1234";
int attempts = 1;
string userInput = Console.ReadLine();

while (userInput != password && attempts < 3)
{
    Console.WriteLine("Incorrect password. Please try again.");
    Console.WriteLine("Enter password: ");

    userInput = Console.ReadLine();
    attempts++;
}
if (userInput == password)
{
    Console.WriteLine("Password correct. Access granted.");
}
else
{
    Console.WriteLine("Too many incorrect attempts. Access denied.");
}*/

//Arrays

decimal grandTotal = 0;
int userChoice;

do
{
    Console.Write("Enter price: ");
    decimal price = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Enter quantity: ");
    int quantity = Convert.ToInt32(Console.ReadLine());

    decimal productTotal = price * quantity;
    Console.WriteLine($"Total = {productTotal}");

    grandTotal += productTotal;

    Console.Write("Add another product? 1 = Yes, 0 = No: ");
    userChoice = Convert.ToInt32(Console.ReadLine());

} while (userChoice != 0);

Console.WriteLine($"All Total = {grandTotal}");