using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class FocusHighlight : MonoBehaviour, IMixedRealityFocusHandler
{
    Renderer rend;

    public Color defaultColor = Color.green;
    public Color highlightColor = Color.red;

    private void Awake()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    // Use this for initialization
    void Start()
    {
        rend.material.color = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnFocusEnter(FocusEventData eventData)
    {
        rend.material.color = highlightColor;
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        rend.material.color = defaultColor;
    }
}