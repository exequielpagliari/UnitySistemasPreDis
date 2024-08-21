using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFade : MonoBehaviour
{
    [SerializeField] FadeToBlack fadeToBlack;
    // Start is called before the first frame update
    void Start()
    {
        fadeToBlack.FadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
