using SendPostRequest;
using System.Text;
using System.Text.Json;

var postData = new PostData
{
    Name = "John Doe",
    Age = 30,
    Address = "12 Main Str"
};

var client = new HttpClient();
client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

var json = JsonSerializer.Serialize(postData);
var content = new StringContent(json, Encoding.UTF8, "application/json");

var response = client.PostAsync("posts", content).Result;

if (response.IsSuccessStatusCode)
{
    var responseContent = response.Content.ReadAsStringAsync().Result;
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent, options);
    Console.WriteLine("Post successful! ID: " + postResponse.Id);
}
else
{
    Console.WriteLine("Error: " + response.StatusCode);
}