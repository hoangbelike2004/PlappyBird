using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI textscore;
    public GameObject Showgame;
    public GameObject Span;
    public GameObject Mes;
    public void Message(bool show)
    {
        if (Mes)
        {
            Mes.SetActive(show);
        }
    }
    public void Spanpipe(bool show)
    {
        if (Span)
        {
            Span.SetActive(show);
        }
    }
    public void AddScore(string Score)
    {
        if (textscore)
        {
            textscore.text = Score;
        }
    }
    public void ShowisGameover(bool show)
    {
        if (Showgame)
        {
            Showgame.SetActive(show);
            Time.timeScale = 0;
        }
    }
}
