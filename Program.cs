//--------------------------------Task 1(1)---------------------------

//Console.WriteLine("Dordreqemli ededi daxil edin:");

//int num = int.Parse(Console.ReadLine());

//if ((num / 1000 >= 1 || num / 1000 <= -1) && (num / 1000 < 10 || num / 1000 > -10))
//{
//    int cem = 0;
//    int qaliq = 0;


//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    qaliq = num / 10;
//    cem = qaliq + cem;

//    Console.WriteLine(cem);
//}
//else
//{
//    Console.WriteLine("Eded duzgun deyil.Zehmet olmasa 4 reqemli eded daxil edin");
//}



//--------------------------------Task 1(2)---------------------------


//Console.WriteLine("Dordreqemli ededi daxil edin:");

//int num = int.Parse(Console.ReadLine());

//if ((num / 1000 >= 1) && (num / 1000 < 10))
//{
//    int cem = 0;
//    int qaliq = 0;


//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    num = num / 10;
//    qaliq = num % 10;
//    cem = qaliq + cem;
//    qaliq = num / 10;
//    cem = qaliq + cem;

//    Console.WriteLine(cem);
//}
//else
//{
//    Console.WriteLine("Eded duzgun deyil.Zehmet olmasa 4 reqemli eded daxil edin");
//}



//-------------------------------------Task 2-------------------------------

//Console.WriteLine(" 3 reqemli Ededi daxil edin :");

//int num = int.Parse(Console.ReadLine());


//if (num / 100 >= 1 && num/100 <= 10)
//{
//    int qaliq;
//    int qaliq2;
//    int qismet;



//    qaliq = num % 10;
//    num = num / 10;
//    qaliq2 = num % 10;
//    qismet = num / 10;

//    if (qaliq != qaliq2 || qaliq != qismet)
//    {


//        Console.WriteLine("Ferqli olan reqemler var");

//    }
//    else
//    {
//        Console.WriteLine("Eyni edelerdir");
//    }
//}
//else
//{
//    Console.WriteLine("Ededi duzgun daxil edilmeyib. 3 reqemli eded olmalidir");
//}








//   ---------------------------------------Task3------------------------------------

//Console.WriteLine("Number 1 :");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Number 2 :");
//int num2 = int.Parse(Console.ReadLine());
//int num;

//if (num1 != num2)
//{

//    num = num1;
//    num1 = num2;
//    num2 = num;

//    Console.WriteLine("Number 1 :" + num1);
//    Console.WriteLine("Number 2 :" + num2);

//}
//else
//{
//    Console.WriteLine("Bu edeler beraberdir");
//}











//      --------------------------------------Task4------------------------------
//Console.WriteLine("Yawinizi daxil edin :");
//int age = int.Parse(Console.ReadLine());



//if (age < 0)
//{
//    Console.WriteLine("Bele Yaw yoxdur. Zehmete olmasa yawinizi duzgun daxil edin...");
//}
//else if (age <= 12 || age >= 60)
//{
//    Console.WriteLine("Bilet 5 manat");
//}
//else if (age >= 13 || age <= 59)
//{
//    Console.WriteLine("Telebe kartiniz varmi Yes or No");
//    string card = Console.ReadLine();

//    if (card == "Yes")
//    {
//        Console.WriteLine("7.5 manat");
//    }
//    else if (card == "No")
//    {
//        Console.WriteLine("10 manat");
//    }
//    else
//    {
//        Console.WriteLine("Melumati duzgin daxil edin...");
//    }

//}