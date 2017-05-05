using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    public GameObject Enemy;
    private GameObject[] Enemies;
    private bool CanISpawn;
    private Transform player;
    public float Rangex,Rangez, minzplayer;
    public int MaxMonsterNumber;
    
    // Use this for initialization
	void Start () {
        CanISpawn = true;
        player = GameObject.Find("SpineMid").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        player = GameObject.Find("SpineMid").GetComponent<Transform>();

        Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if ((Enemies.Length<=MaxMonsterNumber-1)&&(CanISpawn))
        {

            Vector3 position = new Vector3((Random.Range(player.position.x-Rangex, player.position.x + Rangex)),Enemy.transform.position.y, (Random.Range(player.position.z + minzplayer, player.position.z + Rangez)));
            Instantiate(Enemy,position,Quaternion.identity);
            CanISpawn = false;
        }
        else
        {
            CanISpawn = true;
        }
    }
}
