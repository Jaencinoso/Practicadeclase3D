using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarMonedagiratoria : MonoBehaviour
{
    public GameObject arbol;
    ParticleSystem part;
    // Start is called before the first frame update
    void Start()
    {
        //var part = GetComponent<ParticleSystem>();
        //part.Play();
        //Destroy(gameObject, part.main.duration);

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(arbol.transform.position, Vector3.up, 40 * Time.deltaTime);
    }
}
