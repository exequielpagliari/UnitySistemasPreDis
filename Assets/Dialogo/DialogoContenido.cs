using Dialogo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dialogo
{ 
    public class DialogoContenido : MonoBehaviour
    {
        [TextArea(3, 10)]
        [SerializeField] List<string> dialogo = new List<string>();
        [SerializeField] List<Sprite> images = new List<Sprite>();
        [SerializeField] ControladorDialogo controladorDialogo;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                controladorDialogo.PrepararDialogo(dialogo, images);
            }
        }
    }
}