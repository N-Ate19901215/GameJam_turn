using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topping : MonoBehaviour
{
    [SerializeField] GameObject Ice,Cream;
    public bool otya,kohi,ringo = false;
    public int ice,cream =-1;
     // Start is called before the first frame update
    void Start()
    {
        otya = true;
        ice = -1;
        cream =-1;
    }

    // Update is called once per frame
    void Update()
    {

        

        if(ice == 0)
            Ice.SetActive(true);
        else
            Ice.SetActive(false);

        if(cream == 0)
            Cream.SetActive(true);
        else
            Cream.SetActive(false);

    }

    void OnTriggerExit2D(Collider2D other){
    if(other.gameObject.tag == "ice"){
            Debug.LogError("inIce");
            
            ice = 0;
        }
    
    if(other.gameObject.tag == "cream"){
            Debug.LogError("inCream");

            cream = 0;
        }
    }


}
