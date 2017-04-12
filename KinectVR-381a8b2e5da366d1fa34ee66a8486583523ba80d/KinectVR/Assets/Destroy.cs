using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private Vector3 InitialPosition;
    public float DistanceToDestroy;
    // Use this for initialization
    void Start()
    {
        InitialPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<Transform>().position.z - InitialPosition.z != 0)
        {
            if (Mathf.Abs(GetComponent<Transform>().position.z - InitialPosition.z) >= DistanceToDestroy)
            {
                Destroy(gameObject);
                //Debug.Log(Mathf.Abs(GetComponent<Transform>().position.z - InitialPosition.z));

            }
        }


    }

    void OnCollisionEnter(Collision collision)
    {

       // Debug.Log("Destruido");
            Destroy(gameObject);
        

    }
}