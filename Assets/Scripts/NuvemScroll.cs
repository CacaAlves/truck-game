using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemScroll : MonoBehaviour
{
    public float velocidade = 0.05f;
    public Renderer quad;


    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(velocidade * Time.deltaTime, 0);
        quad.material.mainTextureOffset -= offset;
    }

}
