using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (var res in Screen.resolutions)
        {
            Debug.Log($"{res.width} , {res.height}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}