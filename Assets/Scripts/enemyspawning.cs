using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawning : MonoBehaviour
{
    public GameObject enemy, portal;
    private int x_pos;
    private int y_pos;
    private int z_pos;
    private float spawn_time;
    //public float move_speed = 10f;

    IEnumerator enemySpawn()
    {
        while(true)
        {
            x_pos = Random.Range(35,215);
            y_pos = Random.Range(15,40);
            z_pos = Random.Range(100,200);
            spawn_time = Random.Range(5,10);

            Instantiate(enemy, new Vector3(x_pos, y_pos, z_pos), Quaternion.identity);

            yield return new WaitForSeconds(spawn_time);
        }
    }

    private void destroy()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawn());
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 position = new Vector3(x_pos, y_pos, z_pos);

        // Vector3 new_position = Vector3.MoveTowards(enemy.transform.position, position, move_speed * Time.deltaTime);

        // enemy.transform.position = new_position;        
    }
}
