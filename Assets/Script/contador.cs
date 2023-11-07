using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempos;
    Image rbimage;
    private float restante;
    private bool enMarcha;
    // Start is called before the first frame update
    void Start()
    {
        rbimage = GetComponent<Image>();
    }

    private void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;
            if (restante < 1) 
            {
                enMarcha = true;
                rbimage.color = Color.red;
                Time.timeScale = 0;
            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempos.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
        }
    }
}
