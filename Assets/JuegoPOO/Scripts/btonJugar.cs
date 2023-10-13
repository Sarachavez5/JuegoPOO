using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;



public class btonJugar : MonoBehaviour
{
    public void OnJugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel1");
    }

    public void IrInstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

    public void IrAInicio()
    {
        MMSceneLoadingManager.LoadScene("Inicio");
    }

    public void IrACreditos()
    {
        MMSceneLoadingManager.LoadScene("creditos");
    }
}
