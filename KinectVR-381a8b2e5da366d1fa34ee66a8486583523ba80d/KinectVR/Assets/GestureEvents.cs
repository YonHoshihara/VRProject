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
    public float DistanceBetwenHands,MaxDistanceBHands;
    public float MaxZBall;
    public float percent;
    private bool CanIAddForce;
    private Transform _obj;

    // Use this for initialization
    void Start()
    {
        bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
        CanSpawn = true;
        CanPush = false;
        CanIAddForce = true; 
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PowerBall(Clone)") == null)
        {
            CanSpawn = true;
            CanPush = true; 
        }
         InstantiateBallWithHands();

        

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
            Transform obj = GameObject.Find("PowerBall(Clone)").GetComponent<Transform>();
            yield return new WaitForSeconds(.5f);
            float finalpositionright = body.partsDic["WristRight"].go.transform.position.z;
            float finalpositionleft = body.partsDic["WristLeft"].go.transform.position.z;
            Vector3 DirectionFinal= new Vector3(0,0,0);
         
            if ((body.partsDic["WristRight"].go.transform.position.x >= body.partsDic["Neck"].go.transform.position.x) && (body.partsDic["WristLeft"].go.transform.position.x > body.partsDic["Neck"].go.transform.position.x))
            {

                DirectionFinal = body.partsDic["WristLeft"].go.transform.position - body.partsDic["ShoulderLeft"].go.transform.position;
                if ((Mathf.Abs(Mathf.Abs (initialpositionright)-Mathf.Abs(finalpositionright)) >= .3f) && (Mathf.Abs(Mathf.Abs(initialpositionleft)- Mathf.Abs (finalpositionleft)) >= .3f))
                {
                  //  Debug.Log("Esquerda");
                    PushBallCat(DirectionFinal);
                    StopCoroutine("GesturePush");
                }
               
            }

            if ((body.partsDic["WristRight"].go.transform.position.x < body.partsDic["Neck"].go.transform.position.x) && (body.partsDic["WristLeft"].go.transform.position.x < body.partsDic["Neck"].go.transform.position.x))
            {
                DirectionFinal = body.partsDic["WristRight"].go.transform.position - body.partsDic["ShoulderRight"].go.transform.position;

                if ((Mathf.Abs(Mathf.Abs(initialpositionright) - Mathf.Abs(finalpositionright)) >= .5f) && (Mathf.Abs(Mathf.Abs(initialpositionleft) - Mathf.Abs(finalpositionleft)) >= .5f))
                {
                  //  Debug.Log("Direita");
                    PushBallCat(DirectionFinal);
                    
                    StopCoroutine("GesturePush");
                }
               
            }

            if ((body.partsDic["WristRight"].go.transform.position.x < body.partsDic["Neck"].go.transform.position.x) && (body.partsDic["WristLeft"].go.transform.position.x > body.partsDic["Neck"].go.transform.position.x))
            {
                DirectionFinal = new Vector3(0,0,-1);
                if ((Mathf.Abs(Mathf.Abs(initialpositionright) - Mathf.Abs(finalpositionright)) >= 1f) && (Mathf.Abs(Mathf.Abs(initialpositionleft) - Mathf.Abs(finalpositionleft)) >= 1f))
                {
                    //Debug.Log("Frente");
                    PushBallCat(DirectionFinal);
                    StopCoroutine("GesturePush");
                }
               
            }
    }
        
    }
    public void InstantiateBallWithHands()
    {
        bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
        foreach ( OnlineBody body in bodies )
        {

            if (body!=null)
            {

                bool foundBall = false;
                InstantiateBallH(body,Sphere);
                try
                {
                    _obj = GameObject.Find("PowerBall(Clone)").GetComponent<Transform>();
                    foundBall = true;
                }
                catch
                {
                    foundBall = false;
                }
                if (foundBall)
                {
                    BallScaleAdjust(body,_obj);
                    StartCoroutine(GesturePush(body));
                }
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
                //StartCoroutine(GesturePush(body));
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
    public void PushBallCat(Vector3 Direction)
    {
        if ((!CanSpawn)&&(CanPush))
        {
            Transform obj = GameObject.Find("PowerBall(Clone)").GetComponent<Transform>();
            if (obj!=null)
            {
                if (CanIAddForce)
                {
                    Vector3 v = Direction.normalized;
                   // Debug.Log("Força adicionada"+ v.normalized);
                    obj.GetComponent<Rigidbody>().velocity = v*thrust ;
                    CanPush = false;
                    CanIAddForce = false;
                }
                

            }


            // Debug.Log("Vaiiiiiiiiiii Draciel");
        }
    }

    private void BallMovimentRotation(OnlineBody body, Transform obj)
    {

        Rigidbody rb = GameObject.Find("PowerBall(Clone)").GetComponent<Rigidbody>();

        if (rb.velocity.x ==0)
        {
            Vector3 BallPosition = (body.partsDic["WristRight"].go.transform.position + body.partsDic["WristLeft"].go.transform.position) / 2;
            obj.transform.position = new Vector3(BallPosition.x, BallPosition.y, BallPosition.z + DistanceSpanwToPlayer);

        }

    }
    private void InstantiateBallH(OnlineBody body , GameObject Sphere)
    {
        if (((body.partsDic["WristRight"].go.transform.position.y <= body.partsDic["Neck"].go.transform.position.y) && (body.partsDic["WristRight"].go.transform.position.y > body.partsDic["SpineMid"].go.transform.position.y)) && ((body.partsDic["WristLeft"].go.transform.position.y <= body.partsDic["Neck"].go.transform.position.y) && (body.partsDic["WristLeft"].go.transform.position.y > body.partsDic["SpineMid"].go.transform.position.y)))
        {
            if (Mathf.Abs(body.partsDic["WristRight"].go.transform.position.x - body.partsDic["WristLeft"].go.transform.position.x) <= DistanceBetwenHands)
            {

                PositionToInstantiate = new Vector3(body.partsDic["Neck"].go.transform.position.x, body.partsDic["Neck"].go.transform.position.y, body.partsDic["Neck"].go.transform.position.z + DistanceSpanwToPlayer);
                if (CanSpawn)
                {
                    Instantiate(Sphere, PositionToInstantiate, Quaternion.identity);
                    CanSpawn = false;
                    CanIAddForce = true;
                }

            }
        }

    }
    private void BallScaleAdjust(OnlineBody body ,Transform obj)
    {
  if (Mathf.Abs(body.partsDic["WristRight"].go.transform.position.x - body.partsDic["WristLeft"].go.transform.position.x) <= MaxDistanceBHands) {
  
     float distancia = Mathf.Abs(body.partsDic["WristRight"].go.transform.position.x - body.partsDic["WristLeft"].go.transform.position.x);
             if ((obj.localScale.z < MaxZBall))
                  {

                      CanPush = false;
                      obj.localScale = new Vector3(distancia * percent / 100, distancia * percent / 100, distancia * percent / 100);
                      Vector3 BallPosition = (body.partsDic["WristRight"].go.transform.position + body.partsDic["WristLeft"].go.transform.position) / 2;
                      obj.transform.position = new Vector3(BallPosition.x, BallPosition.y, BallPosition.z-2);
            }
            if ((obj.localScale.z >= MaxZBall)){
                     CanPush = true;
           
           }
       }
              
    }

}