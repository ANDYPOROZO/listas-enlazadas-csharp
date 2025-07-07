using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
            cabeza = nuevo;
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
    }

    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    public int BuscarOcurrencias(int valor)
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == valor)
                contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Insertar(3);
        lista.Insertar(7);
        lista.Insertar(3);
        lista.Insertar(1);
        lista.Insertar(3);

        Console.WriteLine("Lista enlazada:");
        lista.Mostrar();

        Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());

        int valorBuscado = 3;
        int ocurrencias = lista.BuscarOcurrencias(valorBuscado);
        Console.WriteLine($"El valor {valorBuscado} aparece {ocurrencias} veces.");
    }
}
