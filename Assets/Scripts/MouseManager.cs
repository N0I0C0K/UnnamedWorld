using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EventVec3 : UnityEvent<Vector3> { }
public class MouseManager : MonoBehaviour
{
    RaycastHit hitInfo;
    public EventVec3 onMouseClicked;
    private void Update()
    {
        setCursorTexture();
        mouseControl();
    }
    void setCursorTexture()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            //
        }
    }
    void mouseControl()
    {
        if (Input.GetMouseButtonDown(0) && hitInfo.collider != null)
        {
            if (hitInfo.collider.tag == "Ground")
            {
                onMouseClicked?.Invoke(hitInfo.point);
            }
        }
    }
}
