//C:\Proyectos\Csharp , ruta donde esta la Carpeta "ConceptsPoo"
using ConceptsPoo;

Console.WriteLine("Hello, World!");
Console.WriteLine("=============");

//Clase Program.cs es para probar las clases creadas
//Instancear un objeto de la clase Date.cs

//var date1 = new Date(2022,4,25); //Hay que pasarle los parametros de la clase date
//Date date1 = new Date(2022, 4, 25);
try
{
    Console.WriteLine(new Date(2022, 4, 25)); //Imprimir de manera directa la variable
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1974, 9, 9));
    Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

