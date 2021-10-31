using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// Necessary imports
using System;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;

// Laertes-Rodrigo essa classe é responsável por realizar o select para o Login no jogo

public class SelectDB : MonoBehaviour
{
    private IDataReader reader; // leitor
    [SerializeField] private InputField nome;
    [SerializeField] private InputField senha;
    public Text buttonText;

    void Start()
    {
        Logar();
    }

    public void Logar()
    {
        // string connectionString = "URI=file:" + Application.dataPath + "/truck_learning.db";
        int id_encontrado = 0;

        // connection = new SqliteConnection(connectionString);
        // command = connection.CreateCommand();
        // connection.Open();
        MyDBConnection connection = MyDBConnection.Instance;

        string query = "SELECT id FROM usuario WHERE nome = '"+ nome.text +"' AND senha = '"+ senha.text +"';";
        // command.CommandText = query;
        // reader = command.ExecuteReader();
        reader = connection.ExecuteReader(query);

        if (reader.Read())
        {
            id_encontrado = reader.GetInt32(0);
        }

        if (id_encontrado > 0)
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetString("nome", nome.text);
            PlayerPrefs.SetInt("nivel", 0);
            PlayerPrefs.SetInt("frase", 0);
            SceneManager.LoadScene("D_DIFICIL");
        } else 
        {
            SetTextValidacao();
        }

        // reader.Close();
        // command.Dispose();
        // connection.Close();
        connection.CloseReader();
    }

    public void SetTextValidacao()
    {
        buttonText.text = "Usuário não encontrado";
    }
}