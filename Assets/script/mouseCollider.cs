using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Drawing;

public class mouseCollider : MonoBehaviour
{
    [SerializeField] GameObject open , close,clear;
    bool mouseHit = false;
    bool Clear = false ,ClearFirst;
    Transform parent;
    float FinishTime = 0;
    public randomCracter cahraChange; 
    public topping topping;
    public Transform koppu;
    public moveYeahhhhhhhhhhhhh move;
    public int charaScore;
    public ctrl ctrl;
    public respawn respawn;
    public kuki kuki;
    public drink1 drink1;
    public startCount startCount;
    public orderCtrl orderCtrl;
    public float Score;
    public bool scoreFirst1, scoreFirst2,scoreFirst3,scoreFirst4;
    public float point = 1000;
    public point allPoint;
    // Start is called before the first frame update
    void Start()
    {
        mouseHit = false;
        parent = gameObject.transform;
        cahraChange = FindObjectOfType<randomCracter>();
        topping = FindObjectOfType<topping>();
        move = FindObjectOfType<moveYeahhhhhhhhhhhhh>();
        ctrl = FindObjectOfType<ctrl>();
        respawn = FindObjectOfType<respawn>();
        kuki = FindObjectOfType<kuki>();
        drink1 = FindObjectOfType<drink1>();
        startCount = FindObjectOfType<startCount>();
        orderCtrl = FindObjectOfType<orderCtrl>();
        allPoint = FindObjectOfType<point>();
    }

    // Update is called once per frame
    void Update()
    {
        Score += 2*Time.deltaTime;
        

        if((int)Score == 1 && !scoreFirst1) {
            
            orderCtrl.order();

            open.SetActive(false);
            close.SetActive(false);
            clear.SetActive(true);

            transform.DOScaleY(0.75f,0.1f);
            transform.DOScaleY(0.85f,0.1f)
            .SetDelay(0.1f)
            .SetEase(Ease.OutQuad);

            orderCtrl.orderFirst = true;
            scoreFirst1 = true;
        }
        
        if((int)Score == 2 && !scoreFirst2){ 
            
            orderCtrl.order2();

            if(orderCtrl.iceRand == 0){
                transform.DOScaleY(0.75f,0.1f);
                transform.DOScaleY(0.85f,0.1f)
                .SetDelay(0.1f)
                .SetEase(Ease.OutQuad);
            }

            orderCtrl.orderFirst2 = true;
            scoreFirst2 = true;
        }
        
        if((int)Score == 3 && !scoreFirst3) {     
            
            orderCtrl.order3();

            if(orderCtrl.creamRand == 0){
                transform.DOScaleY(0.75f,0.1f);
                transform.DOScaleY(0.85f,0.1f)
                .SetDelay(0.1f)
                .SetEase(Ease.OutQuad);
            }

            orderCtrl.orderFirst3 = true;
            scoreFirst3 = true;
        }
        if((int)Score == 4 && !scoreFirst4) { 
               
                open.SetActive(false);
                close.SetActive(true);
                clear.SetActive(false);
            
            scoreFirst4 = true;
        }
        

        if(!startCount.pose){
        charaScore ++;
        cahraChange = FindObjectOfType<randomCracter>();
        Debug.Log(FinishTime);
        if(!Input.GetMouseButton(0) && mouseHit == true){
            Debug.Log("nice!!!");
            
            if(orderCtrl.drinkRand  == drink1.drink){
                if(topping.ice == orderCtrl.iceRand) {
                    if(topping.cream == orderCtrl.creamRand)
                    Clear  = true;
                }
            }
        }
         Debug.Log(mouseHit);
        if(Clear && !ClearFirst){
            open.SetActive(false);
            close.SetActive(false);
            clear.SetActive(true);
            allPoint.allPoint += point;

            ClearFirst = true;
        }
        if(Clear){
                FinishTime += 1.5f*Time.deltaTime;
        }
        else{
            point -= 100*Time.deltaTime;
        }

        if((int)FinishTime == 2){
            move.pos = true;
            Destroy(this.gameObject);
            topping.cream = -1;
            topping.ice = -1;
            ctrl.Reset();
            respawn.Reset();
            kuki.Reset();
            drink1.Reset();
           // move.pos = true;
            cahraChange.rnd();
            ClearFirst=false;
            orderCtrl.orderFirst =  false;
            orderCtrl.orderFirst2 = false;
            orderCtrl.orderFirst2 = false;

        }

        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(!startCount.pose){
        if(charaScore >= 10){
        if(!Clear){
        Debug.Log("hit???");
        if(other.gameObject.tag == "storo"){
            foreach (Transform child in parent){
                open.SetActive(true);
                close.SetActive(false);
            }
        mouseHit = true;

        Debug.Log("hit");
        }
        }
        }
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(!startCount.pose){
        if(!Clear){
        if(other.gameObject.tag == "storo"){
            open.SetActive(false);
            close.SetActive(true);

            mouseHit = false;
        }

        
        }
        }
    }
}
