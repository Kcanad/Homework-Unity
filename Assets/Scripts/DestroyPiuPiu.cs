using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiuPiu : MonoBehaviour
{
    [SerializeField] private float DestroyRange = 20.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.z > DestroyRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -DestroyRange)
        {
            Destroy(gameObject);
        }
    }
}
