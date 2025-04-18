// See https://aka.ms/new-console-template for more information

using csharp14;

Console.WriteLine("Hello, World!");


// Fields
try
{
    var fieldKeywork = new FieldKeyword();
    fieldKeywork.Stock = -1;
    fieldKeywork.Stock2 = 100;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//Result = Stock must be greater than 0 (Parameter 'value')


//nameof
var nameOfList = nameof(List<>); //Result List
var nameOfFieldKeyword = nameof(List<FieldKeyword>); //Result List
var nameInterface = nameof(NameofInterface<>); //Result NameofInterface
var nameInterface2 = nameof(NameofInterface2<,>); //Result NameofInterface2
Console.WriteLine(nameInterface2);


//Simple lambda parameters with modifiers
TryParse<int> parse = (string text, out int result ) => Int32.TryParse(text, out result);
parse("2", out int result);
Console.WriteLine(result); //Result 2

//Null condition
FieldKeyword fieldKeyword = null;
fieldKeyword?.Stock = 2;

internal delegate bool TryParse<T>(string text, out T result);