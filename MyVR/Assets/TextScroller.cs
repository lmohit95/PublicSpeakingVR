using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroller : MonoBehaviour
{
   public float scrollSpeed=1;

    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 localVectorUp = transform.TransformDirection(0,1,0);
        pos += localVectorUp * scrollSpeed * Time.deltaTime;
        transform.position = pos;

        if (pos.y >= 8) Destroy(gameObject);
    }
}