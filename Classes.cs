using System;

class Aula { 
    bool presenca = true;
    int nota = 7;
    double duracao = 35.5;
    string nome = "Aula 1";

    static void Main (string[] args) {
        Aula aula0 = new Aula();

        Console.WriteLine(aula0.duracao);
        Console.WriteLine(aula0.presenca);
        Console.WriteLine(aula0.nota);
        Console.WriteLine(aula0.nome);


    }



}