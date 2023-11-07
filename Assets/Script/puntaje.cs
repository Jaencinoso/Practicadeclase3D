using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje : MonoBehaviour
{
    private int puntuacion;
    public Text puntuacionText;
    // Start is called before the first frame update
    void Start()
    {
        puntuacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Monedas")
        {
            puntuacion++;
            puntuacionText.text = "" + puntuacion;
        }
    }
}
