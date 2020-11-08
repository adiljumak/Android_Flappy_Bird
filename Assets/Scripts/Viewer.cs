using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewer : MonoBehaviour
{

    
    public GameObject Column;
    int colColumns = 4;
    GameObject[] Columns;
    float timeBetColumns = 1;

   

    private void Start()
    {
        Columns = new GameObject[colColumns];
        StartCoroutine(SpawnColumns());
    }


    private void Update()
    {
        if(BirdLogic.isEnd)
            StopAllCoroutines();
    }
    IEnumerator SpawnColumns()
    {
        for (int i = 0; i < colColumns; i++)
        {
            Columns[i] = Instantiate(Column, new Vector2(4, Random.Range(-2.5f, 2.5f)), Quaternion.identity);
            yield return new WaitForSeconds(timeBetColumns);
        }


        while (true)
        {
            for (int i = 0; i < colColumns; i++)
            {
                Columns[i].transform.position = new Vector2(4, Random.Range(-2.5f, 2.5f));               
                yield return new WaitForSeconds(timeBetColumns);
            }
            
                
        }
    }
}
