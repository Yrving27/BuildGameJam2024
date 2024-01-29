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
        enemy.sounds.PlayAudio(enemy.followSound);
        enemy.anim.SetBool("Following", true);
    }

    public void Update()
    {
        if (Vector3.Distance(enemy.transform.position, enemy.player.transform.position) > 0.5 
            && !MonologueDisplayer.instance.isPaused)
        {
            enemy.agent.SetDestination(enemy.player.transform.position);
        }
        else
        {
            enemy.agent.SetDestination(enemy.transform.position);
        }
    }

    public void Exit()
    {
        enemy.anim.SetBool("Following", false);
    }
}
