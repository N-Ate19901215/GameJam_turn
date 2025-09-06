using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class pose2 : MonoBehaviour,IPointerClickHandler
{
    public startCount startCount;
    public GameObject title,modoru;
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
        SceneManager.LoadScene("title");
    }

}
