using System;
using System.Net.Sockets;
using System.Text;

class Client
{
    static void Main()
    {
        try
        {
            // Connect to the server (localhost on port 5000)
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            Console.WriteLine("Connected to the server!");

            // Get the stream to send/receive data
            NetworkStream stream = client.GetStream();

            while (true)
            {
                // Read input from the user
                Console.Write("You: ");
                string message = Console.ReadLine();

                // Exit if the user types "exit"
                if (message.ToLower() == "exit") break;

                // Convert message to bytes and send it to the server
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                // Receive response from the server
                byte[] responseData = new byte[1024];
                int bytes = stream.Read(responseData, 0, responseData.Length);
                Console.WriteLine(Encoding.UTF8.GetString(responseData, 0, bytes));
            }

            // Close stream and connection
            stream.Close();
            client.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
