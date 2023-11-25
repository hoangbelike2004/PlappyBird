using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontronller : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    bool gameover;
    UImanager Ui;
    public AudioClip auc;
    public AudioSource aus;
    public AudioSource aus2;
    public AudioClip auc2;
    public AudioSource aus3;
    public AudioClip auc3;
    bool sp,instruct;
    private void Start()
    {
        Time.timeScale = 1;
        Ui = FindObjectOfType<UImanager>();
        Ui.AddScore("" + score);
    }
    private void Update()
    {
        if (gameover)
        {
            Ui.ShowisGameover(true);
            
        }
        if (sp)
        {
            Ui.Spanpipe(true);
        }
        if(instruct)
        {
            Ui.Message(false);
        }
    }
    public void Sound()
    {
        if (aus)
        {
            aus.PlayOneShot(auc);
        }
    }
    public void Sound2()
    {
        if (aus2)
        {
            aus2.PlayOneShot(auc2);
        }
    }
    public void Sound3()
    {
        if (aus3)
        {
            aus2.PlayOneShot(auc3);
        }
    }
    public void ReLoadScene()
    {
        SceneManager.LoadScene(0);
    }
    public void SetScore(int value)
    {
        score = value;
    }
    public int GetScore()
    {
        return score;
    }
    public void ShowScore()
    {
        score++;
        Ui.AddScore(""+score);
    }
    public void GameOver(bool isGameover)
    {
        gameover= isGameover;
    }
    public void Span(bool isSpan)
    {
        sp = isSpan;
    }
    public void ShowInstruct(bool isInstruct)
    {
        instruct = isInstruct;
    }
}
