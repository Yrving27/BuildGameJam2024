using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtém os inputs de movimento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcula a direção de movimento
        Vector3 direction = new(horizontal, 0f, vertical);
        Movement(direction);
        Rotation(direction);
    }

    private void Movement(Vector3 direction)
    {
        // Normaliza a direção para manter uma velocidade constante ao mover diagonalmente
        direction.Normalize();

        Vector3 targetPosition = transform.position + direction * speed * Time.deltaTime;

        // Atualiza a posição usando o Rigidbody
        rb.MovePosition(targetPosition);
    }

    private void Rotation(Vector3 direction)
    {
        // Verifica se há uma direção de movimento significativa
        if (direction.magnitude >= 0.1f)
        {
            // Calcula a rotação desejada
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);

            // Interpola suavemente entre a rotação atual e a desejada
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
