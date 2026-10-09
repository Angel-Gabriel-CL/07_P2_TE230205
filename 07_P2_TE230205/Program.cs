Console.WriteLine("SIMULACIÓN DE BRAZO ROBÓTICO");
Console.WriteLine();

// Crear un objeto de la clase BrazoRobotico
BrazoRobotico brazo1 = new BrazoRobotico();

// Capturar la información del objeto
Console.Write("Ingrese el tiempo de la etapa tomar (s): ");
brazo1.TiempoTomar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo de la etapa trasladar (s): ");
brazo1.TiempoTrasladar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo de la etapa soltar (s): ");
brazo1.TiempoSoltar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el número de ciclos a simular: ");
brazo1.NumeroCiclos = Convert.ToInt32(Console.ReadLine());

// Mostrar resultados llamando al método del objeto
brazo1.SimularCiclos();

// Definición de la clase BrazoRobotico
class BrazoRobotico
{
    // Propiedades
    public double TiempoTomar { get; set; }
    public double TiempoTrasladar { get; set; }
    public double TiempoSoltar { get; set; }
    public int NumeroCiclos { get; set; }

    // Calcular el tiempo de un solo ciclo
    public double CalcularTiempoCiclo()
    {
        return TiempoTomar + TiempoTrasladar + TiempoSoltar;
    }

    // Simular el proceso con un ciclo for y mostrar resultados
    public void SimularCiclos()
    {
        if (NumeroCiclos <= 0)
        {
            Console.WriteLine("\nEl número de ciclos debe ser mayor a cero.");
            return;
        }

        double tiempoCiclo = CalcularTiempoCiclo();
        double tiempoAcumulado = 0;

        Console.WriteLine();
        Console.WriteLine("--- RESULTADOS DE PRODUCCIÓN ---");
        for (int i = 1; i <= NumeroCiclos; i++)
        {
            tiempoAcumulado += tiempoCiclo;
            Console.WriteLine($"Ciclo {i} completado. Tiempo acumulado: {tiempoAcumulado:F2} s");
        }
        Console.WriteLine($"Tiempo total de producción: {tiempoAcumulado:F2} s");
    }
}