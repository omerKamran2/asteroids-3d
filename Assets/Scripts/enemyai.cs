using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EpicToonFX
{
    public class enemyai : MonoBehaviour
    {   



        [SerializeField]
        public GameObject[] projectiles;
        private GameObject player;
        [Header("Missile spawns at attached game object")]
        public Transform spawnPosition;
        [HideInInspector]
        public int currentProjectile = 0;
        public float speed = 5000;
        public float time = 0.0f;
        public float shoot_time = 5.0f;




        [Header("===EnemyClass===")]
        public float health;
        public GameObject destroyEffect;
        public Transform effectPos;
        public GameObject spawner;
        spawnNew script;

        void Start()
        {
            //selectedProjectileButton = GameObject.Find("Button").GetComponent<ETFXButtonScript>();
            player = GameObject.Find("ship");
            health = 20f;
            script = spawner.GetComponent<spawnNew>();
        }

        RaycastHit hit;

        void Update()
        {
            time += Time.deltaTime;

            if(time >= shoot_time)
            {
                time = time - shoot_time;

                GameObject projectile = Instantiate(projectiles[currentProjectile], spawnPosition.position, Quaternion.identity) as GameObject; //Spawns the selected projectile
                projectile.transform.LookAt(player.transform.position);
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * speed); //Set the speed of the projectile by applying force to the rigidbody
            }

            if (health <= 0)
            {
                //Destroy(transform.parent.gameObject);
                destroyEffect = Instantiate(destroyEffect, effectPos) as GameObject;
                gameObject.SetActive(false);
                script.enemyCount--;
            }

        }
    

        public void nextEffect() //Changes the selected projectile to the next. Used by UI
        {
            if (currentProjectile < projectiles.Length - 1)
                currentProjectile++;
            else
                currentProjectile = 0;
            //selectedProjectileButton.getProjectileNames();
        }

        public void previousEffect() //Changes selected projectile to the previous. Used by UI
        {
            if (currentProjectile > 0)
                currentProjectile--;
            else
                currentProjectile = projectiles.Length - 1;
            //selectedProjectileButton.getProjectileNames();
        }

        public void AdjustSpeed(float newSpeed) //Used by UI to set projectile speed
        {
            speed = newSpeed;
        }
    }
}
