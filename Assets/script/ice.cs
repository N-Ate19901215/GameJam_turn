using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ice : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isDragging = false;
    private Vector3 offset;
     [SerializeField] private Camera mainCamera;
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
        if(!startCount.pose){
        Debug.Log("isDragging"+isDragging);
       /* if(Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            Collider2D collider = Physics2D.OverlapPoint(mousePosition);
            if(collider != null && collider.gameObject == gameObject){
                isDragging = true;
                offset = transform.position - mousePosition;

            }
             //isDragging = true;
        }*/

        if(Input.GetMouseButtonUp(0)){
            //isDragging = false;
        }

        if(isDragging){
            if(move.pos){
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = 0;
                transform.position = mousePosition+offset;
            }
        }

        }
    }

   public void OnPointerDown(PointerEventData eventData)
    {
        if(!startCount.pose){
        if(move.pos){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isDragging = true;
            offset = transform.position - mousePosition;
        }
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if(!startCount.pose){
        if(move.pos){
            isDragging = false;
            transform.position = new Vector3(3.8099997f,-1.10000002f,0);
        }
    }
    }
    
            
}
