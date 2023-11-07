using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarCamara : MonoBehaviour
{
    bool cambiarcamara = true;
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(cambiarcamara)
            {

                cambiarcamara=false;
               
            }
            else
            {
                cambiarcamara=(true);
            }


        }
        
          
        if (cambiarcamara == true)
        {
            transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y + 10, personaje.transform.position.z - 10);
            transform.rotation = Quaternion.Euler(40, 0, 0);
        }
        else if (cambiarcamara == false)
        {
            transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y, personaje.transform.position.z);
            transform.rotation = Quaternion.identity;
        }
    }
}
