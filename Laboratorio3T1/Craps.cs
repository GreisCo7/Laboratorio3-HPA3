using System;

public class Craps
{
    private Random numerosAleatorios = new Random();

    private enum Estado { CONTINUA, GANO, PERDIO }

    private enum NombresDados
    {
        DOS_UNOS = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12

    }

    public void Jugar()
    {
        Estado estadoJuego = Estado.CONTINUA;

        int miPunto = 0;

        // Primer tiro de los dados
        int sumaDeDados = TirarDados();

        // Determina el estado del juego con base en el primer tiro (Conversión explícita o casting)
        switch ((NombresDados)sumaDeDados)
        {
            case NombresDados.SIETE:
            case NombresDados.ONCE:
                estadoJuego = Estado.GANO;
                break;

            case NombresDados.DOS_UNOS:
            case NombresDados.TRES:
            case NombresDados.DOCE:
                estadoJuego = Estado.PERDIO;
                break;

            default: 
                estadoJuego = Estado.CONTINUA;
                miPunto = sumaDeDados;
                Console.WriteLine($"El punto es {miPunto}");
                break;
        }

       
        while (estadoJuego == Estado.CONTINUA)
        {
            sumaDeDados = TirarDados(); // Lanzamiento de dados otra vez

            // Determina el estado del juego actual
            if (sumaDeDados == miPunto)
            {
                estadoJuego = Estado.GANO; // Gana por hacer su punto
            }
            else if (sumaDeDados == (int)NombresDados.SIETE)
            {
                estadoJuego = Estado.PERDIO; // Pierde si saca 7 antes de su punto
            }
        }

        // Muestra el mensaje final de victoria o derrota
        if (estadoJuego == Estado.GANO)
        {
            Console.WriteLine("El jugador gana");
        }
        else
        {
            Console.WriteLine("El jugador pierde");
        }
    }

    // MÉTODO AUXILIAR PARA TIRAR LOS DADOS
    public int TirarDados()
    {
        int dado1 = numerosAleatorios.Next(1, 7); // Rango de 1 a 6
        int dado2 = numerosAleatorios.Next(1, 7);

        int suma = dado1 + dado2;

        // Muestra los resultados de este lanzamiento
        Console.WriteLine($"El jugador lanzó {dado1} + {dado2} = {suma}");

        return suma; // Devuelve la suma de los dados
    }
}