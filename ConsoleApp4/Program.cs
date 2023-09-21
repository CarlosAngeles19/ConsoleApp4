using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese el numero de notas :");
        string numerotxt = Console.ReadLine();
        int numero =int.Parse(numerotxt);

        int sumadenotas = 0;
        int promedio = 0;
        
        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine("ingrese la nota :");
            int nota= int.Parse(Console.ReadLine());
            sumadenotas += nota;
      
        }
        promedio=sumadenotas/numero;
        Console.WriteLine("El promedio es :" + promedio);
        Console.ReadKey();
        
        

        


    }
}