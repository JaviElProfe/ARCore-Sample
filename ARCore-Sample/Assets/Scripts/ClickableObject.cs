using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;


// Add EventSystem to scene (UI/EventSystem)
// Add PhysicsRaycaster component to Camera
public class ClickableObject : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent OnClick;
    public void OnPointerClick(PointerEventData data)
    {
        Debug.Log("Clicked on " + gameObject.name);
        OnClick.Invoke();
    }

}