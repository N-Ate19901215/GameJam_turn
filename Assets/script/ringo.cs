using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ringo : MonoBehaviour,IPointerClickHandler
{
    public drink drink;
    public bool flag;
    public drink1 drink1;
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
       
    }

    public void OnPointerClick(PointerEventData pointerEventData){
        if(!startCount.pose){
        if(move.pos){
            drink1.drink = 2;
        }
        }
    }

}
