using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speedAnimal = 40.0f;
    public float destroyRange = 21f;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speedAnimal * Time.deltaTime);

        if (transform.position.z > destroyRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -destroyRange)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
