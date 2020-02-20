using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public GameObject options;

    void Start()
    {
        options.SetActive(false);        
    }

    public void Click()
    {
        if (options.activeSelf == false)
        {
            options.SetActive(true);
        }
        else
        {
            options.SetActive(false);
        }

    }


}
