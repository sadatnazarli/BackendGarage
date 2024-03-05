// task not lab for main lesson

// task 1 -- Array-də elementlərdən ən azı 1-i isdifadeci terefinden daxil edilen n ədədindən böyükdürsə true əks halda false çap edin +


//Console.WriteLine("reqemi daxil edin");
//int userInput = Convert.ToInt32(Console.ReadLine());

//int[] elements = { 10, 20, 30, 40, 50 };

//bool enBoyuk = false;

//foreach (int say in elements)
//{
//    {
//        if (userInput >= say)
//            enBoyuk = true;
//        break;
//    }
//}
//Console.WriteLine(enBoyuk);



// task 2 --  Verilmiş Ədədin cüt rəqəmlərini çap edən alqoritmi qurun;  +


//Console.WriteLine("ededi daxil edin");

//int eded = Convert.ToInt32(Console.ReadLine());



//foreach (var item in eded.ToString())
//{

//    if (item % 2 == 0)
//    {
//        Console.WriteLine(item);
//    }

//}



//task 3 - - Array-də cut index-də duran elementlərin ededi ortasini tapmaq; --


//int[] numbers = { 12, 14, 17, 19, 21, 22, 24, 44 };

//int avarage = 0;
//int count = 0;
//var sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//    count++;
//    Console.WriteLine(numbers[i]);
//}
//avarage = sum / count;
//Console.WriteLine("ededlerin ededi ortasi" + avarage);



// task 4 -- Arraydəki elementləri yuxarldan aşağı tərsinə çap edən algoritm yazın --

//int[] numbers = { 12, 14, 17, 19, 21, 22, 24, 44 };
//for (int i =  numbers.Length-1 ; i>= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}





// task 5 -- Arraydə olan ədədlərin mərtəbələrini çap edən algoritm qurun,
// meselen [1,23,543,23] - output 1 2 3 2 (not: cavablar duz cixsin bes edir altalta yanyana ferqi yoxdur)


//int[] arr = { 12, 24, 9, 16, 40 };
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i].ToString().Length);
//}






// task 6 -- Verilmis arrayda olan maksimum ededi cap edin - meselen [1,2,3,7,6,12,5] - > cavab = 12

int[] arr = { 1, 2, 3, 7, 6, 12, 5 };
int maxNum = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > maxNum)
    {
        maxNum = arr[i];
    }
}
Console.WriteLine(maxNum);













//task 7 -- Verilmis arrayda olan minimum ededi cap edin - meselen [1,2,3,7,6,12,5] - > cavab = 1

int[] numbers = { 1, 2, 3, 7, 6, 12, 5 };
int minNum = numbers[0];

for(int i=1; i > numbers.Length; i++)
{
    if (arr[i] > minNum)
    {
        minNum = numbers[i];
    }
}

Console.WriteLine(minNum);
