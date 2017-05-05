using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureMoviment : MonoBehaviour {

    private Animator anim;
    private Transform obj;
    public float maxspeed;
    private float speed;
    
    
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        obj = GameObject.Find("SpineMid").GetComponent<Transform>();
        speed = (Random.Range(6,maxspeed));
        	
	}
	
	// Update is called once per frame
	void Update () {
        obj = GameObject.Find("SpineMid").GetComponent<Transform>();

        if ((anim.GetCurrentAnimatorStateInfo(0).IsName("creature1run"))&&(obj!=null))
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, obj.position, step);
        }


    }
}
