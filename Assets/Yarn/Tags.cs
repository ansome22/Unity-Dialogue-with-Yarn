using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Tags : MonoBehaviour
{
    [SerializeField] DialogueRunner runner;
    Animator anim;

    private void Awake()
    {
        runner.AddCommandHandler("shake", Doshake);
        anim = runner.GetComponentInChildren<Animator>();
    }

    public void Doshake()
    {
        LineView lineview = runner.GetComponent<LineView>();
        anim.Play("Shake");

    }

}
