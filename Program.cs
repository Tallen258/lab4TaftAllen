Random r = new Random();

string[] firstNames = new string[10] { " John ", " James ", " Ralph ", " Peter ", " Rodger ", " Jaine ", " Jenny ", " Sarah ", " Jennet ", " Jenny " };
string[] middleNames = new string[10] { " liam ", " Larmy ", " Luis ", " Stuart ", " Sal ", " Sally ", " Mekella ", " Mckenna ", " Hannah ", " Jessie " };
string[] lastNames = new string[10] { " Roberts ", " Lamb ", " Steiner ", " christensen ", " Jermey ", " Sorensen ", " weller ", " Wells ", " charles ", " wilberg " };
string[] fullNames = new string[1000];
string[] job = new string[4] { "life guard", "cashier", "janitor", "nurse" };
decimal[] wages = new decimal[5] { 7.9M, 10.1M, 15M, 16M, 12.5M };


int counter = 0;
string[] randomName = new string[1000];
for (int x = 0; x < firstNames.Length; x++)
{
    for (int y = 0; y < middleNames.Length; y++)
    {
        for (int z = 0; z < lastNames.Length; z++)
        {


            int randomNum1 = r.Next(0, 4);
            int randomNum2 = r.Next(0, 5);
            int randomNum3 = r.Next(0, 5);
            fullNames[x] = firstNames[x] + middleNames[y] + lastNames[z];
            Console.Write(counter); counter++;
            Console.Write(fullNames[x]);
            Console.WriteLine(":");
            Console.WriteLine(job[randomNum1]);
            Console.WriteLine(wages[randomNum2]);
            Console.WriteLine(wages[randomNum2] * 40 * 50);
        }
    }
}
