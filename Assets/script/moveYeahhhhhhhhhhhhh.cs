using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveYeahhhhhhhhhhhhh : MonoBehaviour
{
    public bool pos = true;
    public startCount startCount;
    public mouseCollider mouseCollider;
    // Start is called before the first frame update
    void Start()
    {
        startCount = FindObjectOfType<startCount>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseCollider = FindObjectOfType<mouseCollider>();
        if(!startCount.pose){
            if(mouseCollider.Score > 4){
                if(Input.GetKeyDown(KeyCode.D)){
                    pos = false;
                }

                if(Input.GetKeyDown(KeyCode.A)){
                    pos = true;
                }
            }
                if(pos){
                    gameObject.transform.position = new Vector3(-1.55620003f,0.449999988f,0);
                }
                else{
                    gameObject.transform.position = new Vector3(1.47000003f,0.449999988f,0);
                }
            
        }
    }
}
