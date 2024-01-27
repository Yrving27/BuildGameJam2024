using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public float pushForce = 6f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Rigidbody otherRb = other.GetComponent<Rigidbody>();
            // Calcula a direção do empurrão
            Vector3 pushDirection = GetPushDirection(other.transform.position);

            otherRb.velocity = pushDirection * pushForce;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Rigidbody otherRb = other.GetComponent<Rigidbody>();
            otherRb.velocity = Vector3.zero;
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

        pushDirection.y = 0;

        return pushDirection;
    }
}
