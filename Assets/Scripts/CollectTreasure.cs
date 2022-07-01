using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectTreasure : MonoBehaviour
{   
    private int treasures = 0;
    private GameObject player;
    private AudioSource audioSource;
    public AudioClip audioClip;
    [SerializeField] private Text TreasuresText;

    private void Start() {

        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = player.GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Treasure"))
        {   

            Destroy(collision.gameObject);
            audioSource.PlayOneShot(audioClip);
            treasures++;
            TreasuresText.text = "" + treasures;
            
        }
    }
}
