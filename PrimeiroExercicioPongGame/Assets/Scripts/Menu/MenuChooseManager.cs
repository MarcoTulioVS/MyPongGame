using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuChooseManager : MonoBehaviour
{
    [SerializeField]
    private Text uiWinner;
    void Start()
    {
        SaveInformation.instance.ResetInfo();

        string lastWinner = SaveInformation.instance.GetLastWinner();

        if (lastWinner != null)
        {
            uiWinner.text = "Ultimo vencedor e: " + lastWinner;
        }
        else
        {
            uiWinner.text = "";
        }
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
