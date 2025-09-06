using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ctrl : MonoBehaviour
{

    Vector3 previusQ,nowQ;

    float speed = 0.5f;
    public moveYeahhhhhhhhhhhhh move;
     public startCount startCount;
    // Start is called before the first frame update
    void Start()
    {
        startCount = FindObjectOfType<startCount>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!startCount.pose){
        if(Input.GetMouseButtonDown(0)){
            if(!move.pos){
                previusQ = Input.mousePosition;
            }
        }
    if(Input.GetMouseButton(0)){
        if(!move.pos){
            nowQ = Input.mousePosition;
            Vector3 mouseQuaternion = (nowQ - previusQ );
            float rotation = mouseQuaternion.x  * speed;
            transform.Rotate(0,0,rotation);


            previusQ = nowQ;
        }
    }
        }
    
    }

    public void Reset(){
        gameObject.transform.localEulerAngles = new Vector3(0,0,-1.442f);
    }

}
