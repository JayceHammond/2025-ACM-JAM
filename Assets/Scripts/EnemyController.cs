using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    public float totalHealth;
    public float currHealth;
    public float dmg;
    public float sightRange;
    public GameObject Player;
    public GameObject bulletObj;
    private float bulletSpeed = 10;
    public bool shoot = true;
    public List<GameObject> bullets = new List<GameObject>();



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform.position);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        if (shoot == true)
        {
            ShootPlayer(Player.transform.position);
            shoot = false;
        }
        if (bullets.Count > 0)
        {
            foreach (GameObject bullet in bullets)
            {
                //bullet.transform.LookAt(Player.transform.position);
                bullet.transform.position += bullet.transform.forward * bulletSpeed * Time.deltaTime;
            }
        }


        void ShootPlayer(Vector3 PlayerPos)
        {
            GameObject bullet = Instantiate(bulletObj, transform.position, bulletObj.transform.rotation);
            bullets.Add(bullet);
            
        }

    }
}
