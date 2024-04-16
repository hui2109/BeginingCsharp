using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Ch07Ex02
{
    internal class Program
    {
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };

        static void Main(string[] args)
        {
            foreach (string eType in eTypes)
            {
                try
                {
                    Console.WriteLine("Main() try block reached.");  // line 15
                    Console.WriteLine($"ThrowException(\"{eType}\") called.");
                    ThrowException(eType);
                    Console.WriteLine("Main() try block continues.");  // line 18
                }
                catch (System.IndexOutOfRangeException e) when (eType == "filter")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Main() FILLTERED System.IndexOutOfRangeException catch " + $"block readched. Message: \n\"{e.Message}\"");
                    Console.ResetColor();
                }
                catch (System.IndexOutOfRangeException e)  // line 27
                {
                    Console.WriteLine("Main() System.IndexOutOfRangeException catch " + $"block reached. Message: \n\"{e.Message}\"");
                }
                catch  // 完全省略错误类型, 让通用的 catch 块响应所有异常
                {
                    Console.WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    Console.WriteLine("Main() finally block reached.\n");
                }
            }
        }

        static void ThrowException(string exceptionType)
        {
            Console.WriteLine($"ThrowException(\"{exceptionType}\") reached.");
            switch (exceptionType)
            {
                case "none":
                    Console.WriteLine("Not throwing an exception.");
                    break;
                case "simple":
                    Console.WriteLine("Throwing System.Exception.");
                    throw new System.Exception();
                case "index":
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error";
                    break;
                case "nested index":
                    try
                    {
                        Console.WriteLine("ThrowException(\"nested index\") " + "try block reached.");
                        Console.WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("ThrowException(\"nested index\") general " + "catch block reached.");
                        throw;  // 将错误再次抛出去
                    }
                    finally
                    {
                        Console.WriteLine("ThrowException(\"nested index\") finally block reached.");
                    }
                    break;
                case "filter":
                    try
                    {
                        Console.WriteLine("ThrowException(\"filter\") " + "try block reached.");
                        Console.WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        Console.WriteLine("ThrowException(\"filter\") general " + "catch block reached.");
                        throw;  // 将错误再次抛出去
                    }
                    break;
            }
        }
    }
}
