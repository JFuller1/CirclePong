using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggVisualController : MonoBehaviour
{
    void Update()
    {
        //pass score to this script
        //make egg rotate faster with score
        
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
