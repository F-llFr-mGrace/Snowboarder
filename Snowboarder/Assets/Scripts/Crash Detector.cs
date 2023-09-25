using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Terrain"))
        {
            Debug.Log("Ouch");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
