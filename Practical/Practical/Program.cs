using Practical;
using Practical.Controller;
using Practical.Exceptions;
using Practical.Helpers.Constants;
using Practical.Models;
using System.Runtime.InteropServices;

#region Indexer
//Library library = new Library();

//Book book = new Book();
//book.Id = 1;
//book.Name = "Test";

//library[0] = book;

//Console.WriteLine(library[0].Name);

#endregion


//try
//{
//    int[] nums = new int[0];

//    nums[2] = 0;
    
//    int a = 5;
//	int b = 0;

//	//int result = a / b;

// //   Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//finally
//{
//    Console.WriteLine("example");
//}


static void Login(string username, string password)
{
	bool isSuccess = false;
    try
	{
        if (username == "examples123")
        {
            Console.WriteLine("Login was successful");
            isSuccess = true;
        }
        else
        {
            throw new RegisterFailedException();
        }
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }

    finally
    {
        SendEmail(isSuccess);
    }
}

//Login("example123", "example123");

static void SendEmail(bool isSuccess)
{
    if(isSuccess)
    {
        Console.WriteLine(AccountMessages.RegisterEmailSuccess);
    }
    else
    {
        Console.WriteLine(AccountMessages.RegisterEmailFailed);
    }
}


static void ShowText(string text)
{
    try
    {
        if (text is null)
        {
            throw new ArgumentNullException();
        }
        else
        {
            Console.WriteLine(text);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

//ShowText("Hello World!");
//ShowText(null);

PersonController personController = new PersonController();

personController.GetById(); 