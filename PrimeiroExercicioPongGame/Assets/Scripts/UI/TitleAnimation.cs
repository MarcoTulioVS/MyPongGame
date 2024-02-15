using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAnimation : MonoBehaviour
{
    [SerializeField]
    private float waitTime;

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private float endTime;
    void Start()
    {
        StartCoroutine("MoveText");
    }

    IEnumerator MoveText()
    {
        yield return new WaitForSeconds(waitTime);
        anim.SetBool("start", true);
        yield return new WaitForSeconds(endTime);
        anim.SetBool("start", false);
        StartCoroutine("MoveText");
    }
}
