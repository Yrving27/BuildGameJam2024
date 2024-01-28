using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaitState : IState
{
    EnemyStateMachine enemy;
    Transform bait;
    float waitTimer;
    float waitTime = 5;
    public EnemyBaitState(EnemyStateMachine enemy, Transform bait)
    {
        this.enemy = enemy;
        this.bait = bait;
    }
    public void Enter()
    {
        enemy.agent.SetDestination(bait.position);
    }

    public void Update()
    {
        if(Vector3.Distance(enemy.transform.position, bait.position) < 0.5f)
        {
            waitTimer += Time.deltaTime;
            if(waitTimer > waitTime)
            {
                enemy.SetState(new EnemyPatrollState(enemy));
            }
        }
    }

    public void Exit()
    {
        Debug.Log("Saindo do bait");
    }
}
