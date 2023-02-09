using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidbelt : MonoBehaviour
{
    [SerializeField]asteroid a;
    [SerializeField]int asteroids_per_axis = 5;
    [SerializeField]int spacing = 5;


    void placeAsteroids()
    {
        for(int x = 0; x < asteroids_per_axis; x++)
        {
            for(int y = 0; y < asteroids_per_axis; y++)
            {
                for(int z = 0; z < asteroids_per_axis; z++)
                {
                    instantiateAsteroid(x, y, z);
                }
            }

        }
    }

    void instantiateAsteroid(int x, int y, int z)
    {
        Instantiate(a, new Vector3(transform.position.x + (x * spacing) + asteroidOffset(), transform.position.y + (y * spacing) + asteroidOffset(), transform.position.z + (z * spacing) + asteroidOffset()), Quaternion.identity, transform);
    }

    // Start is called before the first frame update
    void Start()
    {
        placeAsteroids();
    }


    float asteroidOffset()
    {
        return Random.Range(-spacing/2f, spacing/2f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
