//Task-1)İsdifadəçi Ədəd Daxil Edir. Daxil Edilən Ədədin Neçə Mərtəbəbli Olduğunu Tapan Alqoritmi Qurun;
//Console.Write("Eded daxil edin : ");
//int number = int.Parse(Console.ReadLine());
//int clone = number;
//int count = 0;
//if (number == 0) count++;
//while (number != 0)
//{
//    number /= 10;
//    count++;
//}
//Console.WriteLine($"{clone} --> Mertebe : {count} ");


//Task-2)İsdifadəçi 2 Dənə Ədəd  Daxil Edir n və m ədədləri. m Ədədinin n Qüvvətini Tapan Alqoritm Qurun.
//Console.Write("Eded : ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Ustu : ");
//int m = int.Parse(Console.ReadLine());
//int pow = 1;
//for (int i = 1; i <= m; i++)
//{
//    pow = pow * n;
//}
//Console.WriteLine($"{n} ustu {m} = {pow}");




//Task-3)Verilmiş 4 reqemli ədədin reqemlerinin cemini tapan alqortim qurun.
//Console.Write("Eded : ");
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//int counter = 0;
//while (number != 0)
//{
//    sum += number % 10;
//    number /= 10;
//    counter++;
//}
//if (counter != 4)
//{
//    Console.WriteLine("Eded 4 reqemli deyil");
//    return;
//};
//Console.WriteLine($"Reqemlerin cemi = {sum}");



//Task-4)Verilmiş 5 reqemli ədədin ilk ve son reqemlerinin ceminin kvadratini tapan alqortimi qurun.
//Console.Write("5 reqemli eded daxil edin : ");
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//int counter = 0;
//while (number != 0)
//{
//    if (counter == 0 || counter == 4)
//    {
//        sum += number % 10;
//    }
//    counter++;
//    number /= 10;
//}
//if (counter > 5 || counter < 5)
//{
//    Console.WriteLine("Eded 5 reqemli deyil....");
//    return;
//}
//Console.WriteLine($"Sum : {sum} , Pow : {Math.Pow(sum, 2)}");




//Task-5)Verilmiş 6 reqemli ededin ilk 3 denesinin reqemleri cemini tapın: example: 123600= 1+2+3
//Console.Write("6 reqemli eded daxil edin : ");
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//int counter = 0;    
//while (number != 0)
//{
//    if (counter > 2)
//    {
//        sum += number % 10;
//    }
//    counter++;
//    number /= 10;
//}
//if (counter > 6 || counter < 6)
//{
//    Console.WriteLine("Eded 6 reqemli deyil...");
//    return;
//}
//Console.WriteLine($"Son 3 reqemin cemi : {sum}");




//Task-6)İsdifadəçi 2 Dənə Ədəd Daxil Edir. Daxil Edilən Ədədlərdə Daxil Olmaqla Bu Ədədlərin Aralığında Olan Ədədlərin cəmin Tapan Alqoritm Qurun.
//Console.Write("Birinci ededi daxil edin : ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Ikinci ededi daxil edin : ");
//int b = int.Parse(Console.ReadLine());
//int sum = 0;
//string result = "";
//int maxNumber = a;
//if (b > a)
//{
//    maxNumber = b;
//    b = a;
//}
//for (int i = b; i <= maxNumber; i++)
//{
//    sum += i;
//    if (i == maxNumber)
//    {
//        result += $"{i} = {sum}";
//        break;
//    }
//    result += $"{i} + ";

//}
//Console.WriteLine(result);



