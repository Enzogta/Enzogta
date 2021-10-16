using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girar : MonoBehaviour
{
    public float velocidade;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("add",velocidade);
        gira(z);
    }
    void gira(float z ){
        Quaternion target = Quaternion.Euler(0,0,z);
        transform.rotation = Quaternion.Slerp(transform.rotation,target, Time.deltaTime*velocidade);
    }
    void  add(){
        z++;
        if(z>360){
            z=0;
        }
    }
}
