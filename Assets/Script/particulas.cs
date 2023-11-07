using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particulas : MonoBehaviour
{
    public GameObject arbol;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(arbol.transform.position, Vector3.down, 40 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Jugador")
        {
            var part = GetComponent<ParticleSystem>();
            part.Play();
        }
    }
}   
