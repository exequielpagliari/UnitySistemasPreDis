using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Dialogo
{


    public class ControladorDialogo : MonoBehaviour
    {
        [SerializeField] GameObject panelUI;
        [SerializeField] TMP_Text textoTMP;
        [SerializeField] Image imageUI;

        Queue<string> stringQueue;
        Queue<Sprite> spriteQueue;
        List<string> stringList;
        List<Sprite> spriteList;
        bool dialogoIniciado = false;
        // Start is called before the first frame update
        void Start()
        {
            panelUI.SetActive(dialogoIniciado);
        }


        public void AccionDialogo()
        {
            Debug.Log("Acción Diálogo");
            if (!dialogoIniciado)
                IniciarDialogo();
            else
                ContinuarDialogo();
        }


        private void IniciarDialogo()
        {
            if (stringList != null || spriteList != null)
            {
                dialogoIniciado = true;
                panelUI.SetActive(dialogoIniciado);
                Debug.Log("Inicia Diálogo");
                ExtraerDialogo();
            }
        }

        private void ExtraerDialogo()
        {
            string linea = stringQueue.Dequeue();
            Sprite sprite = spriteQueue.Dequeue();
            Debug.Log(linea);
            textoTMP.text = linea;
            imageUI.sprite = sprite;
        }

        private void ContinuarDialogo()
        {

            if (stringQueue.Count > 0)
            {
                Debug.Log("Continúa Diálogo");
                ExtraerDialogo();
            }
            else
            {
                TerminarDialogo();
            }
            
        }

        private void TerminarDialogo()
        {
            Debug.Log("Termina Diálogo");
            dialogoIniciado = false;
            panelUI.SetActive(dialogoIniciado);
            CargarQueue();
        }

        public void PrepararDialogo(List<string> listStringIn, List<Sprite> listSpriteIn)
        {
            spriteList = listSpriteIn.ToList();
            stringList = listStringIn.ToList();
            CargarQueue();


        }

        private void CargarQueue()
        {
            stringQueue = new Queue<string>(stringList);
            spriteQueue = new Queue<Sprite>(spriteList);
            Debug.Log(stringQueue.Count);
            Debug.Log(spriteQueue.Count);
        }
    }


}
