using System.Diagnostics;
using System.Linq;
using System.Threading;
using static Session01LINQ.ListGenerator;
namespace Session01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region Q01 : 1. Find all products that are out of stock.
            ////1.Fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            ////2. Query Syntax
            //Result = from P in ProductsList where P.UnitsInStock == 0 select P;

            //foreach (var Unit in Result)
            //    Console.WriteLine(Unit);

            #endregion

            #region Q02 : 2. Find all products that are in stock and cost more than 3.00 per unit.

            ////1.Fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);

            ////2. Query Syntax
            //Result = from P in ProductsList where P.UnitsInStock > 0 && P.UnitPrice > 3.00m select P;


            //foreach (var Product in Result)
            //    Console.WriteLine(Product);

            #endregion

            #region Q03 : 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            ////1. Fluent syntax 
            //var Result = Arr.Where((A , I)=> I< Arr.Length &&  Arr[I].Length < I);

            ////2. Query Syntax
            // Result = from i in Enumerable.Range(0, Arr.Length) where Arr[i].Length < i select Arr[i]; 

            //foreach(var result in Result)
            //    Console.WriteLine(result);
            #endregion


            #endregion


            #region LINQ - Ordering Operators

            #region Q01 : Sort a list of products by name

            ////1.Fluent Syntax 
            //var Result = ProductsList.OrderBy(P => P.ProductName);


            ////2. Query Syntax 
            //Result = from P in ProductsList orderby P.ProductName select P;

            //foreach (var Item in Result) 
            //    Console.WriteLine(Item);

            #endregion

            #region Q02 : Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            ////1.Fluent Syntax 
            //var Result = Arr.OrderBy(A=> A.ToLower());


            ////2. Query Syntax 
            //Result = from A in Arr orderby A.ToLower() select A;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);
            #endregion

            #region Q03 : Sort a list of products by units in stock from highest to lowest.


            ////1.Fluent Syntax 
            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock);


            ////2. Query Syntax 
            //Result = from P in ProductsList orderby P.UnitsInStock descending   select P;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region Q04 :  Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};


            ////1.Fluent Syntax 
            //var Result = Arr.OrderBy(A => A.Length).ThenBy( A=> A);


            ////2. Query Syntax 
            //Result = from A in Arr orderby A.Length,A  select A;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region Q05 :  Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            ////1.Fluent Syntax 
            //var Result = Arr.OrderBy(A=> A.Length).ThenBy(A => A.ToLower());


            ////2. Query Syntax 
            //Result = from A in Arr orderby A.Length, A.ToLower() select A;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region Q06 : Sort a list of products, first by category, and then by unit price, from highest to lowest.

            ////1.Fluent Syntax
            //var Result = ProductsList.OrderByDescending(P => P.Category).ThenByDescending(P=> P.UnitPrice);


            ////2. Query Syntax 
            //Result = from P in ProductsList orderby P.Category descending, P.UnitPrice descending select P;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region Q07 : Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            ////1.Fluent Syntax 
            //var Result = Arr.OrderBy(A => A.Length).ThenByDescending(A => A.ToLower());


            ////2. Query Syntax 
            //Result = from A in Arr orderby A.Length, A.ToLower() descending select A;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);
            #endregion

            #region Q08 : 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            ////1.Fluent Syntax 
            //var Result = Arr.Where( A=> A.Length > 1 && A[1] =='i').Reverse();


            ////2. Query Syntax 
            //Result = (from A in Arr where A.Length > 1 && A[1]=='i' select A) .Reverse();

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);
            #endregion
            #endregion


            #region LINQ – Transformation Operators

            #region Q01 Return a sequence of just the names of a list of products.
            ////1.Fluent syntax 
            //var Result = ProductsList.Select(P => P.ProductName);

            ////Query Syntax 
            //Result = from P in ProductsList select P.ProductName;

            //foreach (var item in Result) 
            //    Console.WriteLine(item);


            #endregion

            #region Q02 : 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };


            ////1.Fluent syntax 
            //var Result = words.Select( W => new {Upper = W.ToUpper(), Lower = W.ToLower() });

            ////Query Syntax 
            //Result = from W in words select new { Upper = W.ToUpper(), Lower = W.ToLower() };

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Q03 : 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            ////1.Fluent syntax 
            //var Result = ProductsList.Select(P => new  { P.ProductName , Price = P.UnitPrice});

            ////Query Syntax 
            //Result = from P in ProductsList select new  { P.ProductName , Price = P.UnitPrice};

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Q04 : 4. Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //// 1.Fluent syntax 
            //var Result = Arr.Select((A, I) => new { Value = A, Index = I, IS = A == I });

            //foreach (var item in Result)        
            //    Console.WriteLine($"{item.Value} : {item.IS}");



            #endregion

            #region Q05 : 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            ////1.Query Syntax
            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select $"{a} is less than {b}";
            //foreach ( int i in numbersA ) 
            //Console.WriteLine( i );

            #endregion

            #region Q06 : Select all orders where the order total is less than 500.00.
            ////1.fluent syntax 
            //var Result = CustomersList.SelectMany(C => C.Orders.Where(O => O.Total < 500m));

            ////2.Query syntax 
            //Result = from C in CustomersList
            //         from O in C.Orders
            //         where O.Total < 500m
            //         select O;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);
            #endregion

            #region Q07 : Select all orders where the order was made in 1998 or later.
            ////1. Fluent Syntax 
            //var Result = CustomersList.SelectMany(C => C.Orders.Where(O => O.OrderDate.Year >= 1998));

            ////2.Query Syntax
            // Result =  from C in CustomersList from O in C.Orders
            //              where O.OrderDate.Year>= 1998 select O;

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);
            #endregion


            #endregion


        }
    }
}
