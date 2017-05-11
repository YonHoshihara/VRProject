using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGesture : MonoBehaviour {

    private OnlineBody[] bodies;
    public float minDist,maxDist;
    float deltaDist;
    Transform leftHand, rightHand;
    bool ballSpawned;
    public GameObject ballPrefab;
    GameObject ball;
    public float ballGrowAmount;
    public float ballFloatSpeed;

    private void Start()
    {
        StartCoroutine(DetectHands());
        
    }
   

    private void LateUpdate()
    {
        UpdateDeltaDist();
        CheckBallSpawn();
        if (ballSpawned && !CheckSizeOverflow())
        {
            UpdateBallScale();
            UpdateBallPosition();
        }
    }


    //KeepDetectingHands and body
    IEnumerator DetectHands()
    {

        while (true)
        {

            bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
            foreach (OnlineBody body in bodies)
            {

                if (body != null)
                {
                    leftHand = bodies[0].partsDic["WristLeft"].go.transform;
                    rightHand = bodies[0].partsDic["WristRight"].go.transform;

                }

            }

            yield return new WaitForSeconds(0.2F);
        }
    }
    
    //check if the ball can be spawned
    void CheckBallSpawn()
    {
        if (!ballSpawned && (deltaDist < minDist))
        {
            print("WHATTTTTTTT");
            ball = Instantiate(ballPrefab,(leftHand.position + rightHand.position)/2,Quaternion.identity) as GameObject;
            ballSpawned = true;
        }
    }

    //update distance between hands
    void UpdateDeltaDist()
    {
        if(leftHand!=null && rightHand != null)
        {
            deltaDist = Vector3.Distance(leftHand.position, rightHand.position);
            //print("deltaDist!!!::   " + deltaDist);
        }
    }

    //update ball size
    void UpdateBallScale()
    {
       
        ball.transform.localScale = Vector3.Lerp(ball.transform.localScale, Vector3.one* deltaDist * ballGrowAmount,Time.deltaTime*2);
  
    }

    //update ball smooth position between hands
    void UpdateBallPosition()
    {
        Vector3 middlePoint = (leftHand.position + rightHand.position) / 2;
        middlePoint.z -= 2;
        Vector3 ballPos = ball.transform.position;
        ball.transform.position = Vector3.Lerp(ballPos, middlePoint, Time.deltaTime * ballFloatSpeed);



    }

    //check if hands distance is overflowed
    bool CheckSizeOverflow()
    {
        //entrou em overflow
        if(deltaDist > maxDist)
        {
            Destroy(ball);
            ballSpawned = false;
            return true;
        }
        return false;

    }




}
