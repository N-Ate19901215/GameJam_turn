using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCount : MonoBehaviour
{
    public float count = 3;
    public bool pose = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count >-1){
        count -= Time.deltaTime;
        }
        
        if((int)count >= 0 ){
            pose = true;
        }
        if(count < 0){
            pose = false;
        }

        Debug.Log("count"+(int)count);
    }
}
