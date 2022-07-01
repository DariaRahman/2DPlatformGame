using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{   
    public GameObject player;

    void Update(){   
    
       transform.position =  new Vector3(player.transform.position.x, 0, -5f);
        
    }
      
}
