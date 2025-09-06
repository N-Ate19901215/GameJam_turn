using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class point : MonoBehaviour
{
    public float allPoint = 0;
    public Text textPoint;
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
        
        textPoint.text = string.Format(""+(int)allPoint);
        
        }
    }
}
