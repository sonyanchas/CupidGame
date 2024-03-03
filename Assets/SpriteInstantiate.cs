using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteInstantiate : MonoBehaviour
{
    public GameObject bearPrefab; // Assign prefab in  inspector
    public GameObject sushiPrefab; 
    [SerializeField] int Ratio = 50;
    public float instantiateInterval = 2.0f; // Create a time interval between prefabs
    [SerializeField] float MinY;
    [SerializeField] float MaxY;

    private void Start()
    {
        StartCoroutine(InstantiateSprites()); //Create a repetition of instantiations
    }
    
    private IEnumerator InstantiateSprites() //Instation the prefabs
    {
        while (true)
        {
            float randomY= Random.Range(MinY, MaxY);
            int r = Random.Range(0, 100);
            Vector3 randomPosition = new Vector3(transform.position.x, randomY, transform.position.z); //create a random position
            
            if (r < Ratio)
            {
                Instantiate(bearPrefab, randomPosition, transform.rotation);
            }
            else
            {
                Instantiate(sushiPrefab, randomPosition, transform.rotation);
            }
            yield return new WaitForSeconds(instantiateInterval); // Wait before creating new prefab clone
        }
    }
}

