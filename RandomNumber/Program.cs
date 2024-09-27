
Random rnd = new Random();

int myrandomnum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    
   
    myrandomnum = rnd.Next(0, 11);
    randomSum = randomSum + myrandomnum;
    Console.WriteLine($"My random number is: {myrandomnum}");
}
Console.WriteLine($"Random Sum: {randomSum}");