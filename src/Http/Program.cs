using (var client = new HttpClient())
{
    var url = args[0];
    
    var msg = await client.GetAsync(url);

    Console.WriteLine(await msg.Content.ReadAsStringAsync());
}
