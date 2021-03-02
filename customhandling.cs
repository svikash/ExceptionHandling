using System;
using System.IO;

public class CustomException
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("Already login no duplicate session ");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }

}
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }
   public UserAlreadyLoggedInException(string message) : base(message)
    {

    } 

    public UserAlreadyLoggedInException(string message,Exception innerException) : base(message, innerException)
    {

    }
}
