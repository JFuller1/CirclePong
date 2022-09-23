using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text txt;
    // Get variable to track points
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        //txt.text= the variable;
    }

    // Update is called once per frame
    void Update()
    {
        /* if condition
         *   variable++;
         *   txt.text = variable;
         */

    }
}
