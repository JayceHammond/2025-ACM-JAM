using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class RadarCam : MonoBehaviour
{
    public GameObject target;
    public GameObject enemyIcon;
    private GameObject[] Enemies;
    private GameObject Player;
    public GameObject playerIcon;
    public GameObject[] enemies;

    private void Start()
    {
        Player = Instantiate(playerIcon, new Vector3(target.transform.position.x, target.transform.position.y + 5, target.transform.position.z), playerIcon.transform.rotation);
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Enemies.Append(Instantiate(enemyIcon, new Vector3(enemy.transform.position.x, enemy.transform.position.y + 5, enemy.transform.position.z), enemyIcon.transform.rotation));
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        foreach (GameObject enemy in Enemies) { 
            enemy.transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        }
    }
}
