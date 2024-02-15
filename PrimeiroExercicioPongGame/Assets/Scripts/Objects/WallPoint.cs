using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WallPoint : MonoBehaviour,IWallPoint
{
    #region VARIABLES
    public int point { get ; set ; }

    [SerializeField]
    private TextMeshProUGUI pointText;

    [SerializeField]
    private int pontos;

    #endregion

    #region METHODS
    public void Score()
    {
        pointText.text = point.ToString();
    }

    private void Update()
    {
        pontos = point;
        Score();
        
    }

    public void CheckWin(GameManager gameManager)
    {
        if (point >= gameManager.winPoints)
        {
            //gameManager.ResetGame();
            gameManager.GameOver();
            point = 0;
        }
    }

    #endregion
}
