using UnityEngine;

namespace Eventos
{
    

    //Se crea un evento nuevo
    public static class Events
    {
        public static EventoPrueba EventoPrueba = new EventoPrueba();

    }

    //Se definen las variables del evento
    public class EventoPrueba : GameEvent
    {
        public string StringPrueba;
        public int IntPrueba;
    }
}
