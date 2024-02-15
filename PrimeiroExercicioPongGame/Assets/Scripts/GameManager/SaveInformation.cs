using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SaveInformation : MonoBehaviour
{
    public Color colorPlayer = Color.white;
    public Color colorEnemy = Color.white;

    public static SaveInformation instance;

    public string playerName;
    public string enemyName;

    private string saveWinnerKey = "SavedWinner";
    private void Awake()
    {
        

        if (instance!=null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
        
    }

    public void ResetInfo()
    {
        colorPlayer = Color.white;
        colorEnemy = Color.white;

        playerName = "";
        enemyName = "";
    }

    public string GetLastWinner()
    {
        return PlayerPrefs.GetString(saveWinnerKey);
    }

    public void SaveLastWinner(string winner)
    {
        PlayerPrefs.SetString(saveWinnerKey,winner);
    }

    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public string GetName(bool isPlayer)
    {
        return isPlayer ? playerName : enemyName;
    }
}
