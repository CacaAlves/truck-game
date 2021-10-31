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

// Laertes-Rodrigo: essa classe é responsável pela conexão com o banco e criação da tabela dos usuários

public class MyDBConnection : MonoBehaviour
{
    public static MyDBConnection Instance { get; private set; }
    private IDbConnection connection; // variável para fazer a conexão com o banco
    private IDbCommand command; // variável que vai dar o comando para o banco
    private IDataReader reader; // leitor

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        OpenConnection();

    }

    public IDataReader ExecuteReader(string query) 
    {
        command.CommandText = query;
        reader = command.ExecuteReader();
        return reader;
    }

    public void OpenConnection()
    {
        string connectionString = "URI=file:" + Application.dataPath + "/truck_learning.db";

        connection = new SqliteConnection(connectionString);
        command = connection.CreateCommand();
        connection.Open();
    }

    public void CloseReader()
    {
        reader.Close();
    }

    public void DisposeCommand()
    {
        command.Dispose();
    }

    public void CloseConnection() 
    {
        connection.Close();
    }

}
