using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFullScreenOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public bool fullScreen;

    void Start()
    {
        Screen.fullScreen = fullScreen;
    }
}
