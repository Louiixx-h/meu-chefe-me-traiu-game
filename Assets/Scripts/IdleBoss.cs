using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBoss : StateMachineBehaviour
{
    private ParticleSystem fire;
    private float time = 16f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Entrou");
        GameObject originalGameObject = GameObject.Find("Boss");
        GameObject obj = originalGameObject.transform.GetChild(0).gameObject;
        fire = obj.GetComponent<ParticleSystem>();
        fire.Play();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        time -= Time.deltaTime;
        if (time <= 0f)
        {
            Debug.Log("Damage");
            animator.SetInteger("transition", 1);
            time = 16f;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        fire.Stop();
        Debug.Log("Saiu");
    }
}
