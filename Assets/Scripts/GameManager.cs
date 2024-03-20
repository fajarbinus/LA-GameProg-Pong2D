using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL;
    public int PlayerScoreR;

    public TMP_Text UIPlayerScoreL;
    public TMP_Text UIPlayerScoreR;

    public static GameManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy (gameObject);
    }

    void Start()
    {
        PlayerScoreL = 0;
        PlayerScoreR = 0;

        UIPlayerScoreL.text = PlayerScoreL.ToString();
        UIPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void Scoring(string wallID)
    {
        if (wallID == "Side Wall L") 
        {
            PlayerScoreR = PlayerScoreR + 10;
            UIPlayerScoreR.text = PlayerScoreR.ToString();
        }
        else 
        {
            PlayerScoreL = PlayerScoreL + 10;
            UIPlayerScoreL.text = PlayerScoreL.ToString();
        }
        
    }


}
