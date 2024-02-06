using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatteliteObjects : MonoBehaviour
{
    public GameObject satellitePrefab;
    public AudioSource biteSound;
    private void OnTriggerEnter2D(Collider2D other) //align the same physics, make sure it's 2D, trigger enter
    {
        //score goes up by 1
        GameManager.instance.score ++;
        
        //play audio sound
        biteSound.Play();
        
        //satellite relocates to random new location
        transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-2, 2), 0);
        
        //creating new instances on trigger, so they swarm the screen. you must choose a new position and rotation of the object you want a new instance of.
        Instantiate(satellitePrefab, new Vector3(Random.Range(-4, 4), Random.Range(-2, 2), 0), transform.rotation);

    }
}

