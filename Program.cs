// See https://aka.ms/new-console-template for more information
//#error version
Console.WriteLine("Hello, World!");
string horizontalLine = new('-', count: 74);
Console.WriteLine(horizontalLine);

Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

string xml = """
 <person age="50">
 <first_name>Mark</first_name>
 </person>
 """;
Console.WriteLine(xml);

//page 112
var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
 {
 "first_name": "{{person.FirstName}}",
 "age": {{person.Age}},
 "calculation", "{{{1 + 2}}}"
 }
 """;
Console.WriteLine(json);

HttpClient client = new();

HttpResponseMessage response =
 await client.GetAsync("http://www.apple.com/");

WriteLine("Apple's home page has {0:N0} bytes.",
 response.Content.Headers.ContentLength);