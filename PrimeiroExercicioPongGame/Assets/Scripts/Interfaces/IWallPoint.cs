using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWallPoint
{
    public int point { get; set; }
    void CheckWin(GameManager gameManager);
}
