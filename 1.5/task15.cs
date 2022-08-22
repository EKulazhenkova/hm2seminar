Console.Write("Введите, соответсвующую дню недели ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


    if (dayNumber == 6 || dayNumber == 7)
    {
    Console.WriteLine("Да,это выходной");    
    }
    else if(dayNumber < 1 || dayNumber > 7)
      {
       Console.WriteLine("Введено не верное число");
      }
    else Console.WriteLine("Нет, это будний день");  
 
