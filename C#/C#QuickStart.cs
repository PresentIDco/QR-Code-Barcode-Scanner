var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://qr-code-and-barcode-scanner.p.rapidapi.com/ScanCode"),
    Headers =
    {
        { "x-rapidapi-key", "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd" },
        { "x-rapidapi-host", "qr-code-and-barcode-scanner.p.rapidapi.com" },
    },
    Content = new MultipartFormDataContent
    {
        new StringContent("")
        {
            Headers =
            {
                ContentType = new MediaTypeHeaderValue("application/octet-stream"),
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "image",
                }
            }
        },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
