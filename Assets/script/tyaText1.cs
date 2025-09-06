using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class iceTextYeah : MonoBehaviour
{
    public float IceScore=0;
    SpriteRenderer spriteRenderer;
    Color color;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
       

    }

    // Update is called once per frame
    void Update()
    {
        IceScore += Time.deltaTime;
        
        
        //if(IceScore >=1){
        transform.DOLocalMove(new Vector3(-1.5f, 0, 0), 1.0f);

        //if(tyaScore >= 0)
        //this.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0,1);
       
        spriteRenderer.DOFade(0, 2f).SetEase(Ease.OutQuad);
        /*}
        else{
            spriteRenderer.color -= new Color(0, 0, 0,1);
        }*/
    }

    
}
