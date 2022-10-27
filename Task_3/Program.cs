using Logger;
using System.Reflection;

class Program
{
    static void Main()
    {
        var logger = new Logger.Logger();

        logger.Info("Program", "Hello world");
        logger.Warning("Program", "Warning message!");

        try
        {
            throw new Exception();
        }
        catch (Exception exception)
        {
            logger.LogException("Program", exception, false);
        }

        logger.Debug("Program", "Debug log");

        Console.ReadKey();
    }
}