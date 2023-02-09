using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject player;
    private int x_pos;
    private int y_pos;
    private float spawn_time;
    private float time = 0.0f;
    private bool is_spawned = false;
    public float despawn_timer = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, despawn_timer);
    }

    void OnCollisionEnter(Collision collision) 
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
