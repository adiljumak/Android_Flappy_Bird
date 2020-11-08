using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float start = 2;
    public float bet = 0.8f;
    public static int score = 0;
    public UnityEngine.UI.Text text;


    private void Start()
    {
        StartCoroutine(ScorePlus());
    }
    void Update()
    {
        text.text = score.ToString();
    }
    


    IEnumerator ScorePlus()
    {

        yield return new WaitForSeconds(start);

        while (true && !BirdLogic.isEnd)
        {
            yield return new WaitForSeconds(bet);

            score++;           
        }    
    }
}
