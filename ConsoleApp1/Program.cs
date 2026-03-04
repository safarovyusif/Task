//int num1 = 15;

//if(num1>0)
//{
//    Console.WriteLine("eded musbetdir");
//}
//else if (num1 < 0)
//{
//    Console.WriteLine("eded menfidir");
//}
//else
//{
//    Console.WriteLine("eded sifirdir");
//}
//----------------------------------------------------------------
//int num2 = 8;
//if(num2%2==0)
//{ Console.WriteLine("eded cutdur");
//}
//else
//{
//    Console.WriteLine("eded tekdir");
//}
//----------------------------------------------------------------
//int age = 25;
//if(age>=0 && age<=18)
//{
//    Console.WriteLine("usaq");
//}
//else if (age > 18 && age <= 65)
//{
//    Console.WriteLine("yetkin");
//}
//else if (age > 65)
//{
//    Console.WriteLine("Yasli");
//}

//----------------------------------------------------------------
//double mebleg = 250;
//double odenilecek = mebleg;
//if (mebleg < 100)
//{
//    odenilecek = mebleg;
//}
//else if(mebleg >=100 && mebleg<=500)
//{
//    odenilecek = mebleg - (mebleg * 0.10);
//}
//else if (mebleg >500)
//{
//    odenilecek = mebleg - (mebleg * 0.20);
//}
//Console.WriteLine($"odenilecek mebleg: {odenilecek}");  

//----------------------------------------------------------------

//double maas = 1000; 
//int tecrube = 4;
//double yekunMaas = maas;
//if (tecrube >= 0 && tecrube <= 2)
//{
//    yekunMaas = maas;
//}
//else if (tecrube > 2 && tecrube <= 5) 
//{
//    yekunMaas = maas + (maas * 0.15);
//}
//else if (tecrube > 5)
//{
//    yekunMaas = maas + (maas * 0.25);
//}
//Console.WriteLine($"Yekun maas(bonusla birlikde): {yekunMaas}");

//----------------------------------------------------------------

double mesafe = 10;
double odenis = 0;
if(mesafe>0 && mesafe <=5)
{
    odenis = 5;
}
else if(mesafe > 5 && mesafe <= 15)
{
    odenis = 5+((mesafe-5)*0.8);
}
else if (mesafe >= 15)
{
    odenis = 5 + ((mesafe - 5) * 0.6);
}
Console.WriteLine($"odenilecek mebleg: {odenis}");