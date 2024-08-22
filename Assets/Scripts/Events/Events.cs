using UnityEngine;

namespace Eventos
{
    

    //Se crea un evento nuevo
    public static class Events
    {
        public static EventoPrueba EventoPrueba = new EventoPrueba();
        public static TriggersEvents TriggersEvents = new TriggersEvents();

    }

    //Se definen las variables del evento
    public class EventoPrueba : GameEvent
    {
        public string StringPrueba;
        public int IntPrueba;
    }

    public class TriggersEvents : GameEvent
    {
        public string objeto;
    
    }
}
