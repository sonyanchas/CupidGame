using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SkyMover : MonoBehaviour
{
    [SerializeField] float Speed; // Initiiaze speed, minx, and move
    [SerializeField] float minX;
    [SerializeField] Vector3 move;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.left); // Moves the sky from right to left

        if (transform.position.x < minX) // If the position is smaller than the MinX
        {
            transform.position = move; //Move the sky back to the beginning
        }
    }
}