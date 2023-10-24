using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverEnemigo : MonoBehaviour
{
    public float velocidad = 1.0f;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        transform.position = new Vector3(525f, 0.5f, 195f);

        var sphere = GameObject.Find("Personaje");

        target = sphere.transform;
        target.transform.position = new Vector3(517f, 0.5f, 187f);
    }

    // Update is called once per frame
    void Update()
    {
        var step = velocidad * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.LookAt(target);
    }
}
