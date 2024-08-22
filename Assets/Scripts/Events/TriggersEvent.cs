using Eventos;
using UnityEngine;

public class TriggersEvent : MonoBehaviour
{
    [SerializeField] string stringEvento;
    public void SendTriggerEvent()
    {
        TriggersEvents evt = Events.TriggersEvents;
        evt.objeto = stringEvento;
        EventManager.Broadcast(evt);
        Debug.Log("La String enviada es  " + evt.objeto);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            SendTriggerEvent();
    }
}
