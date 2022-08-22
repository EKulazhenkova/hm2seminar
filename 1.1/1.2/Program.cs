﻿class Program
{
    static void WriteSelect(string[] namesArray)
    {
        for  (int i = 0; i < namesArray.Length-1; i++) 
        {
           Console.Write(i+1 + " - " + namesArray[i] + " , ");
        }
        Console.Write(namesArray.Length + " - " + namesArray[namesArray.Length-1] + "."); 
    }
    static void SelectRace()
    {
         string[] namesRace = {"Люди", "Воины", "Эльфы", "Орки"};
        WriteSelect(namesRace);
        Console.WriteLine("Укажите Вашу рассу ");
        int indexRace = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша раса " + namesRace[indexRace-1]);
    }
    static void SelectClass()
    {
         string[] namesClass = {"Разбойники", "Маги", "Воин", "Воры"};
        WriteSelect(namesClass);
        Console.WriteLine("Укажите Ваш класс ");
        int indexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша класс " + namesClass[indexClass-1]);
    }
    static void SelectSex()
    {
         string[] namesSex = {"Мужской", "Женский"};
        WriteSelect(namesSex);
        Console.WriteLine("Укажите Ваш пол ");
        int indexSex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш пол " + namesSex[indexSex-1]);
    }
    static void Main(string[] args)
    {
       SelectRace();
       SelectClass();
       SelectSex();
    }
    
}
