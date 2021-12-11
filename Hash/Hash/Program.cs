// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** Welcome To Hashing ****************");
using Hash;
Console.Write("Select Number:\n1)ToBeOrNotToBe");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        hash.Add("0", "To");
        hash.Add("1", "Be");
        hash.Add("2", "Or");
        hash.Add("3", "Not");
        hash.Add("4", "To");
        hash.Add("5", "Be");
        string hash5 = hash.Get("5");
        Console.WriteLine("5th index value : {0} ", hash5);
        string hash2 = hash.Get("2");
        Console.WriteLine("2nd index value : {0} ", hash2);
         break;

    default:
        Console.WriteLine("invalid option");
        break;
}