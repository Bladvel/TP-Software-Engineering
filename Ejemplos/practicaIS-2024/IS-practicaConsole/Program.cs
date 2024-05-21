// See https://aka.ms/new-console-template for more information
using Examen.BE;
using Examen.BLL;

Console.WriteLine("Hello Gente!");
Gestor _gestor = new Gestor();
var persona = new Usario();
Console.WriteLine($"Ingrese su Nombre");
persona.Nombre = Console.ReadLine();
//llamo a la BBLL
Console.WriteLine($"Ingrese su Apellido");
persona.Apellido = Console.ReadLine();
Console.WriteLine($"Ingrese su Edad");
persona.Edad = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Bienvenido a la Clase de IS: {persona.Nombre} {persona.Apellido} y su {persona.Edad} !!!!");

_gestor.GrabarPersona(persona);

Console.WriteLine($"La Persona fue grabada con éxito!!");
var seguir = "si"; 
while(seguir == "si")
{
	Console.WriteLine($"Desea Continuar!!");
	seguir = Console.ReadLine();
}
