using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShereManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool SystemII=true;
    public Rigidbody rig;
    public Transform target;
    public MainManager manager;
    public float speed;
public int radius=5;
    public Vector3 point;
     public int S=1;
        public bool metka=true;
    void Start()
    {
        int  rot = Random.Range(1,360);
        transform.Rotate(0.0f,rot,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
     
         RaycastHit hit;
    //??? ???, ?????????? ?? ??????? ????? ??????? ? ????????? ? ??????? ????
    Ray ray = new Ray(transform.position,  transform.TransformDirection(Vector3.forward));
    //??????? ???
    Physics.Raycast(ray, out hit);

    //???? ??? ? ???-?? ?????????, ??..
    if (hit.collider != null){
        //???? ??? ?? ????? ? ????
    
            Debug.Log("??????? ?? ?????!!!");
            
            Debug.Log(hit.collider.name);
            if(hit.collider.name=="Sphere(Clone)" || hit.collider.name=="Sphere")
            {
        //            int  rot = Random.Range(1,360);
        //  transform.Rotate(0.0f,rot,0.0f);
        if(metka==true)
        {     StartCoroutine(DoIt());}

         Debug.Log("StartCor");
            }
            else{
       
            }
    //    Debug.Log(hit.point);
        //   Debug.Log("Ray"+ray.origin);
        //?????? ??? ??????????? ?????? ??? ? ???? Scene
        Debug.DrawLine(ray.origin, hit.point,Color.red);
          point=hit.point;
             foreach(var p in manager.data)
        {
        if(Mathf.Abs(Mathf.Abs(p.x)-Mathf.Abs(point.x))<radius && Mathf.Abs(Mathf.Abs(p.z)-Mathf.Abs(point.z))<radius)
        {
 Debug.Log("i do it");
                   int  rot = Random.Range(1,360);
         transform.Rotate(0.0f,rot,0.0f);
        }
        }
    } 
    this.gameObject.transform.Translate(0,0,speed*Time.deltaTime);
    // if(metka==true)
    // { 
            
        
   }

   private  IEnumerator DoIt()
    {
        metka=false;
        //                    int  rot = Random.Range(1,360);
        //  transform.Rotate(0.0f,rot,0.0f);
            yield return new WaitForSeconds(1f);
        metka=true;
    }
    void OnCollisionEnter(Collision myCollision)
     {
  // ??????????? ???????????? ? ????? ????????????? ?????????

     if (myCollision.gameObject.name == "Wall") {
            int  rot = Random.Range(1,360);
        transform.Rotate(0.0f,rot,0.0f);
      Debug.Log("Hit the wall");
      if(SystemII==true)
      {
      manager.data.Add(point);
    }
    }
    //  if (myCollision.gameObject.name =="Sphere(Clone)"  || myCollision.gameObject.name =="Sphere") {
    //         int  rot = Random.Range(1,360);
    //     transform.Rotate(0.0f,rot,0.0f);
    //   Debug.Log("Hit the wall");
    // }
  }

}
