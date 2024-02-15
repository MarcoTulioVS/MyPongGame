using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleShine : MonoBehaviour
{
    [SerializeField]
    private float waitTime;

    [SerializeField]
    private float endTime;

    [SerializeField]
    private Animator anim;
    void Start()
    {
        StartCoroutine("Shine");
    }

    IEnumerator Shine()
    {
        yield return new WaitForSeconds(waitTime);
        anim.SetBool("start", true);
        yield return new WaitForSeconds(endTime);
        anim.SetBool("start", false);
        StartCoroutine("Shine");
    }
}
