using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour
{
    public float pushForce = 6f;
    [SerializeField] KeyCode pushKey = KeyCode.LeftShift;
    [SerializeField] float baitCooldown = 5;
    private float baitTimer;
    [SerializeField] GameObject bait;
    private PlayerSounds playerSounds;
    [SerializeField] AudioClip baitSound;

    private void Start()
    {
        playerSounds = GetComponent<PlayerSounds>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Time.time > baitTimer)
        {
            playerSounds.PlayAudio(baitSound);
            Destroy(Instantiate(bait, transform.position, Quaternion.identity), 10);
            baitTimer = Time.time + baitCooldown;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            string NomeScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(NomeScene);
        }
        else if (collision.gameObject.CompareTag("Box"))
        {
            
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box") && Input.GetKey(pushKey))
        {
            GameObject collidedObj = collision.gameObject;
            Rigidbody otherRb = collidedObj.GetComponent<Rigidbody>();
            // Calcula a direção do empurrão
            Vector3 pushDirection = GetPushDirection(collidedObj.transform.position);
            Vector3 newPosition = collidedObj.transform.position + pushDirection;
            otherRb.MovePosition(newPosition);
            //otherRb.velocity = pushDirection * pushForce;
            AudioSource objSource = collision.gameObject.GetComponent<AudioSource>();
            if (!objSource.isPlaying)
            {
                objSource.Play();
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Rigidbody otherRb = other.GetComponent<Rigidbody>();
            otherRb.velocity = Vector3.zero;
            other.gameObject.GetComponent<AudioSource>().Stop();
        }
    }

    // Calcula a direção do empurrão baseada na posição do objeto alvo
    Vector3 GetPushDirection(Vector3 targetPosition)
    {
        // Calcula a direção do empurrão
        Vector3 pushDirection = targetPosition - transform.position;

        // Normaliza a direção para manter uma força constante
        pushDirection.Normalize();

        // Limita a direção do empurrão a quatro direções (cima, baixo, esquerda, direita)
        float x = Mathf.Abs(pushDirection.x);
        float z = Mathf.Abs(pushDirection.z);

        if (x > z)
        {
            pushDirection.z = 0f; // Limita a direção vertical
        }
        else
        {
            pushDirection.x = 0f; // Limita a direção horizontal
        }

        return pushDirection * 0.2f;
    }

    public void Test()
    {
        Debug.Log("aaaaaaa");
    }
}
