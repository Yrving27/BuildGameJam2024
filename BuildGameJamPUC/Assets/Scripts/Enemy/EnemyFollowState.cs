using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowState : IState
{
    private EnemyStateMachine enemy;
    public EnemyFollowState(EnemyStateMachine enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        
    }

    public void Update()
    {
        if (Vector3.Distance(enemy.transform.position, enemy.player.transform.position) < 0.5)
        {
            enemy.agent.SetDestination(enemy.player.transform.position);
        }
    }

    public void Exit()
    {
        throw new System.NotImplementedException();
    }
}
