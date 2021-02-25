using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBoss : StateMachineBehaviour
{
    public GameObject laser;
    private float time = 16f;
    private Transform transformLaser;
    private float timeLaser = 0;
    private bool fire;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        fire = true;
        GameObject originalGameObject = GameObject.Find("Boss");
        GameObject obj = originalGameObject.transform.GetChild(0).gameObject;
        transformLaser = obj.transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if(timeLaser >= 0.3f && fire){
            Instantiate(laser, transformLaser.position, transformLaser.rotation);
            timeLaser = 0f;
        }
        timeLaser += Time.deltaTime;

        time -= Time.deltaTime;
        if (time <= 0f)
        {
            animator.SetInteger("transition", 1);
            time = 16f;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        fire = false;
    }
}