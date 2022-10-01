using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{

    public static int score = 0;

    public TextMeshProUGUI scoreUI;

    public Animator scoreAnimator;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void IncreaseScore()
    {
        score += 1;
        scoreAnimator.Play(0);
        scoreUI.text = score.ToString("00");
    }

    

}
