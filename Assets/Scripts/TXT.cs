using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/*
Essa classe faz o registro dos logs em um arquivo txt.
*/


public class TXT : MonoBehaviour
{
   private string path;

    public static TXT Instance;
    private void Start()
    {
        Instance = this;
        path = Application.dataPath + "/Log.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Registros \n");
        }
    }

    public void SalvaNomeHora()
    {
        File.AppendAllText(path, "Nome: " + PlayerPrefs.GetString("nome")+" ");
        File.AppendAllText(path, "Entrada: " + System.DateTime.Now + "\n");

    }

    public void SalvaSaida()
    {
        File.AppendAllText(path, "Nome: " + PlayerPrefs.GetString("nome") + " ");
        File.AppendAllText(path, "Saida: " + System.DateTime.Now + " ");
        File.AppendAllText(path, "Nivel que parou: " + PlayerPrefs.GetInt("nivel") + "\n");

    }

    public void SalvaNota()
    {

        File.AppendAllText(path, "Nome: " + PlayerPrefs.GetString("nome") + " ");
        File.AppendAllText(path, "Nivel: " + PlayerPrefs.GetInt("nivel") + " ");
        File.AppendAllText(path, "Nota: " + PlayerPrefs.GetInt("nota") + "\n");
    }

}
