using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TimeLine : MonoBehaviour, IDragHandler
{
    float distance = 10.0f;
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, distance);

        transform.position = mousePosition;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.timeScale==1)
            {
                Time.timeScale = 0;
            }
            else if(Time.timeScale==0)
            {
                Time.timeScale = 1;
            }
        }
    }
}
