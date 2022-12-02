using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Archivo
{
    private FileStream primArchivo;
    private BinaryFormatter Convertidor;

    public bool GuardarRegistro(Biblioteca primUsuario)
    {
        try
        {
            primArchivo = new FileStream("Archivo.dat", FileMode.OpenOrCreate, FileAccess.Write);
            Convertidor = new BinaryFormatter();
            Convertidor.Serialize(primArchivo, primUsuario);
            primArchivo.Close();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    public Biblioteca LeerUsuario()
    {
        Biblioteca primUsuario = null;
        try
        {
            primArchivo = new FileStream("Archivo.dat", FileMode.Open, FileAccess.Read);
            Convertidor = new BinaryFormatter();
            primUsuario = (Biblioteca)Convertidor.Deserialize(primArchivo);
            primArchivo.Close();
            return primUsuario;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }

}