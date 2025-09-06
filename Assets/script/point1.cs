using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lastpoint : MonoBehaviour
{
    
    public Text textPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        textPoint.text = string.Format(""+(int)time.score);
        
        
    }
}
