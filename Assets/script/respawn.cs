using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject Koppu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "damage"){
            this.gameObject.transform.position = Koppu.transform.position;
        }
    }

    public void Reset(){
        gameObject.transform.localPosition = new Vector3(0.0900000036f,0,0);
        gameObject.transform.eulerAngles = new Vector3(0,0,0);
    } 
}
