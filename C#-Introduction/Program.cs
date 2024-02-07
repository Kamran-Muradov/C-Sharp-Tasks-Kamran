//////////////CLASSWORK///////////////////

//int age = 30;
//int n = 10;
//int m = 100;

//int sum = n + m;

//Console.WriteLine(sum);

//bool isMarried = true;

//if (isMarried == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//int[] arr = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//int a = 1;
//int b = 100;
//int result = 0;

//for (int i = a; i <= b; i++)
//{
//    if (i % 2 != 0)
//    {
//        result += i;
//    }
//}
//Console.WriteLine(result);

//string[] words = { "salam", "sagol", "Kamran", "salam", "sagol" };
//int count = 0;

//for (int i = 0; i < words.Length; i++)
//{
//    if (words[i] == "salam")
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);






//////////////HOMEWORK///////////////////

//Task 1: Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//int n = 21;

//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.WriteLine(n + " ededi 3-e ve 7-ye bolunur");
//}
//else
//{
//    Console.WriteLine(n + " ededi 3-e ve 7-ye bolunmur");
//}



//Task 2: n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//int n = 3;
//int m = 6;
//int sum;

//if (n % 2 == 0 && m % 2 == 0)
//{
//    sum = n + m;
//    Console.WriteLine("sum = " + sum);
//}
//else
//{
//    Console.WriteLine("Verilmish ededlerin her ikisi cut deyil");
//}



//Task 3: Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//int n = 3;
//int m = 26;
//int sum = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine("sum = " + sum);



//Task 4: Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] numbers = { 1, 4, 26, 35, -7, 8 };
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 != 0)
//    {
//        sum += numbers[i];
//    }
//}
//Console.WriteLine("sum = " + sum);



//Task 5: Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int[] numbers = { 1, 4, 26, 35, -7, 8, -16, -37 };
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("count = " + count);



//Task 6:  Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int n = -2;
//int m = 17;
//int count = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 != 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("count = " + count);



//Task 7:  Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//int n = 5;
//int m = 21;
//int sum = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine("sum = " + sum);



//Task 8:  Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//int n = 7;
//int m = 34;
//int count = 0;

//for (int i = n; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("count = " + count);



//Task 9: Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//int n = 121;
//int count = 0;

//if (n < 2)
//{
//    Console.WriteLine("Eded ne sade, ne de murekkebdir");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//    }

//    if (count == 2)
//    {
//        Console.WriteLine("Eded sadedir");
//    }
//    else
//    {
//        Console.WriteLine("Eded murekkebdir");
//    }
//}

