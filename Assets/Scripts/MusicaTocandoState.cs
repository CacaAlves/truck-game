using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaTocandoState
{
    public bool value;

    public MusicaTocandoState(bool value)
    {
        this.value = value;
    }

    public void setValue(bool newValue)
    {
        value = newValue;
    }
}
