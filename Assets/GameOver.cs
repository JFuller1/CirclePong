using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject egg;

    public GameObject mouth;

    bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (egg != null)
        {
            if (dead)
            {
                if (Vector3.Magnitude(mouth.transform.position - egg.transform.position) <= 0.4)
                {
                    Destroy(egg);
                    mouth.GetComponent<Animator>().Play("Closed");
                }
                else
                {
                    mouth.transform.position = Vector3.Lerp(mouth.transform.position, egg.transform.position, Time.deltaTime * 5);
                }
            }
            else
            {
                mouth.transform.position = new Vector2(egg.transform.position.x, mouth.transform.position.y);
            }
        }
        else
        {
            Vector3 offScreen = new Vector2(mouth.transform.position.x, -12);
            mouth.transform.position = Vector3.Lerp(mouth.transform.position, offScreen, Time.deltaTime * 2);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dead = true;
        egg.GetComponent<ballController>().ballSpeed = 0.5f;
    }
}
