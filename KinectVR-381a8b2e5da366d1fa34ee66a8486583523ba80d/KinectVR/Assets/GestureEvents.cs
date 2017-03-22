using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureEvents : MonoBehaviour
{
    public GameObject Sphere;
    private OnlineBody[] bodies;
    bool CanSpawn;
    bool CanPush;
    Vector3 PositionToInstantiate;
    public float DistanceSpanwToPlayer;
    public float thrust;

    // Use this for initialization
    void Start()
    {
        bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
        
        CanSpawn = true;
        CanPush = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (InstantiateBall())
        {
            Instantiate(Sphere,PositionToInstantiate,Quaternion.identity);
        }
        



    }
    public bool GestureHello(OnlineBody body)
    {
        // Hand above elbow
        if (body.partsDic["WristRight"].go.transform.position.y > body.partsDic["ElbowRight"].go.transform.position.y)
        {
            //Debug.Log("Hand right of elbow");
            if (body.partsDic["WristRight"].go.transform.position.x > body.partsDic["ElbowRight"].go.transform.position.x)
            {
                return true;
            }
        }
        return false;
    }
    public bool GestureHandsUP(OnlineBody body)
    {
        //Debug.Log("Hand right of elbow");
        if (body.partsDic["WristRight"].go.transform.position.y > body.partsDic["Neck"].go.transform.position.y)
        {
            //Debug.Log("Mão direita levantada");
            if (body.partsDic["ElbowRight"].go.transform.position.y > body.partsDic["Neck"].go.transform.position.y)
            {
                return true;
            }
        }
        return false;
    }
    public bool GestureTwoHandsUP(OnlineBody body)
    {
        if ((body.partsDic["WristRight"].go.transform.position.y > body.partsDic["Neck"].go.transform.position.y) && (body.partsDic["WristLeft"].go.transform.position.y > body.partsDic["Neck"].go.transform.position.y))
        {
            //Debug.Log("Mão direita levantada");
            if ((body.partsDic["ElbowRight"].go.transform.position.y > body.partsDic["Neck"].go.transform.position.y) && (body.partsDic["ElbowLeft"].go.transform.position.y > body.partsDic["Neck"].go.transform.position.y))
            {
                return true;
            }

        }
        return false;
    }
    IEnumerator GesturePush(OnlineBody body)
    {
        if(body!= null)
        {
            float initialpositionright = body.partsDic["WristRight"].go.transform.position.z;
            float initialpositionleft = body.partsDic["WristLeft"].go.transform.position.z;
            yield return new WaitForSeconds(.5f);
            float finalpositionright = body.partsDic["WristRight"].go.transform.position.z;
            float finalpositionleft = body.partsDic["WristLeft"].go.transform.position.z;
            if ((initialpositionright >= finalpositionright + 0.8f) && (initialpositionleft >= finalpositionleft + 0.8f))
            {
                PushBallCat();
            }
        }
        

    }


    public bool InstantiateBall()
    {

       

        bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
        foreach (OnlineBody body in bodies)
        {
            
            if (body != null)
            {
                StartCoroutine(GesturePush(body));
                if ((GestureTwoHandsUP(body))&&(CanSpawn))
                {
                    PositionToInstantiate = new Vector3(body.partsDic["Neck"].go.transform.position.x, body.partsDic["Neck"].go.transform.position.y, body.partsDic["Neck"].go.transform.position.z + DistanceSpanwToPlayer);
                    CanSpawn = false;

                    return true;
                }

            }

        }
        return false;
    }

    public void PushBallCat()
    {
        if ((!CanSpawn)&&(CanPush))
        {
            GameObject.Find("PowerBall(Clone)").GetComponent<Rigidbody>().velocity = new Vector3(0,0,thrust);
                CanPush = false;
            Debug.Log("Vaiiiiiiiiiii Draciel");
        }


    }

}