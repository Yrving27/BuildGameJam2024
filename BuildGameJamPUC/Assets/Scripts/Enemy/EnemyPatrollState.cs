using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrollState : IState
{
    private EnemyStateMachine enemy;
    public EnemyPatrollState(EnemyStateMachine enemy)
    {
        this.enemy = enemy;
    }
    void IState.Enter()
    {
        enemy.agent.SetDestination(enemy.points[enemy.currentPoint].position);
    }

    void IState.Update()
    {
        if (Vector3.Distance(enemy.transform.position, enemy.points[enemy.currentPoint].position) < 0.5)
        {
            enemy.currentPoint = (enemy.currentPoint + 1) % enemy.points.Length;
            enemy.agent.SetDestination(enemy.points[enemy.currentPoint].position);
        }
    }

    void IState.Exit()
    {
        throw new System.NotImplementedException();
    }
}
