using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public float shiftTime = 60;
    public Text textTime;
    public startCount startCount;
    public mouseCollider mouseCollider;
    public point point ;
       public static float score = 0;

    
     // Start is called before the first frame update
    void Start()
    {
        startCount = FindObjectOfType<startCount>();
        mouseCollider = FindObjectOfType<mouseCollider>();
        point = FindObjectOfType<point>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!startCount.pose){
        shiftTime -= Time.deltaTime;
        textTime.text = string.Format(""+(int)shiftTime);
            if((int)shiftTime<=0){
                Debug.LogWarning("finish");

                score =  point.allPoint ;
                SceneManager.LoadScene ("Result");
            }
        }
    }
}
