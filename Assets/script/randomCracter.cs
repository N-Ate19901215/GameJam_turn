using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomCracter : MonoBehaviour
{
    [SerializeField] GameObject girl,rinka,white;
    [SerializeField] Transform girlTransform,rinkaTransform,whiteTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rnd(){
        int rand = Random.Range(0,3);
       // int rand = 0;
        Debug.Log(rand);
        if(rand == 0){
            Transform copyGirl1Transform = Instantiate(girlTransform);            
            //girl.SetActive(true);
        }
        if(rand == 1){
            Transform copyRinka1Transform = Instantiate(rinkaTransform);  
           // rinka.SetActive(true);
        }
        if(rand == 2){
            Transform copyWhite1Transform = Instantiate(whiteTransform);  
           
        }

    }
}
