
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Biblioteca
{
    private String NomUsuario;
    private int CodUsuario;
    private String Libro;
    private int Dias_prestamo;

    public Biblioteca()
    {
        NomUsuario = "";
        CodUsuario = 0;
        Libro = "";
        Dias_prestamo = 0;
    }

    public void SetNomUsuario(String NomUsuario)
    {
        this.NomUsuario = NomUsuario;
    }
    public void SetCodUsuario(int CodUsuario)
    {
        this.CodUsuario = CodUsuario;
    }
    public void SetLibro(String Libro)
    {
        this.Libro = Libro;
    }
    public void SetDias_prestamo(int Dias_prestamo)
    {
        this.Dias_prestamo = Dias_prestamo;
    }

    public String GetNomUsuario()
    {
        return NomUsuario;
    }
    public int GetCodUsuario()
    {
        return CodUsuario;
    }
    public String GetLibro()
    {
        return Libro;
    }
    public int GetDias_prestamo()
    {
        return Dias_prestamo;
    }

}
