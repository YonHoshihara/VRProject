using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour {
    private OnlineBody[] bodies;
    private float BallPosition;
    // Use this for initialization
    void Start () {
        bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
    }
	
	// Update is called once per frame
	void Update () {
        ChangeSpherePosition();
	}

    public void ChangeSpherePosition()
    {
        bodies = GameObject.Find("OnlineBodyView").GetComponent<OnlineBodyView>().bodies;
      
        foreach (OnlineBody body in bodies) 
        {
            if (body!=null)
            {
                BallPosition = (body.partsDic["WristRight"].go.transform.position.x - body.partsDic["WristLeft"].go.transform.position.x) / 2;
            }
            gameObject.transform.position = new Vector3(BallPosition,gameObject.transform.position.y,gameObject.transform.position.z);
            Debug.Log(gameObject.transform.position);


        }
    }
}
