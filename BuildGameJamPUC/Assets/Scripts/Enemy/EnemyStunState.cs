using UnityEngine;

public class EnemyStunState : IState
{
    private EnemyStateMachine enemy;
    private float stunTime;

    public EnemyStunState(EnemyStateMachine enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        enemy.agent.ResetPath();
        stunTime = Time.time;
        Debug.Log("Stunned");
    }

    public void Update()
    {
        if(Time.time >= stunTime + enemy.stunDuration)
        {
            enemy.SetState(new EnemyPatrollState(enemy));
        }
    }

    public void Exit()
    {
        
    }
}
