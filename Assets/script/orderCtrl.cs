using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderCtrl : MonoBehaviour
{
    [SerializeField] Transform kohiTransform,otyaTransform,ringoTransform,iceTransform,creamTransform;
    public startCount startCount;
    bool startFirst = false;
    public int drinkRand,iceRand,creamRand = -1;
    public bool orderFirst,orderFirst2,orderFirst3 = false;
    // Start is called before the first frame update
    void Start()
    {
        startCount = FindObjectOfType<startCount>();
       
    }

    // Update is called once per frame
    void Update()
    {
       /* if(!startCount.pose && !startFirst){
           order();
           startFirst = true;
        }*/

    }

    public void order(){
        if(!orderFirst)
        drinkRand = Random.Range(0,3);
        //drinkRand = 0;

        if(drinkRand == 0){
            Transform copyOtyaTransform = Instantiate(otyaTransform);            
        }
        if(drinkRand == 1){
            Transform copyKohiTransform = Instantiate(kohiTransform);            
        }
        if(drinkRand == 2){
            Transform copyRingoTransform = Instantiate(ringoTransform);            
        }

    } 
    public void order2(){
        if(!orderFirst2)
        iceRand = Random.Range(-1,1);

       // iceRand = 0;
        if(iceRand == 0){
            Transform copyIceTransform = Instantiate(iceTransform);
        }
        /*if(iceRand == 1){
            iceRand = -1;
        }*/
    }

    public void order3(){
        if(!orderFirst3)
        creamRand = Random.Range(-1,1);


        if(creamRand == 0){
            Transform copyCreamTransform = Instantiate(creamTransform);
        }
        
        /*if(creamRand == 1){
            creamRand= -1;
        }*/
    }
}
