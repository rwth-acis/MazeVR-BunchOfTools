using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class DoorInteraction : MonoBehaviour, IMixedRealityPointerHandler
{

    private DoorController door;

    private void Awake()
    {
        door = GetComponent<DoorController>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDragged(MixedRealityPointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(MixedRealityPointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerClicked(MixedRealityPointerEventData eventData)
    {
        if (door == null)
        {
            Debug.LogError("No DoorController found on the object");
            return;
        }
        door.DoorOpen = !door.DoorOpen;
    }
}