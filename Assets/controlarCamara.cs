using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarCamara : MonoBehaviour
{
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y + 1, personaje.transform.position.z - 5);
    }
}
