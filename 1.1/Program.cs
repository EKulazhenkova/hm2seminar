using Sistem;

class Program
{
    static void SelectRase()
    {
         string[] namesRace = {"Люди", "Воины", "Эльфы", "Орки"};
        for  (int i = 0; i < namesRase.Length-1; i++) 
        {
           Console.Write(i+1 + " - " + namesRace[i] + " , ");
        }
    }
    static void Main(string[] args)
    {
       SelectRase();
    }
    
}
