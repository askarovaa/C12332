System.Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
// if( day == 1)
// {
//     System.Console.WriteLine("Понидельник");
// }
// else if( day == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if( day == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if( day == 4)
// {
//     System.Console.WriteLine("Четверг");
// }
// else if( day == 5)
// {
//     System.Console.WriteLine("Пятница");
// }
// else if( day == 6)
// {
//     System.Console.WriteLine("Суббота");
// }
// else if( day == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }
// else
// {
//     System.Console.WriteLine("Такого дня нет");
// }

switch (day)
{
    case 1:
        {
         System.Console.WriteLine("Понидельник");
         break;
        }
     case 2:
        {
         System.Console.WriteLine("Вторник");
         break;
        }
    case 3:
        {
         System.Console.WriteLine("Среда");
         break;
        }
    case 4:
        {
         System.Console.WriteLine("Четверг");
         break;
        }
    case 5:
        {
         System.Console.WriteLine("Пятница");
         break;
        }
    case 6:
        {
         System.Console.WriteLine("Субоота");
         break;
        }
    case 7:
        {
         System.Console.WriteLine("Воскренье");
         break;
        }
    default:
        {
        System.Console.WriteLine("Такого дня нет");
        break;
        }
}