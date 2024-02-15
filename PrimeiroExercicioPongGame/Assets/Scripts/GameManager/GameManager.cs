using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    #region VARIABLES

    [Header("References")]
    [SerializeField]
    private Transform playerPaddle;

    [SerializeField]
    private Transform enemyPaddle;

    [SerializeField]
    private BallController ballController;

    public int winPoints;

    [SerializeField]
    private List<Sprite> faces = new List<Sprite>();

    public GameObject endGameScreen;

    public GameObject wallPlayer;
    public GameObject wallEnemy;

    public Text gameOverText;
    #endregion

    #region METHODS
    void Start()
    {
        ResetGame();
    }

    public void SetPaddlePosition()
    {
        playerPaddle.position = new Vector3(-9.47f, 0,0);
        enemyPaddle.position = new Vector3(9.47f, 0,0);
    }

    public void ResetGame()
    {
        SetPaddlePosition();
        ballController.ResetBall();
        endGameScreen.SetActive(false);

    }

    public void AddPoint(IWallPoint paddle)
    {
        paddle.point++;
        paddle.CheckWin(this);
    }

    public void RandomizeFace(SpriteRenderer spriteRenderer)
    {
        int randomValue = Random.Range(0,faces.Count - 1);
        spriteRenderer.sprite = faces[randomValue];
    }

    public void GameOver()
    {
        endGameScreen.SetActive(true);
        bool result = wallPlayer.GetComponent<IWallPoint>().point > wallEnemy.GetComponent<IWallPoint>().point;
        string winner = SaveInformation.instance.GetName(result);
        gameOverText.text += winner;  
        SaveInformation.instance.SaveLastWinner(winner);
        Invoke("LoadMenu", 2);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    #endregion

}
