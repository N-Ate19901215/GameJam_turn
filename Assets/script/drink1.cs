using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class drink1 : MonoBehaviour , IPointerExitHandler
{
    [SerializeField] GameObject ringo,otya,kohi;
    public bool select = false;
    bool flag = true; 
    public bool drinkSelect = false;
    public int drink = 0;
    public GameObject dRingo,dOtya,dKohi;
    // Start is called before the first frame update
    void Start()
    {
        //Otya = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(drinkSelect){
        ringo.SetActive(true);
        otya.SetActive(true);
        kohi.SetActive(true);
        }
        else{
        ringo.SetActive(false);
        otya.SetActive(false);
        kohi.SetActive(false);
        }

        if(drink == 0){
            dRingo.SetActive(false);
            dKohi.SetActive(false);
            dOtya.SetActive(true);
        }

        if(drink == 1){
            dRingo.SetActive(false);
            dKohi.SetActive(true);
            dOtya.SetActive(false);
        }

        if(drink==2){
            dRingo.SetActive(true);
            dKohi.SetActive(false);
            dOtya.SetActive(false);
        }

    }

    
    
    public void OnPointerExit(PointerEventData eventData){
        drinkSelect = false;
    }

    public void Reset(){
       drink = 0;
    }

}
