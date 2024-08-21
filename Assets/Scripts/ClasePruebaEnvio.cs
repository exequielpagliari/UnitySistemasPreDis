

using System;
using Eventos;
using UnityEngine;

public class ClasePruebaEnvio : MonoBehaviour
{ // Se crea una referencia al evento
    

    public int restantes = 5;
    public string stringPrueba;

    private void Start()
    {
        stringPrueba = "Hola";
    }

    public void PruebaEvent()
    {
        /*
         * 
         * 
         * Se crea un método donde se llama al evento 
         * referido más arriba. Se cargan las variables
         * y luego se hace un Broadcast con ese evento
         * llamado evt
         * 
         * 
         */
        EventoPrueba evt = Events.EventoPrueba;
        evt.IntPrueba = restantes;
        evt.StringPrueba = stringPrueba;
        EventManager.Broadcast(evt);
        Debug.Log("La String enviada es  " + evt.StringPrueba + "  y el int enviado tiene el valor de " + evt.IntPrueba);

    }
}
