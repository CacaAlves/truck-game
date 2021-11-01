using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaStates
{
    public static MusicaTocandoState musicaTocando = new MusicaTocandoState(true);

    public static void TocarMusica()
    {
        musicaTocando.setValue(true);
    }
    public static void PararMusica()
    {
        musicaTocando.setValue(false);
    }

    public static bool musicaEstaTocando()
    {
        return musicaTocando.value;
    }
}