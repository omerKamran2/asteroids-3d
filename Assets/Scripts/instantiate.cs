using UnityEngine;

public class instantiate : MonoBehaviour
{
    public GameObject portal, enemy;
    public Transform pPos, ePos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPortal();
        spawnEnemy();
    }



    public void spawnPortal()
    {
        portal = Instantiate(portal, pPos) as GameObject;
        Destroy(portal, 5f);
    }

    public void spawnEnemy()
    {
        enemy = Instantiate(enemy, ePos) as GameObject;
    }


}
