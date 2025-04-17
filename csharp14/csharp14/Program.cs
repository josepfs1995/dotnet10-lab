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
