using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layout : MonoBehaviour
{
    public View[] views;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var v in views)
        {
            v.HideOtherViewButton = FocusOnView;
        }
    }

    void FocusOnView(View view)
    {
        foreach (var v in views)
        {
            if (v != view) v.Unfocus();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
