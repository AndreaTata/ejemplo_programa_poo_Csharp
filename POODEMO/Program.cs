// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text;
using POODEMO;
using POODEMO.Models;

/*
Apuntador apuntadorPLatzi = new Apuntador();
Apuntador apuntadorPLatzi2 = new Apuntador();

apuntadorPLatzi.Color = "Negro";
apuntadorPLatzi2.Color = "Blanco";

class Apuntador
{
    public string Color;
    public double Largo;
    public short NumeroDeBotones;
    public bool TieneStickers;

    public Apuntador()
       {
        Color = " ";
        Largo = 0;
        NumeroDeBotones = 0;
        TieneStickers = false;
       }


}

*/

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "regeneracion";
regeneracion.Nivel = NivelPoder.NivelTres;



var superman = new SuperHeroe();
var Imprimir = new ImprimirInfo();



superman.Id = 1;
superman.Nombre = "   superman   ";
superman.IdentidadSecreta = "clark kent";
superman.Ciudad = "metropolis";
superman.PuedeVolar = true;

//var superman2 = new SuperHeroe();

//superman2.Id = 1;
//superman2.Nombre = "superman";
//superman2.IdentidadSecreta = "clark kent";
//superman2.Ciudad = "metropolis";
//superman2.PuedeVolar = true;

//Console.WriteLine(superman == superman2);

//SuperHeroeRecord superHeroeRecord = new(1, "SuperMan", "Clark Kent");
//SuperHeroeRecord superHeroeRecord2 = new(1, "SuperMan", "Clark Kent");

//Console.WriteLine(superHeroeRecord == superHeroeRecord2);


List<SuperPoder> poderessuperman = new List<SuperPoder>();
poderessuperman.Add(poderVolar);
poderessuperman.Add(superFuerza);
superman.SuperPoderes = poderessuperman;
superman.UsarSuperPoderes();
string resultsuperpoderes = superman.UsarSuperPoderes2();
Console.WriteLine(resultsuperpoderes);
string resultSalvarElMundo = superman.SalvarElMundo();
Console.WriteLine($"{resultSalvarElMundo}");
string resultSalvarLaTierra = superman.SalvarLaTierra();
Console.WriteLine($"{resultSalvarLaTierra}");

Imprimir.ImprimirSuperHeroe(superman);


var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> podereswolverine =  new List<SuperPoder>();
podereswolverine.Add(regeneracion);
podereswolverine.Add(superFuerza);
wolverine.SuperPoderes = podereswolverine;
resultsuperpoderes = wolverine.UsarSuperPoderes2();
Console.WriteLine(resultsuperpoderes);

string AccionAntihero = wolverine.RealizarAccionDeAntihero("Atacar a la policia");
Console.WriteLine(AccionAntihero);

Imprimir.ImprimirSuperHeroe(wolverine);



enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroeRecord (int Id, string Nombre, string IdentidadSecreta);