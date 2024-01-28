using UnityEngine;
using UnityEngine.AI;

public class EnemyStateMachine : MonoBehaviour
{
    public IState state;
    public NavMeshAgent agent;
    public Transform[] points;
    public int currentPoint;
    public PlayerMovement player;
    public float stunDuration = 2;
    public GameObject footstep;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        SetState(new EnemyPatrollState(this));
        InvokeRepeating("Footsteps", 1, 1);
    }

    void Update()
    {
        state?.Update();
    }

    public void SetState(IState state)
    {
        this.state?.Exit();
        this.state = state;
        this.state?.Enter();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerLight"))
        {
            SetState(new EnemyFollowState(this));
        }
        else if (other.gameObject.CompareTag("UVLight"))
        {
            SetState(new EnemyStunState(this));
        }
    }

    void Footsteps()
    {
        Destroy(Instantiate(footstep, transform.position, Quaternion.identity), 2);
    }
}
