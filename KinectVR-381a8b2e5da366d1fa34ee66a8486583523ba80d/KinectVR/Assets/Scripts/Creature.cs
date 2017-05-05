using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour {
    int life;
    Animator anim;
	// Use this for initialization
	void Start () {
        life = 2;
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.tag == "PowerBall")
        {
            if (life > 0)
            {
                life--;
                anim.SetTrigger("Damage");
            }
            
            if (life <= 0)
            {
                anim.SetTrigger("Die");
                gameObject.GetComponent<BoxCollider>().enabled = false;
                yield return new WaitForSeconds(2);
                Destroy(gameObject);
            }
        }
        if(obj.gameObject.name == "SpineMid")
        {
            gameObject.GetComponent<CreatureMoviment>().enabled = false;
            anim.SetTrigger("Attack");

            yield return new WaitForSeconds(2);
            Debug.Log("Morto");
        }
    }

    public void ChasePlayer()
    {

    }

}
