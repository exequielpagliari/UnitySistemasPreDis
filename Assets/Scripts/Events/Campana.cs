using Eventos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Campana : MonoBehaviour
{
    [SerializeField] string stringTrigger;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        EventManager.AddListener<TriggersEvents>(RecepcionEvento);
    }

    void ActivarGravedad()
    {
        rb.useGravity = true;
    }

    void RecepcionEvento(TriggersEvents evt)
    {
        Debug.Log(evt.objeto);
        if(evt.objeto == stringTrigger)
            ActivarGravedad();
    }
}
