using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class certificacao : MonoBehaviour
{
    public Sprite[] certificacoes;
    public Image imagem;


    /*Esse script vai ser para colocar a certificação certa*/

    private void Awake()
    {
        const int nivel = PlayerPrefs.GetInt("nivel");
        imagem.sprite = certificacoes[nivel-1];

    }

}
