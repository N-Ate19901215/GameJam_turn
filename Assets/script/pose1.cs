using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class pose1 : MonoBehaviour,IPointerClickHandler
{
    public startCount startCount;
    public GameObject title;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData){
        Debug.Log("oihaghroheioaheap");
        startCount.pose = false;
        title.SetActive(false);
        gameObject.SetActive(false);
    }

}
