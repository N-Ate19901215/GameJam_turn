using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class kiku : MonoBehaviour,IPointerClickHandler
{
    public  mouseCollider mouseCollider;
    // Start is called before the first frame update
    void Start()
    {
        mouseCollider = FindObjectOfType<mouseCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData){
        mouseCollider.Score = 0;
        mouseCollider.scoreFirst1 = false;
        mouseCollider.scoreFirst2 = false;
        mouseCollider.scoreFirst3 = false;
        mouseCollider.scoreFirst4 = false;
    }
}
