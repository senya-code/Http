var argsLength = args.Length;

if (argsLength == 0) Console.Error.WriteLine("Error: no arguments");

using (var client = new HttpClient())
{
    try
    {
        var url = "";

        if (argsLength == 1)
        {
            url = args[0];

            var msg = await client.GetAsync(url);

            Print("!----CONTENT----!");

            Console.WriteLine(await msg.Content.ReadAsStringAsync());

            Print("!----HEADERS----!");

            foreach (var header in msg.Headers)
            {
                Console.WriteLine($"{header.Key}: {header.Value.First()}");
            }
        }

        //if(args.Length == 2 && args[1].ToLower() == "post")
        //{
        //    url = args[0];

        //    var msg = await client.PostAsync(url, )

        //}


    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
    }
}

#region Methods

void Print(string text)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(text);
    Console.ResetColor();
    Console.WriteLine();
}

#endregion