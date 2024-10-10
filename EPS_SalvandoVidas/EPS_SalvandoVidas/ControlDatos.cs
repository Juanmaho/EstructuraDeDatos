using System.Collections.Generic;

using EPS_SalvandoVidas;

public class ControlDatos
{
    public Stack<EstructuraDatosUsuario> pilaUsuarios = new Stack<EstructuraDatosUsuario>();
    public Queue<EstructuraDatosUsuario> colaUsuarios = new Queue<EstructuraDatosUsuario>();
    public List<EstructuraDatosUsuario> listaUsuarios = new List<EstructuraDatosUsuario>();

    // Métodos para registrar en las estructuras
    public void RegistrarEnPila(EstructuraDatosUsuario usuario)
    {
        pilaUsuarios.Push(usuario);
    }

    public void RegistrarEnCola(EstructuraDatosUsuario usuario)
    {
        colaUsuarios.Enqueue(usuario);
    }

    public void RegistrarEnLista(EstructuraDatosUsuario usuario)
    {
        listaUsuarios.Add(usuario);
    }

    // Métodos para eliminar datos
    public EstructuraDatosUsuario EliminarDePila()
    {
        return pilaUsuarios.Pop();
    }

    public EstructuraDatosUsuario EliminarDeCola()
    {
        return colaUsuarios.Dequeue();
    }

    public void EliminarDeLista(string numeroIdentificacion)
    {
        listaUsuarios.RemoveAll(u => u.NumeroIdentificacion == numeroIdentificacion);
    }
    public decimal CalcularSumaCopagosPila()
    {
        decimal suma = 0;
        foreach (var usuario in pilaUsuarios)
        {
            suma += CalcularCopago(usuario.Estrato, usuario.TipoAtencion);
        }
        return suma;
    }

    public int CalcularCantidadCola()
    {
        return colaUsuarios.Count;
    }

    public double CalcularPromedioEdadLista()
    {
        if (listaUsuarios.Count == 0) return 0;
        int sumaEdades = 0;
        foreach (var usuario in listaUsuarios)
        {
            sumaEdades += usuario.Edad;
        }
        return (double)sumaEdades / listaUsuarios.Count;
    }
    public decimal CalcularCopago(int estrato, string tipoAtencion)
    {
        decimal copago = 0;
        if (tipoAtencion == "Medicina General")
        {
            switch (estrato)
            {
                case 1:
                case 2: copago = 0; break;
                case 3: copago = 10000; break;
                case 4: copago = 15000; break;
                case 5: copago = 20000; break;
                case 6: copago = 30000; break;
            }
        }
        else if (tipoAtencion == "Examen Laboratorio")
        {
            switch (estrato)
            {
                case 1:
                case 2:
                case 3: copago = 0; break;
                case 4: copago = 5000; break;
                case 5: copago = 10000; break;
                case 6: copago = 20000; break;
            }
        }
        return copago;
    }
}
