using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdLogic : MonoBehaviour
{
    public static bool isEnd { get; set; } 
    
    public float g = -2.5f;
    public float F = 8;
    float timer;
    public float k_timer = 30;

    bool tap = false;
 
    void Update()

    {
        if (Input.touchCount == 0) tap = false;
        if(Input.touchCount > 0 && !tap)
        {
            tap = true;
            timer = F;
        }
        transform.Translate(new Vector2(0, timer) * Time.deltaTime);
        if (timer > g)
            timer -= Time.deltaTime * k_timer;
        else
            timer = g;
        if (isEnd)
        {
            g = 0;
            F = 0;
            timer = 0;
        }
            
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Column")
            isEnd = true;
    }

}
