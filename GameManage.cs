using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManage : MonoBehaviour
{
    public GameObject ball;
    public GameObject player1Paddle;
    public GameObject player1Goal;
    public GameObject player2Paddle;
    public GameObject player2Goal;
    public GameObject player1Text;
    public GameObject player2Text;
    public AudioSource scoreSound;

    private int play1Score;
    private int play2Score;

    public void player1Score()
    {
        play1Score++;
        Debug.Log(play1Score);
        player1Text.GetComponent<TextMeshProUGUI>().text = play1Score.ToString();
        ResetPosition();
        scoreSound.Play();
    }

    public void player2Score()
    {
        play2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = play2Score.ToString();
        ResetPosition();
        scoreSound.Play();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}


