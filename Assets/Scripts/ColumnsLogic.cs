using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsLogic : MonoBehaviour
{
    float speed = -0.05f;

    private void FixedUpdate()
    {
        if(!BirdLogic.isEnd)
            transform.Translate(new Vector2(speed, 0));
    }

}
