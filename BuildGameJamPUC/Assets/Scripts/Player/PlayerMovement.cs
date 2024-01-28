using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private PlayerSounds playerSounds;
    private Rigidbody rb;
    [SerializeField] AudioClip stepSound;
    [Header("Rotation")]
    [SerializeField]
    private float rotationSpeed;
    private RaycastHit hit;
    private Ray ray;
    public LayerMask mask;
    private Vector3 currentLookTarget = Vector3.zero;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        playerSounds = GetComponent<PlayerSounds>();
    }

    void Update()
    {
        if (MonologueDisplayer.instance != null)
        {
            if (!MonologueDisplayer.instance.isPaused)
            {
                Movement();
                Rotation();
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
        }
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new(horizontal, 0f, vertical);

        rb.velocity = direction * speed;

        Vector3 worldDirection = transform.InverseTransformDirection(direction);
        //Vector3 worldDirection = transform.TransformDirection(direction);
        anim.SetFloat("Horizontal", worldDirection.z);
        anim.SetFloat("Vertical", worldDirection.x);
        if (!playerSounds.playing && rb.velocity != Vector3.zero)
        {
            playerSounds.PlayAudio(stepSound);
        }
    }

    void Rotation()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * float.MaxValue, Color.red);

        if (Physics.Raycast(ray, out hit, float.MaxValue, mask, QueryTriggerInteraction.Ignore))
        {
            if (hit.point != currentLookTarget)
            {
                currentLookTarget = hit.point;
                Vector3 position = new Vector3(hit.point.x, transform.position.y, hit.point.z);

                Quaternion rot = Quaternion.LookRotation(position - transform.position);
                transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * rotationSpeed);
            }
        }
    }
}
