using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDissapear : MonoBehaviour
{
    public float StartTime;
    public float EndTime;

    private void OnCollisionEnter2D(Collision2D other) {
        StartTime += 0.0f;
            if (StartTime >= EndTime){
                if (other.gameObject.tag == "Player"){
                    Destroy(gameObject);
            }   }
            
    }
}
