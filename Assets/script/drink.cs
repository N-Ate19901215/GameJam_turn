using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class drink : MonoBehaviour ,IPointerEnterHandler
{
    [SerializeField] GameObject ringo,otya,kohi;
    [SerializeField] drink1 drink1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void OnPointerEnter(PointerEventData eventData){
        drink1.drinkSelect = true;
    }
}
