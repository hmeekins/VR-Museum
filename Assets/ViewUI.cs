using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewUI : MonoBehaviour
{
    public Canvas myCanvas;
    // Start is called before the first frame update
    void Start()
    {
        myCanvas.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myCanvas.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myCanvas.enabled = false;
        }
    }
}
