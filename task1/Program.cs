// Напишите программу, которая бесконечно запрашивает целые числа
//  с консоли. Программа завершается 
// при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.



while (true)
{
   System.Console.WriteLine("введите целое число от 10 до 100:  ");
   string N = Console.ReadLine();
   if (N == "q") 
   break; 

   int number;
   if (int.TryParse(N, out number))
   {
      int sum = 0;
      while (number > 0)
      {
         sum += number % 10;
         number /= 10;
      }
      if (sum % 2 == 0)
      break;
      
   }
   else
   {
      System.Console.WriteLine("ошибка, введите целое число от 10 до 100:");
   }
   
}


    
