using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupidController : MonoBehaviour
{
    [SerializeField] float MinY;
    [SerializeField] float MaxY;
    [SerializeField] float MinX;
    [SerializeField] float Speed;
    [SerializeField] GameObject heartPrefab;
    [SerializeField] GameObject explosionPrefab;
    [SerializeField] Vector3 arrow;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");  // Uses the controller and keyboard as inputs to move

        transform.Translate(Time.deltaTime * Speed * y * Vector3.up); // Moves the cupid up and down
        if (transform.position.y > MaxY) //If cupid reaches any of these values, do not move him so he doesnt leave the screen
        {
            transform.position = new Vector3(transform.position.x, MaxY, 0f);
        }
        if (transform.position.y < MinY)
        {
            transform.position = new Vector3(transform.position.x, MinY, 0f);
        }
        if (transform.position.x < MinX)
        {
            transform.position = new Vector3(MinX, transform.position.y, 0f);
        }
        if (Input.GetButtonDown("Fire1") == true) //When Fire1 button is hit, heartprefab is instantiated
        {
            Instantiate(heartPrefab, transform.position + arrow, transform.rotation);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            if (gm.Timer == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}



