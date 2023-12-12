using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crearenemigos : MonoBehaviour
{
    public GameObject[] prefabenemigo;

    
    void Start()
    {
        Invoke("crearenemigos", 2);
    }

  
    void Update()
    {
        
    }

    void crearenemigos()
    {
        GameObject randomenemy = prefabenemigo[Random.Range(0, prefabenemigo.Length)];
        
        Instantiate(randomenemy, transform.position, transform.rotation);
        Invoke("crearenemigos", 2);
    }
}
