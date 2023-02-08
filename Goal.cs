using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlay1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("Ball"))
        {
            if(!isPlay1Goal)
            {
                GameObject.Find("GameManager").GetComponent<GameManage>().player2Score();
            }
            else
            {
                GameObject.Find("GameManager").GetComponent<GameManage>().player1Score();
            }
        }
    }
}
