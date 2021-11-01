using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetaFraseBalaoCommand
{
    public void Execute(int fraseNumero)
    {
        DicasControl.Instance.setaFraseBalao(fraseNumero);
    }
}
