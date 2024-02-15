using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColorController : MonoBehaviour
{
    [SerializeField]
    private Image imagePaddle;

    [SerializeField]
    private Button button;

    [SerializeField]
    private bool isPlayer;

    public void ChangeColor()
    {
        imagePaddle.color = button.colors.normalColor;

        if (isPlayer)
        {
            SaveInformation.instance.colorPlayer = imagePaddle.color;
        }
        else
        {
            SaveInformation.instance.colorEnemy = imagePaddle.color;
        }
    }
}
