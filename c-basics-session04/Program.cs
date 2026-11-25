using System;

class Program
{
    static void Main()
    {
        #region Question 1

        //double[] prices = { 25.5, 40.0, 33.75 };

        //Console.WriteLine(prices[1]);

        #endregion


        #region Question 2

        //int[,] shelfCopies =
        //{
        //    { 3, 5 },
        //    { 1, 4 }
        //};

        //Console.WriteLine(shelfCopies[1, 0]);

        #endregion


        #region Question 3

        //PrintWelcomeMessage();

        #endregion


        #region Question 4

        //PrintBookTitle("Clean Code");

        #endregion


        #region Question 5

        //int pages = 400;

        //AddBonusPages(pages);

        //Console.WriteLine(pages);

        // Expected 400. int is a value type, so the method gets a copy;
        // changing the copy doesn't affect the original.

        #endregion


        #region Question 6

        //double[] prices = { 25.5, 40.0 };

        //ApplyDiscount(prices);

        //Console.WriteLine(prices[0]);

        //Expected 20.5.Arrays are reference types, so the method gets a
        // copy of the reference to the SAME array; changing an element changes the original.

        #endregion


        #region Question 7

        //int refPages = 400;

        //AddBonusPagesByRef(ref refPages);

        //Console.WriteLine(refPages);

        //Expected 450. ref passes the variable itself (not a copy),
        // so the change is visible outside, unlike Q5 which stays 400.

        #endregion


        #region Question 8

        //double[] prices = { 25.5, 40.0 };

        //ReplaceArray(ref prices);

        //Console.WriteLine(prices.Length);

        #endregion


        #region Question 9

        //bool found = TryGetPrice("Clean Code", out double price);

        //if (found)
        //{
        //    Console.WriteLine(price);
        //}

        #endregion


        #region Question 10

        //PrintBookInfo("Clean Code");

        //PrintBookInfo("Clean Code", 500);

        #endregion


        #region Question 11

        //PrintBookInfo(pages: 500, title: "Clean Code");

        #endregion


        #region Question 12

        //PrintAllTitles("Clean Code", "C# in Depth", "The Pragmatic Programmer");

        #endregion
    }


    #region Question 3 Function

    //static void PrintWelcomeMessage()
    //{
    //    Console.WriteLine("Welcome to the Library!");
    //}

    #endregion


    #region Question 4 Function

    //static void PrintBookTitle(string title)
    //{
    //    Console.WriteLine("Book title: " + title);
    //}

    #endregion


    #region Question 5 Function

    static void AddBonusPages(int pages)
    {
        pages += 50;
    }

    #endregion


    #region Question 6 Function

    //static void ApplyDiscount(double[] prices)
    //{
    //    prices[0] -= 5;
    //}

    #endregion


    #region Question 7 Function

    //static void AddBonusPagesByRef(ref int pages)
    //{
    //    pages += 50;
    //}

    #endregion


    #region Question 8 Function

    //static void ReplaceArray(ref double[] prices)
    //{
    //    prices = new double[] { 10.0, 12.5, 15.0 };
    //}

    #endregion


    #region Question 9 Function

    //static bool TryGetPrice(string title, out double price)
    //{
    //    if (title == "Clean Code")
    //    {
    //        price = 25.5;
    //        return true;
    //    }

    //    price = 0;
    //    return false;
    //}

    #endregion


    #region Question 10 Function

    //static void PrintBookInfo(string title, int pages = 300)
    //{
    //    Console.WriteLine($"Title: {title}, Pages: {pages}");
    //}

    #endregion


    #region Question 12 Function

    //static void PrintAllTitles(params string[] titles)
    //{
    //    foreach (string title in titles)
    //    {
    //        Console.WriteLine(title);
    //    }
    //}

    #endregion
}