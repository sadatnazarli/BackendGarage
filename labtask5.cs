// task 1 lab extra
// verilen arrayda en kicik 2 ci ededi tapin

// int[] ededler = { 1, 32, 45, 5, 7, 23, 0, -4, 245, -10, -100 };

// int enkicik = int.MaxValue;
// int ikincienKicik = int.MaxValue;


// for (int i = 0; i < ededler.Length; i++)
// {
//     if (ededler[i] < enkicik)
//     {
//         ikincienKicik = enkicik;

//         enkicik = ededler[i];
//     }

//     else if (ededler[i] < ikincienKicik)
//     {

//     }
// }


// Console.WriteLine("En küçük ikinci eleman: " + ikincienKicik);


// task 2 lab extra
//  verilen adlar arrayyinda adi 5 simvoldan boyuk olan adamlari tapin.

string[] adlar = { "Veli", "Sevinc", "Ayxan", "Kamil", "Mirdamet", "Mehemmed", "Eli" };

foreach (var item in adlar)
{
    if (item.Length > 5)
    {
        Console.WriteLine(item);
    }
}