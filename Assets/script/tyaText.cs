using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class tyaText : MonoBehaviour
{
    public int tyaScore=0;
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
        tyaScore++;

        transform.DOLocalMove(new Vector3(-1.5f, 0, 0), 1.0f);

        //if(tyaScore >= 0)
        //this.GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0,1);
       
        spriteRenderer.DOFade(0, 2f).SetEase(Ease.OutQuad);
    }

    
}
