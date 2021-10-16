using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banana : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            //gameObject.SetActive(false);
        }
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player")
        {
            Debug.Log("Banana");
            gameObject.SetActive(false);
        }
        
    }
}

