using Dialogo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorDialogo : MonoBehaviour
{
    [SerializeField] ControladorDialogo controladorDialogo;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Tecla Dialogo Apretada");
            controladorDialogo.AccionDialogo();

        }
    }


}
