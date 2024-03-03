using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] float Speed;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSource; //Play later audiosource
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Vector3.right * Speed); //Move the heart to the right 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) // If object hits an object tagged obstacle then destroy
        {
            Destroy(gameObject); 
        }
    }
}