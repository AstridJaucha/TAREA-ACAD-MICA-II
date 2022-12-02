
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

class program
{
    private Biblioteca primUsuario;
    private Archivo primArchivo;

    public program()
    {
        primArchivo = new Archivo();
    }

    public void Registro()
    {
        primUsuario = new Biblioteca();
        primUsuario.SetNomUsuario("Kilian");
        primUsuario.SetCodUsuario(1234);
        primUsuario.SetLibro("El Principito");
        primUsuario.SetDias_prestamo(5);
        primArchivo.GuardarRegistro(primUsuario);

        primUsuario = primArchivo.LeerUsuario();
        if (primUsuario != null)
        {
            Console.Write("El usuario " + primUsuario.GetCodUsuario()
                + " llamado " + primUsuario.GetNomUsuario()
                + ", pidio prestado el libro " + primUsuario.GetLibro() + " por "
                + primUsuario.GetDias_prestamo() + " días.");

        }
        Console.ReadKey();
    }
    static void Main(string[] args) { 
        program primProgram = new program();
        primProgram.Registro();
    }
    
   
}
