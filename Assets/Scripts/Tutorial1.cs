using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1 : MonoBehaviour
{
    public float StartTime;
    public float EndTime;

    void Update(){
        StartTime += 0.0f;
        if (StartTime >= EndTime){
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)){
                Destroy(gameObject);
            }      
        }   
            
    }
}
