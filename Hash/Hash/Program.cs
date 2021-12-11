// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** Welcome To Hashing ****************");
using Hash;
Console.Write("Select Number:\n1)ToBeOrNotToBe\n2)Paragraph,Remove");
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
    case 2:
        string samplePara = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        string[] para = samplePara.Split(" ");
        MyMapNode<int, string> hash0 = new MyMapNode<int, string>(para.Length);
        int i = 0;
        foreach (string word in para)
        {
            hash0.Add(i, word);  //adding each word in the para to list
            i++;
        }

        hash0.Remove(17);
        for (i = 0; i < para.Length; i++) //For each word in para displaying index position
        {
            string v = hash0.Get(i);
            Console.WriteLine($"Word {v} is at {i} index");
        }
        break;


    default:
        Console.WriteLine("invalid option");
        break;

}