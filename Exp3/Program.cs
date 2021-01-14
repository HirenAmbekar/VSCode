using System;
using Server;

namespace client {
    class program
    {
        public void client()
        {
            Console.WriteLine("client is ready");
            
        }
    }
}

namespace Server
{ class program
    { public void server()
        { 
            Console.WriteLine("Server is ready");
           
        }
    }
}

public class Test
{
    public static void Main()
    {
     
        client.program p2 = new client.program();
        program p3 = new program();
        p2.client();
        p3.server();
        Console.ReadLine();
    }
}
