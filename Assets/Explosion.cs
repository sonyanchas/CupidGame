using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource; // Play explosion sound
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        Destroy(gameObject, .5f); // Destory itself

    }

    // Update is called once per frame
    void Update()
    {

    }
}