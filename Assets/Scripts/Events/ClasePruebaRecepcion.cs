

using System.Collections;
using System.Collections.Generic;
using Eventos;
using UnityEngine;

public class ClasePruebaRecepcion : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //Se suscribe a un evento
        EventManager.AddListener<EventoPrueba>(RecepcionEvento);
    }


    //Se crea el método para recibir el evento.
    void RecepcionEvento(EventoPrueba evt)
    {
        Debug.Log("La String recivida es  " + evt.StringPrueba + "  y el int enviado tiene el valor de " + evt.IntPrueba);
    }
}
