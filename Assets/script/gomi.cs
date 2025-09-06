using UnityEngine;
using UnityEngine.EventSystems;


public class gomi : MonoBehaviour,IPointerExitHandler,IPointerEnterHandler,IPointerClickHandler
{
    public Sprite gomi1,gomi2;
    private SpriteRenderer image;
    public moveYeahhhhhhhhhhhhh move;
    public topping topping;
    public drink1 drink1;
    public ctrl ctrl;
    public respawn respawn;
    public kuki kuki;
    // Start is called before the first frame update
    void Start()
    {
        if(image == null){
         image = GetComponent<SpriteRenderer>();
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData){
        image.sprite = gomi2;
    }
    public void OnPointerExit(PointerEventData eventData){
        image.sprite = gomi1;
    }

    public void OnPointerClick(PointerEventData eventData){
        Debug.Log("消した");
        move.pos = true;
        drink1.drink = 0;
        topping.ice = -1;
        topping.cream = -1;
        ctrl.Reset();
        respawn.Reset();
        kuki.Reset();
    }
}
