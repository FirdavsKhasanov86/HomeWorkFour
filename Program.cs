using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            // decimal userBalance = 4000m;
            // string basket = "";
            // decimal discount;
            // decimal discountBalance;
            // string errorBalanceMessage = "У вас недостаточно средств";

            // start: 

            // Console.WriteLine($"Ваш баланс - {userBalance}");

            // if (userBalance <= 0)
            // {
            //     Console.WriteLine(errorBalanceMessage);
            //     goto End;
            // }

            // System.Console.WriteLine("" +
            // "1.Xiomi Redmi8 - 1800 сомон\n" +
            // "2.Наушники - 300 сомон\n" +
            // "3.Часы   - 700 сомон\n" +
            // "4.Чихлы - 200 сомон\n" +
            // "5 Выход\n" +
            // "Ваш выбор (1-5):");

            // int choice = int.Parse(Console.ReadLine());

            // switch(choice)
            // {   
            //     case 1:
            //     {
            //            if(userBalance - 1800 >= 0 ){

            //                basket = basket + "Xiomi Redmi8,";
            //                discount = 1800 * 5/100;
            //                discountBalance =  1800 - discount; 
            //                userBalance = userBalance - discountBalance;
                           
            //             } 
            //             else{
            //               Console.WriteLine(errorBalanceMessage);
            //               goto End;
            //             }
            //               Console.Write("Вы хотите продолжить? д/н:");
            //               if (Console.ReadLine().ToLower() == "д") goto start;
            //              else goto End;
            //     }
            //     break;

            //     case 2:
            //     {
            //             if(userBalance - 300 >= 0){
            //                basket = basket + "Наушники,";
            //                userBalance = userBalance - 300;
            //             }
            //             else{
            //              Console.WriteLine(errorBalanceMessage);
            //              goto End;   
            //             }
            //             Console.Write("Вы хотите продолжить? д/н:");
            //             if(Console.ReadLine().ToLower() == "д") goto start;
            //             else goto End;
            //     }
            //     break;

            //     case 3:
            //     {
            //            if(userBalance - 700 >= 0 ){

            //                basket = basket + "Часы,";
            //                discount = 700 * 3/100;
            //                discountBalance =  700 - discount; 
            //                userBalance = userBalance - discountBalance;
                           
            //             } 
            //             else{
            //               Console.WriteLine(errorBalanceMessage);
            //               goto End;
            //             }
            //               Console.Write("Вы хотите продолжить? д/н:");
            //               if (Console.ReadLine().ToLower() == "д") goto start;
            //              else goto End; 
            //     }
            //     break;

            //     case 4:
            //     {
            //            if(userBalance - 200 >= 0 ){

            //                basket = basket + "Чихлы,"; 
            //                userBalance = userBalance - 200;
                           
            //             } 
            //             else{
            //               Console.WriteLine(errorBalanceMessage);
            //               goto End;
            //             }
            //               Console.Write("Вы хотите продолжить? д/н:");
            //               if (Console.ReadLine().ToLower() == "д") goto start;
            //              else goto End; 
            //     }
            //     break;

            //     case 5: goto End;
            //     default: goto start;        
            //     break;
            // }  

            // End:
            //    Console.WriteLine($"Ваши покупки: {basket}\nОстаток Вашего баланса:{userBalance}");
          
          //--------------------------------------------------------------------------//

            //3.
            // int a = 10, b = 15, c = 8, d = 5;

            // if(a < b && b < c && c < d){
            //     Console.WriteLine("Числа расположены по возрастанию");
            // }
            // else if(a == b && b == c && c == d){
            //     Console.WriteLine("Произведение значении = " + (a * b * c * d));
            // }
            // else if(a <= b && a <= c && a <= d)   
            // {
            //     Console.WriteLine($"Min:{a}");
            // }
            // else if(b <= a && b <= c && b <= d){

            //     Console.WriteLine($"Min:{b}");
            // }
            // else if(c <= a && c <= b && c <= d){
            //     Console.WriteLine($"Min:{c}");
            // }
            // else if(d <= a && d <= b && d <= c){
            //     Console.WriteLine($"Min:{d}");
            // }
       
          //-----------------------------------------//
            
            //4.
            
        //    int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine()),d,e,f;
           
        //     if(a < b && b < c ){
        //         d = a;
        //         a = c;
        //         b = b;
        //         c = d;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }
        //     else if(a > b && b > c){
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }
        //     else if(a>b && b<c){
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = d;
        //         b = f;
        //         c = e;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }

        //     else if(a < b && b > c && a < c){
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = e;
        //         b = f;
        //         c = d;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }
        //     else if(a < b && b > c && a > c){
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = e;
        //         b = d;
        //         c = f;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }
        //     else if(a > b && b < c && a > c){
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = d;
        //         b = f;
        //         c = e;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }

        //     else if(a <= b && b < c){ 
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = f;
        //         b = e;
        //         c = d;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }

        //     else if(a < b && b >= c){ 
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = f;
        //         b = e;
        //         c = d;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }
        //     else if(a <= b && b >= c){ 
        //         d = a;
        //         e = b;
        //         f = c;

        //         a = f;
        //         b = e;
        //         c = d;
        //         Console.WriteLine($"{a} >= {b} >= {c}");
        //     }
            

        }
    }
}
