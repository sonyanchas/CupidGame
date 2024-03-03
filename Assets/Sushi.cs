using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sushi : MonoBehaviour
{
    public float Speed;
    [SerializeField] GameObject starPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = Random.Range(2, 8); // A random speed 
        transform.Translate(Time.deltaTime * Vector3.left * Speed );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // When object hits an object tagged Player
        {
            Instantiate(starPrefab, transform.position, transform.rotation); //Create star explosiob then destroy
            Destroy(gameObject);
 
        }
    }
}
