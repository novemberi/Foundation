using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField]
    private Dropdown dropDown;

    // Start is called before the first frame update
    void Start()
    {
        dropDown.options = Screen.resolutions.Select(r => new Dropdown.OptionData($"{r.width} * {r.height}")).ToList();
    }

    // Update is called once per frame
    void Update()
    {

    }
}