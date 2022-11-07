using ConceptsPOO;


Console.WriteLine("Hello, World!");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2022, 12, 6));
    Console.WriteLine(new Date(2022, 11, 6));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}