using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNew : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject enemy, portal;


    private int index;
    public int enemyCount = 0;
    public int enemyLimit = 5;

    // Start is called before the first frame update
    void Start()
    {
        startInvoke();
    }


    void startInvoke()
    {
        InvokeRepeating("Spawn", 0f, 3f);
    }

    void Spawn()
    {
        do
        {
            index = Random.Range(0, spawnPoints.Length);
            //Debug.Log(spawnPoints[index].transform.childCount);
           // Debug.Log(index);
        } while (spawnPoints[index].transform.childCount >= 2);

        if (enemyCount >= enemyLimit)
        {
            return;
        } 
        else
        {
            StartCoroutine(spawnPortal());
            //spawnEnemy();
        }


    }

    IEnumerator spawnPortal()
    {
        //portal = Instantiate(portal, spawnPoints[pPos]);
        spawnPoints[index].transform.GetChild(0).gameObject.SetActive(true);
        spawnEnemy();
       // Debug.Log("before");
        yield return new WaitForSeconds(2);
        //Debug.Log("after");
        spawnPoints[index].transform.GetChild(0).gameObject.SetActive(false);
  
    }

    public void spawnEnemy()
    {
        if (spawnPoints[index].transform.childCount > 1)
        {
            spawnPoints[index].transform.GetChild(1).gameObject.SetActive(true);
        } else
        {
            enemy = Instantiate(enemy, spawnPoints[index]) as GameObject;
            
        }
        enemyCount++;

    }
}
