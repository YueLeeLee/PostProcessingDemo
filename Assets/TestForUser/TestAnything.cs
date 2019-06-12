using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestAnything : MonoBehaviour
{
    public int testNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnValidate()
    {
        //if(transform.GetSiblingIndex()==0)
        Debug.Log("OnValidate " + transform.GetSiblingIndex(), this);
    }
}
