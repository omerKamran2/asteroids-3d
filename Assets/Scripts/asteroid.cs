using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    Transform myT;
    [SerializeField]float min_scale = 0.8f;
    [SerializeField]float max_scale = 1.2f;
    [SerializeField]float rotation_offset = 100f;
    Vector3 rotation;
    // Start is called before the first frame update


    void Awake() 
    {
        myT = transform;
    }

    void Start()
    {
        Vector3 scale = Vector3.one;
        scale.x = Random.Range(min_scale, max_scale);
        scale.y = Random.Range(min_scale, max_scale);
        scale.z = Random.Range(min_scale, max_scale);

        myT.localScale = scale;

        rotation.x = Random.Range(-rotation_offset, rotation_offset);
        rotation.y = Random.Range(-rotation_offset, rotation_offset);
        rotation.z = Random.Range(-rotation_offset, rotation_offset);
    }

    // Update is called once per frame
    void Update()
    {
        myT.Rotate(rotation * Time.deltaTime);
    }
}
