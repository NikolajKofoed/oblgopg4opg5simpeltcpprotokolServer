using oblgopg4opg5simpeltcpprotokol;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;



#region with json
//TcpListener listener = new TcpListener(IPAddress.Any, 7);
//listener.Start();

//while (true)
//{
//    TcpClient socket = await listener.AcceptTcpClientAsync();
//    _ = Task.Run(() => HandleClient(socket));
//}

//void HandleClient(TcpClient socket)
//{
//    try
//    {
//        using (NetworkStream ns = socket.GetStream())
//        using (StreamReader reader = new StreamReader(ns))
//        using (StreamWriter writer = new StreamWriter(ns))
//        {
//            writer.AutoFlush = true; // Ensure immediate sending of messages

//            while (true)
//            {
//                string msg = reader.ReadLine();

//                string response = "default";

//                if (IsValidJson(msg))
//                {
//                    Data data = JsonSerializer.Deserialize<Data>(msg);


//                    if (data.Method == "add")
//                    {
//                        int result = data.Numbers[0] + data.Numbers[1];
//                        response = $"Result of adding: {result}";
//                    }
//                    else if (data.Method == "subtract")
//                    {
//                        int result = data.Numbers[0] - data.Numbers[1];
//                        response = $"Result of subtracting: {result}";
//                    }
//                    else if (data.Method == "random")
//                    {
//                        Random rnd = new Random();

//                        if (data.Numbers[0] < data.Numbers[1])
//                        {
//                            int result = rnd.Next(data.Numbers[0], data.Numbers[1] + 1);
//                            response = $"Result of random: {result}";
//                        }
//                        else
//                        {
//                            response = "Invalid values, first number must be lower than second number";
//                        }
//                    }
//                    else
//                    {
//                        response = "Unknown action!";
//                    }
//                }
//                writer.WriteLine(response);
//            }
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);

//    }
//    finally
//    {
//        socket.Close();  // Ensure the socket is closed
//    }
//}

//bool IsValidJson(string jsonString)
//{
//    try
//    {
//        // Try to parse the string as JSON using JsonDocument
//        using (JsonDocument doc = JsonDocument.Parse(jsonString))
//        {
//            return true;  // Valid JSON if no exception is thrown
//        }
//    }
//    catch (JsonException)
//    {
//        // If an exception occurs, the JSON is invalid
//        return false;
//    }
//    catch (ArgumentNullException)
//    {
//        // Handle null input
//        return false;
//    }
//}
#endregion

#region without json
//TcpListener listener = new TcpListener(IPAddress.Any, 7);
//listener.Start();

//while (true)
//{
//    TcpClient socket = await listener.AcceptTcpClientAsync();
//    _ = Task.Run(() => HandleClient(socket));
//}

//void HandleClient(TcpClient socket)
//{
//    try
//    {
//        using (NetworkStream ns = socket.GetStream())
//        using (StreamReader reader = new StreamReader(ns))
//        using (StreamWriter writer = new StreamWriter(ns))
//        {
//            writer.AutoFlush = true; // Ensure immediate sending of messages

//            while (true)
//            {
//                string message = reader.ReadLine();
//                Console.WriteLine("Received: " + message);

//                if (message == null || message.Trim().ToLower() == "quit")
//                {
//                    Console.WriteLine("Client disconnected.");
//                    break;  // Exit the loop if "QUIT" is received
//                }
//                else if (message.Trim().ToLower() == "add")
//                {
//                    writer.WriteLine("Input 2 Numbers (formatted as:<number> <number>)");
//                    Console.WriteLine("Sent: Input 2 Numbers (formatted as:<number> <number>)");

//                    (int, int) nums = ReturnTwoNumbers(reader, writer);

//                    // Calculate the result
//                    int result = nums.Item1 + nums.Item2;
//                    writer.WriteLine($"The result is: {result}");
//                    Console.WriteLine($"Sent: The result is {result}");

//                }
//                else if(message.Trim().ToLower() == "random")
//                {
//                    writer.WriteLine("Input 2 numbers (formatted as:<number> <number>)");
//                    Console.WriteLine("Sent: Input 2 Numbers (formatted as:<number> <number>)");

//                    Random rnd = new Random();

//                    (int, int) nums = ReturnTwoNumbers(reader, writer);

//                    if(nums.Item1 < nums.Item2)
//                    {
//                        // calculate result
//                        int result = rnd.Next(nums.Item1, nums.Item2 + 1);
//                        writer.WriteLine($"The result is: {result}");
//                        Console.WriteLine($"Sent: The result is {result}");
//                    }
//                    else
//                    {
//                        writer.WriteLine("Invalid input, first number must be lower than second number");
//                    }

//                }
//                else if (message.Trim().ToLower() == "subtract")
//                {

//                    writer.WriteLine("Input 2 numbers (formatted as:<number> <number>)");
//                    Console.WriteLine("Sent: Input 2 Numbers (formatted as:<number> <number>)");

//                    (int, int) nums = ReturnTwoNumbers(reader, writer);

//                    //calculate result
//                    int result = nums.Item1 - nums.Item2;
//                    writer.WriteLine($"The result is: {result}");
//                    Console.WriteLine($"Sent: The result is {result}");

//                }
//                else
//                {
//                    writer.WriteLine("default response");
//                }
//            }

//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Error: " + ex.Message);

//    }
//    finally
//    {
//        socket.Close();  // Ensure the socket is closed
//    }
//}


//(int,int) ReturnTwoNumbers(StreamReader reader, StreamWriter writer)
//{
//    string numbersMessage;
//    int num1 = 0, num2 = 0;

//    while (true)
//    {
//        numbersMessage = reader.ReadLine();
//        Console.WriteLine("Received: " + numbersMessage);

//        string[] numbers = numbersMessage.Split(' '); // Split the input by spaces

//        // Check for valid input
//        if (numbers.Length == 2 &&
//            int.TryParse(numbers[0], out num1) &&
//            int.TryParse(numbers[1], out num2))
//        {
//            // Valid input, exit the loop
//            break;
//        }
//        else
//        {
//            writer.WriteLine($"Invalid input: {numbersMessage}");
//            Console.WriteLine($"Sent: Invalid input {numbersMessage}");
//        }
//    }

//    return (num1, num2);
//}
#endregion

