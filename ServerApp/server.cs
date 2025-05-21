using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        TcpListener server = null;
        try
        {
            int port = 5000;

            // Create a TCP server that listens on all network interfaces and port 5000
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            Console.WriteLine("Server started. Waiting for a connection...");

            // Wait for a client to connect
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected!");

            // Get the stream to read/write data
            NetworkStream stream = client.GetStream();
            byte[] bytes = new byte[1024];
            int i;

            // Keep reading data from the client
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Convert bytes to string
                string message = Encoding.UTF8.GetString(bytes, 0, i);
                Console.WriteLine("Client: " + message);

                // Create a response and send it back
                string response = $"[Server received at {DateTime.Now:T}]: {message}";
                byte[] msg = Encoding.UTF8.GetBytes(response);
                stream.Write(msg, 0, msg.Length);
            }

            // Close client connection
            client.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            // Stop the server
            server?.Stop();
        }
    }
}
