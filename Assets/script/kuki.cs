using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuki : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Reset(){
        gameObject.transform.localPosition = new Vector3(0,-1.42219996f,0);
        gameObject.transform.eulerAngles = new Vector3(0,0,0);
    }
}
