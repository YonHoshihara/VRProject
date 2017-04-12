using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MapToKinect : MonoBehaviour
{

    public float offsetY;
    public ulong assignedid;

    public Transform SpineBase;
    public Transform SpineMid;
    public Transform Neck;
    public Transform Head;
    public Transform ShoulderLeft;
    public Transform ElbowLeft;
    public Transform WristLeft;
    public Transform HandLeft;
    public Transform ShoulderRight;
    public Transform ElbowRight;
    public Transform WristRight;
    public Transform HandRight;
    public Transform HipLeft;
    public Transform KneeLeft;
    public Transform AnkleLeft;
    public Transform FootLeft;
    public Transform HipRight;
    public Transform KneeRight;
    public Transform AnkleRight;
    public Transform FootRight;
    public Transform SpineShoulder;
    public Transform HandTipLeft;
    public Transform ThumbLeft;
    public Transform HandTipRight;
    public Transform ThumbRight;
    public Transform Hips;

    private Transform kSpineBase;
    private Transform kSpineMid;
    private Transform kNeck;
    private Transform kHead;
    private Transform kShoulderLeft;
    private Transform kElbowLeft;
    private Transform kWristLeft;
    private Transform kHandLeft;
    private Transform kShoulderRight;
    private Transform kElbowRight;
    private Transform kWristRight;
    private Transform kHandRight;
    private Transform kHipLeft;
    private Transform kKneeLeft;
    private Transform kAnkleLeft;
    private Transform kFootLeft;
    private Transform kHipRight;
    private Transform kKneeRight;
    private Transform kAnkleRight;
    private Transform kFootRight;
    private Transform kSpineShoulder;
    private Transform kHandTipLeft;
    private Transform kThumbLeft;
    private Transform kHandTipRight;
    private Transform kThumbRight;
  


    public float pos;


    public string assignedname;

    public void AssignBody(string id)
    {
        Debug.Log("assigned body " + id);
        assignedname = id;
        //assignedid = id;
        string bodyprefix = "Online Body: ";


        kSpineBase = GameObject.Find("SpineBase").transform;
        kSpineMid = GameObject.Find("SpineMid").transform;
        kNeck = GameObject.Find("Neck").transform;
        kHead = GameObject.Find("Head").transform;
        kShoulderLeft = GameObject.Find("ShoulderLeft").transform;
        kElbowLeft = GameObject.Find("ElbowLeft").transform;
        kWristLeft = GameObject.Find("WristLeft").transform;
        kHandLeft = GameObject.Find("HandLeft").transform;
        kShoulderRight = GameObject.Find("ShoulderRight").transform;
        kElbowRight = GameObject.Find("ElbowRight").transform;
        kWristRight = GameObject.Find("WristRight").transform;
        kHandRight = GameObject.Find("HandRight").transform;
        kHipLeft = GameObject.Find("HipLeft").transform;
        kKneeLeft = GameObject.Find("KneeLeft").transform;
        kAnkleLeft = GameObject.Find("AnkleLeft").transform;
        kFootLeft = GameObject.Find("FootLeft").transform;
        kHipRight = GameObject.Find("HipRight").transform;
        kKneeRight = GameObject.Find("KneeRight").transform;
        kAnkleRight = GameObject.Find("AnkleRight").transform;
        kFootRight = GameObject.Find("FootRight").transform;
        kSpineShoulder = GameObject.Find("SpineShoulder").transform;
        kHandTipLeft = GameObject.Find( "HandTipLeft").transform;
        kThumbLeft = GameObject.Find("ThumbLeft").transform;
        kHandTipRight = GameObject.Find("HandTipRight").transform;
        kThumbRight = GameObject.Find("ThumbRight").transform;


        /*
        SpineBase.SetParent(kSpineBase);
        SpineMid.SetParent(kSpineMid);
        Neck.SetParent(kNeck);
        Head.SetParent(kHead);
        ShoulderLeft.SetParent(kShoulderLeft);
        ElbowLeft.SetParent(kElbowLeft);
        WristLeft.SetParent(kWristLeft);
        HandLeft.SetParent(kHandLeft);
        ShoulderRight.SetParent(kShoulderRight);
        ElbowRight.SetParent(kElbowRight);
        WristRight.SetParent(kWristRight);
        HandRight.SetParent(kHandRight);
        HipLeft.SetParent(kHipLeft);
        KneeLeft.SetParent(kKneeLeft);
        AnkleLeft.SetParent(kAnkleLeft);
        FootLeft.SetParent(kFootLeft);
        HipRight.SetParent(kHipRight);
        KneeRight.SetParent(kKneeRight);
        AnkleRight.SetParent(kAnkleRight);
        FootRight.SetParent(kFootRight);
        SpineShoulder.SetParent(kSpineShoulder);
        HandTipLeft.SetParent(kHandTipLeft);
        ThumbLeft.SetParent(kThumbLeft);
        HandTipRight.SetParent(kHandTipRight);
        ThumbRight.SetParent(kThumbRight);



    /*
        kSpineBase = GameObject.Find (bodyprefix+id.ToString()+"/SpineBase").transform;
        kSpineMid = GameObject.Find (bodyprefix+id.ToString()+"/SpineMid").transform;
        kNeck = GameObject.Find (bodyprefix+id.ToString()+"/Neck").transform;
        kHead = GameObject.Find (bodyprefix+id.ToString()+"/Head").transform;
        kShoulderLeft = GameObject.Find (bodyprefix+id.ToString()+"/ShoulderLeft").transform;
        kElbowLeft = GameObject.Find (bodyprefix+id.ToString()+"/ElbowLeft").transform;
        kWristLeft = GameObject.Find (bodyprefix+id.ToString()+"/WristLeft").transform;
        kHandLeft = GameObject.Find (bodyprefix+id.ToString()+"/HandLeft").transform;
        kShoulderRight = GameObject.Find (bodyprefix+id.ToString()+"/ShoulderRight").transform;
        kElbowRight = GameObject.Find (bodyprefix+id.ToString()+"/ElbowRight").transform;
        kWristRight = GameObject.Find (bodyprefix+id.ToString()+"/WristRight").transform;
        kHandRight = GameObject.Find (bodyprefix+id.ToString()+"/HandRight").transform;
        kHipLeft = GameObject.Find (bodyprefix+id.ToString()+"/HipLeft").transform;
        kKneeLeft = GameObject.Find (bodyprefix+id.ToString()+"/KneeLeft").transform;
        kAnkleLeft = GameObject.Find (bodyprefix+id.ToString()+"/AnkleLeft").transform;
        kFootLeft = GameObject.Find (bodyprefix+id.ToString()+"/FootLeft").transform;
        kHipRight = GameObject.Find (bodyprefix+id.ToString()+"/HipRight").transform;
        kKneeRight = GameObject.Find (bodyprefix+id.ToString()+"/KneeRight").transform;
        kAnkleRight = GameObject.Find (bodyprefix+id.ToString()+"/AnkleRight").transform;
        kFootRight = GameObject.Find (bodyprefix+id.ToString()+"/FootRight").transform;
        kSpineShoulder = GameObject.Find (bodyprefix+id.ToString()+"/SpineShoulder").transform;
        kHandTipLeft = GameObject.Find (bodyprefix+id.ToString()+"/HandTipLeft").transform;
        kThumbLeft = GameObject.Find (bodyprefix+id.ToString()+"/ThumbLeft").transform;
        kHandTipRight = GameObject.Find (bodyprefix+id.ToString()+"/HandTipRight").transform;
        kThumbRight = GameObject.Find (bodyprefix+id.ToString()+"/ThumbRight").transform;

/*
/*
SpineBase = GameObject.Find(bodyprefix + id.ToString() + "/SpineBase").transform;
SpineMid = GameObject.Find(bodyprefix + id.ToString() + "/SpineMid").transform;
Neck = GameObject.Find(bodyprefix + id.ToString() + "/Neck").transform;
Head = GameObject.Find(bodyprefix + id.ToString() + "/Head").transform;
ShoulderLeft = GameObject.Find(bodyprefix + id.ToString() + "/ShoulderLeft").transform;
ElbowLeft = GameObject.Find(bodyprefix + id.ToString() + "/ElbowLeft").transform;
WristLeft = GameObject.Find(bodyprefix + id.ToString() + "/WristLeft").transform;
HandLeft = GameObject.Find(bodyprefix + id.ToString() + "/HandLeft").transform;
ShoulderRight = GameObject.Find(bodyprefix + id.ToString() + "/ShoulderRight").transform;
ElbowRight = GameObject.Find(bodyprefix + id.ToString() + "/ElbowRight").transform;
WristRight = GameObject.Find(bodyprefix + id.ToString() + "/WristRight").transform;
HandRight = GameObject.Find(bodyprefix + id.ToString() + "/HandRight").transform;
HipLeft = GameObject.Find(bodyprefix + id.ToString() + "/HipLeft").transform;
KneeLeft = GameObject.Find(bodyprefix + id.ToString() + "/KneeLeft").transform;
AnkleLeft = GameObject.Find(bodyprefix + id.ToString() + "/AnkleLeft").transform;
FootLeft = GameObject.Find(bodyprefix + id.ToString() + "/FootLeft").transform;
HipRight = GameObject.Find(bodyprefix + id.ToString() + "/HipRight").transform;
KneeRight = GameObject.Find(bodyprefix + id.ToString() + "/KneeRight").transform;
AnkleRight = GameObject.Find(bodyprefix + id.ToString() + "/AnkleRight").transform;
FootRight = GameObject.Find(bodyprefix + id.ToString() + "/FootRight").transform;
SpineShoulder = GameObject.Find(bodyprefix + id.ToString() + "/SpineShoulder").transform;
HandTipLeft = GameObject.Find(bodyprefix + id.ToString() + "/HandTipLeft").transform;
ThumbLeft = GameObject.Find(bodyprefix + id.ToString() + "/ThumbLeft").transform;
HandTipRight = GameObject.Find(bodyprefix + id.ToString() + "/HandTipRight").transform;
ThumbRight = GameObject.Find(bodyprefix + id.ToString() + "/ThumbRight").transform;

*/
}

    Quaternion ConvertOrientation(Quaternion rot, Quaternion mult, Vector3 mirror)
    {
        rot *= mult;

        Vector3 ang = rot.eulerAngles;
        ang.x *= mirror.x;
        ang.y *= mirror.y;
        ang.z *= mirror.z;
        rot.eulerAngles = ang;

        return rot;

    }


    public IDictionary<string, Quaternion> kinectRotations = new Dictionary<string, Quaternion>();



    Quaternion rot;

    Quaternion startingrot1;
    Quaternion startingrot2;
    Quaternion startingrot3;
    Quaternion offset1;
    Quaternion offset2;
    Quaternion offset3;
    Quaternion offset4;
    Quaternion offset5;
    Quaternion offset6;
    Quaternion offset7;
    Quaternion offset8;
    Quaternion offset9;
    Quaternion offset10;

    // Use this for initialization
    void Start()
    {


        /*

		startingrot1 = SpineMid.rotation;
		rot = KinectRiggingTools.s.kinectRotations ["SpineMid"];
		offset1 = startingrot1 * rot;

		startingrot2 = Neck.rotation;
		rot = KinectRiggingTools.s.kinectRotations ["Neck"];
		offset2 = startingrot2 * rot;

		startingrot3 = ShoulderLeft.rotation;
		rot = KinectRiggingTools.s.kinectRotations ["ShoulderLeft"];
		offset3 = startingrot3 * rot;


		offset4 = ShoulderRight.rotation*KinectRiggingTools.s.kinectRotations ["ShoulderRight"];


		offset5 = ElbowLeft.rotation * KinectRiggingTools.s.kinectRotations ["ElbowRight"];

		offset6 = ElbowRight.rotation * KinectRiggingTools.s.kinectRotations ["ElbowRight"];

		offset7 = KneeLeft.rotation * KinectRiggingTools.s.kinectRotations ["KneeLeft"];

		offset8 = KneeRight.rotation * KinectRiggingTools.s.kinectRotations ["KneeRight"];

		offset9 = HipLeft.rotation * KinectRiggingTools.s.kinectRotations ["HipLeft"];

		offset10 = HipRight.rotation * KinectRiggingTools.s.kinectRotations ["HipRight"];

		offset1.x = -offset1.x;
		offset1.y = offset1.y;
		offset1.z = -offset1.z;
		offset1.w = offset1.w;

		offset2.x = -offset2.x;
		offset2.y = offset2.y;
		offset2.z = -offset2.z;
		offset2.w = offset2.w;

		//shoulderleft
		offset3.x = offset3.x;
		offset3.y = offset3.y;
		offset3.z = offset3.z;
		offset3.w = -offset3.w;
		//shoulderright
		offset4.x = offset4.x;
		offset4.y = offset4.y;
		offset4.z = -offset4.z;
		offset4.w = offset4.w;

		//elbowleft
		offset5.x = -offset5.x;
		offset5.y = offset5.y;
		offset5.z = offset5.z;
		offset5.w = -offset5.w;

		//elbowright
		offset6.x = -offset6.x;
		offset6.y = offset6.y;
		offset6.z = offset6.z;
		offset6.w = -offset6.w;

		//kneeleft
		offset7.x = offset7.x;
		offset7.y = -offset7.y;
		offset7.z = offset7.z;
		offset7.w = offset7.w;

		//kneeright
		offset8.x = offset8.x;
		offset8.y = -offset8.y;
		offset8.z = offset8.z;
		offset8.w = offset8.w;

		//hipleft
		offset9.x = offset9.x;
		offset9.y = -offset9.y;
		offset9.z = offset9.z;
		offset9.w = -offset9.w;

		//hipright
		offset10.x = offset10.x;
		offset10.y = offset10.y;
		offset10.z = offset10.z;
		offset10.w = offset10.w;
*/
    }

    // Update is called once per frame
    void Update()
    {
        //ImitaBichoFeio();
        if (assignedname.Length > 1)
        {

            //RefreshMapping ();

        }
    }

    public void ImitaBichoFeio()
    {
        /*
        SpineMid.rotation = Quaternion.Slerp(SpineMid.rotation, ConvertOrientation(kSpineMid.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        Neck.rotation = Quaternion.Slerp(Neck.rotation, ConvertOrientation(kNeck.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

        KneeLeft.rotation = Quaternion.Slerp(KneeLeft.rotation, ConvertOrientation(kKneeLeft.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        KneeRight.rotation = Quaternion.Slerp(KneeRight.rotation, ConvertOrientation(kKneeRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

        AnkleLeft.rotation = Quaternion.Slerp(AnkleLeft.rotation, ConvertOrientation(kAnkleLeft.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        AnkleRight.rotation = Quaternion.Slerp(AnkleRight.rotation, ConvertOrientation(kAnkleRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

        ShoulderLeft.rotation = Quaternion.Slerp(ShoulderLeft.rotation, ConvertOrientation(kShoulderLeft.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        ShoulderRight.rotation = Quaternion.Slerp(ShoulderRight.rotation, ConvertOrientation(kShoulderRight.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

        ElbowLeft.rotation = Quaternion.Slerp(ElbowLeft.rotation, ConvertOrientation(kElbowLeft.rotation, Quaternion.Euler(0, 0, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        ElbowRight.rotation = Quaternion.Slerp(ElbowRight.rotation, ConvertOrientation(kElbowRight.rotation, Quaternion.Euler(0, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

        WristLeft.rotation = Quaternion.Slerp(WristLeft.rotation, ConvertOrientation(kWristLeft.rotation, Quaternion.Euler(0, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        WristRight.rotation = Quaternion.Slerp(WristRight.rotation, ConvertOrientation(kWristRight.rotation, Quaternion.Euler(0, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
        */

        /*
        SpineBase.transform.rotation =  Quaternion.Slerp(SpineBase.rotation, ConvertOrientation(kSpineBase.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

             SpineMid.transform.rotation = Quaternion.Slerp(SpineMid.rotation, ConvertOrientation(kSpineMid.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
             Neck.transform.rotation = Quaternion.Slerp(Neck.rotation, ConvertOrientation(kNeck.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
             Head.transform.rotation = Quaternion.Slerp(Head.rotation, ConvertOrientation(kHead.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             ShoulderLeft.transform.rotation = Quaternion.Slerp(ShoulderLeft.rotation, ConvertOrientation(kShoulderLeft.rotation, Quaternion.Euler(0f, 0, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             ElbowLeft.transform.rotation = Quaternion.Slerp(ElbowLeft.rotation, ConvertOrientation(kElbowLeft.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             WristLeft.transform.rotation = Quaternion.Slerp(WristLeft.rotation, ConvertOrientation(kWristLeft.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             ShoulderRight.transform.rotation = Quaternion.Slerp(ShoulderRight.rotation, ConvertOrientation(kShoulderRight.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             ElbowRight.transform.rotation = Quaternion.Slerp(ElbowRight.rotation, ConvertOrientation(kElbowRight.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             WristRight.transform.rotation = Quaternion.Slerp(WristRight.rotation, ConvertOrientation(kWristRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             HipLeft.transform.rotation = Quaternion.Slerp(HipLeft.rotation, ConvertOrientation(kHipLeft.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             KneeLeft.transform.rotation = Quaternion.Slerp(KneeLeft.rotation, ConvertOrientation(kKneeLeft.rotation, Quaternion.Euler(0f, 180, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             AnkleLeft.transform.rotation = Quaternion.Slerp(AnkleLeft.rotation, ConvertOrientation(kAnkleLeft.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             FootLeft.transform.rotation = Quaternion.Slerp(FootLeft.rotation, ConvertOrientation(kFootLeft.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             HipRight.transform.rotation = Quaternion.Slerp(HipRight.rotation, ConvertOrientation(kHipRight.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             KneeRight.transform.rotation = Quaternion.Slerp(KneeRight.rotation, ConvertOrientation(kKneeRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             AnkleRight.transform.rotation = Quaternion.Slerp(AnkleRight.rotation, ConvertOrientation(kAnkleRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed) ;
             FootRight.transform.rotation = Quaternion.Slerp(FootRight.rotation, ConvertOrientation(kFootRight.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
             SpineShoulder.transform.rotation = Quaternion.Slerp(SpineShoulder.rotation, ConvertOrientation(kSpineShoulder.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
             */

        SpineBase.transform.rotation = new Quaternion(SpineBase.transform.rotation.x + kSpineBase.transform.rotation.x, SpineBase.transform.rotation.y + kSpineBase.transform.rotation.y, SpineBase.transform.rotation.z + kSpineBase.transform.rotation.z, SpineBase.transform.rotation.w + kSpineBase.transform.rotation.w);
        SpineMid.transform.localRotation = new Quaternion(SpineMid.transform.rotation.x + kSpineMid.transform.rotation.x, SpineMid.transform.rotation.y + kSpineMid.transform.rotation.y, SpineMid.transform.rotation.z + kSpineMid.transform.rotation.z, SpineMid.transform.rotation.w + kSpineMid.transform.rotation.w);
        Neck.transform.localRotation = new Quaternion(Neck.transform.rotation.x + kNeck.transform.rotation.x, Neck.transform.rotation.y + kNeck.transform.rotation.y, Neck.transform.rotation.z + kNeck.transform.rotation.z, Neck.transform.rotation.w + kNeck.transform.rotation.w);
        Head.transform.localRotation = new Quaternion(Head.transform.rotation.x + kHead.transform.rotation.x, Head.transform.rotation.y + kHead.transform.rotation.y, Head.transform.rotation.z + kHead.transform.rotation.z, Head.transform.rotation.w + kHead.transform.rotation.w);
        ShoulderLeft.transform.localRotation = new Quaternion(ShoulderLeft.transform.rotation.x + kShoulderLeft.transform.rotation.x, ShoulderLeft.transform.rotation.y + kShoulderLeft.transform.rotation.y, ShoulderLeft.transform.rotation.z + kShoulderLeft.transform.rotation.z, ShoulderLeft.transform.rotation.w + kShoulderLeft.transform.rotation.w);
        ElbowLeft.transform.localRotation = new Quaternion(ElbowLeft.transform.rotation.x + kElbowLeft.transform.rotation.x, ElbowLeft.transform.rotation.y + kElbowLeft.transform.rotation.y, ElbowLeft.transform.rotation.z + kElbowLeft.transform.rotation.z, ElbowLeft.transform.rotation.w + kElbowLeft.transform.rotation.w);
        WristLeft.transform.localRotation = new Quaternion(WristLeft.transform.rotation.x + kWristLeft.transform.rotation.x, WristLeft.transform.rotation.y + kWristLeft.transform.rotation.y, WristLeft.transform.rotation.z + kWristLeft.transform.rotation.z, WristLeft.transform.rotation.w + kWristLeft.transform.rotation.w);
        ShoulderRight.transform.localRotation = new Quaternion(ShoulderRight.transform.rotation.x + kShoulderRight.transform.rotation.x, ShoulderRight.transform.rotation.y + kShoulderRight.transform.rotation.y, ShoulderRight.transform.rotation.z + kShoulderRight.transform.rotation.z, ShoulderRight.transform.rotation.w + kShoulderRight.transform.rotation.w);
        ElbowRight.transform.localRotation = new Quaternion(ElbowRight.transform.rotation.x + kElbowRight.transform.rotation.x, ElbowRight.transform.rotation.y + kElbowRight.transform.rotation.y, ElbowRight.transform.rotation.z + kElbowRight.transform.rotation.z, ElbowRight.transform.rotation.w + kElbowRight.transform.rotation.w);
        WristRight.transform.localRotation = new Quaternion(WristRight.transform.rotation.x + kWristRight.transform.rotation.x, WristRight.transform.rotation.y + kWristRight.transform.rotation.y, WristRight.transform.rotation.z + kWristRight.transform.rotation.z, WristRight.transform.rotation.w + kWristRight.transform.rotation.w);
        HipLeft.transform.localRotation = new Quaternion(HipLeft.transform.rotation.x + kHipLeft.transform.rotation.x, HipLeft.transform.rotation.y + kHipLeft.transform.rotation.y, HipLeft.transform.rotation.z + kHipLeft.transform.rotation.z, HipLeft.transform.rotation.w + kHipLeft.transform.rotation.w);
        KneeLeft.transform.localRotation = new Quaternion(KneeLeft.transform.rotation.x + kKneeLeft.transform.rotation.x, KneeLeft.transform.rotation.y + kKneeLeft.transform.rotation.y, KneeLeft.transform.rotation.z + kKneeLeft.transform.rotation.z, KneeLeft.transform.rotation.w + kKneeLeft.transform.rotation.w);
        AnkleLeft.transform.localRotation = new Quaternion(AnkleLeft.transform.rotation.x + kAnkleLeft.transform.rotation.x, AnkleLeft.transform.rotation.y + kAnkleLeft.transform.rotation.y, AnkleLeft.transform.rotation.z + kAnkleLeft.transform.rotation.z, AnkleLeft.transform.rotation.w + kAnkleLeft.transform.rotation.w);
        FootLeft.transform.localRotation = new Quaternion(FootLeft.transform.rotation.x + kFootLeft.transform.rotation.x, FootLeft.transform.rotation.y + kFootLeft.transform.rotation.y, FootLeft.transform.rotation.z + kFootLeft.transform.rotation.z, FootLeft.transform.rotation.w + kFootLeft.transform.rotation.w);
        HipRight.transform.localRotation = new Quaternion(HipRight.transform.rotation.x + kHipRight.transform.rotation.x, HipRight.transform.rotation.y + kHipRight.transform.rotation.y, HipRight.transform.rotation.z + kHipRight.transform.rotation.z, HipRight.transform.rotation.w + kHipRight.transform.rotation.w);
        KneeRight.transform.localRotation = new Quaternion(KneeRight.transform.rotation.x + kKneeRight.transform.rotation.x, KneeRight.transform.rotation.y + kKneeRight.transform.rotation.y, KneeRight.transform.rotation.z + kKneeRight.transform.rotation.z, KneeRight.transform.rotation.w + kKneeRight.transform.rotation.w);
        AnkleRight.transform.localRotation = new Quaternion(AnkleRight.transform.rotation.x + kAnkleRight.transform.rotation.x, AnkleRight.transform.rotation.y + kAnkleRight.transform.rotation.y, AnkleRight.transform.rotation.z + kAnkleRight.transform.rotation.z, AnkleRight.transform.rotation.w + kAnkleRight.transform.rotation.w);
        FootRight.transform.localRotation = new Quaternion(FootRight.transform.rotation.x + kFootRight.transform.rotation.x, FootRight.transform.rotation.y + kFootRight.transform.rotation.y, FootRight.transform.rotation.z + kFootRight.transform.rotation.z, FootRight.transform.rotation.w + kFootRight.transform.rotation.w);
        SpineShoulder.transform.localRotation = new Quaternion(SpineShoulder.transform.rotation.x + kSpineShoulder.transform.rotation.x, SpineShoulder.transform.rotation.y + kSpineShoulder.transform.rotation.y, SpineShoulder.transform.rotation.z + kSpineShoulder.transform.rotation.z, SpineShoulder.transform.rotation.w + kSpineShoulder.transform.rotation.w);

        /*
        
        
        SpineBase.transform.position = new Vector3(kSpineBase.transform.position.x, kSpineBase.transform.position.y, kSpineBase.transform.position.z );
        SpineMid.transform.position = new Vector3(kSpineMid.transform.position.x, kSpineMid.transform.position.y, kSpineMid.transform.position.z) ;
        Neck.transform.position = new Vector3(kNeck.transform.position.x, kNeck.transform.position.y, kNeck.transform.position.z );
        Head.transform.position = new Vector3(kHead.transform.position.x, kHead.transform.position.y, kHead.transform.position.z );
        ShoulderLeft.transform.position = new Vector3(kShoulderLeft.transform.position.x, kShoulderLeft.transform.position.y, kShoulderLeft.transform.position.z );
        ElbowLeft.transform.position = new Vector3(kElbowLeft.transform.position.x, kElbowLeft.transform.position.y, kElbowLeft.transform.position.z );
        WristLeft.transform.position = new Vector3(kWristLeft.transform.position.x, kWristLeft.transform.position.y, kWristLeft.transform.position.z );
        ShoulderRight.transform.position = new Vector3(kShoulderRight.transform.position.x, kShoulderRight.transform.position.y, kShoulderRight.transform.position.z );
        ElbowRight.transform.position = new Vector3(kElbowRight.transform.position.x, kElbowRight.transform.position.y, kElbowRight.transform.position.z );
        WristRight.transform.position = new Vector3(kWristRight.transform.position.x, kWristRight.transform.position.y, kWristRight.transform.position.z );
        HipLeft.transform.position = new Vector3(kHipLeft.transform.position.x, kHipLeft.transform.position.y, kHipLeft.transform.position.z );
        KneeLeft.transform.position = new Vector3(kKneeLeft.transform.position.x, kKneeLeft.transform.position.y, kKneeLeft.transform.position.z );
        AnkleLeft.transform.position = new Vector3(kAnkleLeft.transform.position.x, kAnkleLeft.transform.position.y, kAnkleLeft.transform.position.z );
        FootLeft.transform.position = new Vector3(kFootLeft.transform.position.x, kFootLeft.transform.position.y, kFootLeft.transform.position.z );
        HipRight.transform.position = new Vector3(kHipRight.transform.position.x, kHipRight.transform.position.y, kHipRight.transform.position.z );
        KneeRight.transform.position = new Vector3(kKneeRight.transform.position.x, kKneeRight.transform.position.y, kKneeRight.transform.position.z );
        AnkleRight.transform.position = new Vector3(kAnkleRight.transform.position.x, kAnkleRight.transform.position.y, kAnkleRight.transform.position.z );
        FootRight.transform.position = new Vector3(kFootRight.transform.position.x, kFootRight.transform.position.y, kFootRight.transform.position.z );
        SpineShoulder.transform.position = new Vector3(kSpineShoulder.transform.position.x, kSpineShoulder.transform.position.y, kSpineShoulder.transform.position.z );
        //Hips.transform.position = new Vector3(kHead.transform.position.x, kHead.transform.position.y, kHead.transform.position.z);
      //  Debug.Log(HandLeft.transform.rotation);
     */
    }

    public float interpolateSpeed = 10f;

    public void RefreshMapping()
    {


        if (assignedname != null)
        {
            Vector3 offsetpos = kSpineBase.position;
            offsetpos.y += offsetY;
            SpineBase.position = offsetpos;
            //Head.position = kHead.position;

            SpineMid.rotation = Quaternion.Slerp(SpineMid.rotation, ConvertOrientation(kSpineMid.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
            Neck.rotation = Quaternion.Slerp(Neck.rotation, ConvertOrientation(kNeck.rotation, Quaternion.Euler(0f, 90f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

            KneeLeft.rotation = Quaternion.Slerp(KneeLeft.rotation, ConvertOrientation(kKneeLeft.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
            KneeRight.rotation = Quaternion.Slerp(KneeRight.rotation, ConvertOrientation(kKneeRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

            AnkleLeft.rotation = Quaternion.Slerp(AnkleLeft.rotation, ConvertOrientation(kAnkleLeft.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
            AnkleRight.rotation = Quaternion.Slerp(AnkleRight.rotation, ConvertOrientation(kAnkleRight.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

            ShoulderLeft.rotation = Quaternion.Slerp(ShoulderLeft.rotation, ConvertOrientation(kShoulderLeft.rotation, Quaternion.Euler(0f, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
            ShoulderRight.rotation = Quaternion.Slerp(ShoulderRight.rotation, ConvertOrientation(kShoulderRight.rotation, Quaternion.Euler(0f, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

            ElbowLeft.rotation = Quaternion.Slerp(ElbowLeft.rotation, ConvertOrientation(kElbowLeft.rotation, Quaternion.Euler(0, 0, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
            ElbowRight.rotation = Quaternion.Slerp(ElbowRight.rotation, ConvertOrientation(kElbowRight.rotation, Quaternion.Euler(0, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);

            WristLeft.rotation = Quaternion.Slerp(WristLeft.rotation, ConvertOrientation(kWristLeft.rotation, Quaternion.Euler(0, 180f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);
            WristRight.rotation = Quaternion.Slerp(WristRight.rotation, ConvertOrientation(kWristRight.rotation, Quaternion.Euler(0, 0f, 90f), new Vector3(1f, -1f, -1f)), Time.deltaTime * interpolateSpeed);



            /*
			SpineMid.rotation = ConvertOrientation (kSpineMid.rotation, Quaternion.Euler (180f, 180f, 270f), mirroroffset);
			
			KneeLeft.rotation = ConvertOrientation (kKneeLeft.rotation, Quaternion.Euler (1f, 270f, 90f), mirroroffset);
			KneeRight.rotation = ConvertOrientation (kKneeRight.rotation, Quaternion.Euler (1f, 90f, 90f), mirroroffset);
			
			AnkleLeft.rotation = ConvertOrientation (kAnkleLeft.rotation, Quaternion.Euler (1f, 1f, 90f), mirroroffset);
			AnkleRight.rotation = ConvertOrientation (kAnkleRight.rotation, Quaternion.Euler (1f, 1f, 90f), mirroroffset);
			
			
			ShoulderLeft.rotation = ConvertOrientation (kShoulderLeft.rotation, Quaternion.Euler (125f, 45f, 225f), mirroroffset);
			ShoulderRight.rotation = ConvertOrientation (kShoulderRight.rotation, Quaternion.Euler (45f, 90f, 90f), mirroroffset);
			
			
			ElbowLeft.rotation = ConvertOrientation (kElbowLeft.rotation, Quaternion.Euler (1f, 90f, 90f), mirroroffset);
			ElbowRight.rotation = ConvertOrientation (kElbowRight.rotation, Quaternion.Euler (1f, 90f, 270f), mirroroffset);
			
			WristLeft.rotation = ConvertOrientation (kWristLeft.rotation, Quaternion.Euler (90f, 270f, 135f), mirroroffset);
			WristRight.rotation = ConvertOrientation (kWristRight.rotation, Quaternion.Euler (1f, 90f, 270f), mirroroffset);

			Neck.rotation = ConvertOrientation (kNeck.rotation, Quaternion.Euler (0f, 90f, 90f), mirroroffset);
			*/


        }
    }
}