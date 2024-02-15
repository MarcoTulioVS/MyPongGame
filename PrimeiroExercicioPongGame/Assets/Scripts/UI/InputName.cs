using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InputName : MonoBehaviour
{
    public TMP_InputField inputField;

    [SerializeField]
    private bool isPlayer;
    void Start()
    {
        inputField.onValueChanged.AddListener(SetName);
    }

    private void SetName(string name)
    {
        if (isPlayer)
        {
            SaveInformation.instance.playerName = name;
        }
        else
        {
            SaveInformation.instance.enemyName = name;
        }
    }
}
