using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyloading : MonoBehaviour
{
    public GameObject enemy;
    public int x_pos;
    public int y_pos;
    public int z_pos;


    // Start is called before the first frame update
    void Start()
    {
        x_pos = Random.Range(35,215);
        y_pos = Random.Range(15,40);
        z_pos = Random.Range(100,200);

        if(x_pos < 125)
        {
            Instantiate(enemy, new Vector3(-50, y_pos, z_pos), Quaternion.identity);
        }
        else
        {
            Instantiate(enemy, new Vector3(300, y_pos, z_pos), Quaternion.identity);                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
