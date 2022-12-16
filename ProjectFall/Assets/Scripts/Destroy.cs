using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle") || other.gameObject.CompareTag("Spawn") || other.gameObject.CompareTag("O2"))
        {
            Destroy(other.gameObject);
            Debug.Log("bruhhhh");
        }
        Debug.Log("damn");
    }
}
