using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class AlternativMove : MonoBehaviour
{
    public GameObject gameObject;
    public Joystick joystick;
    private Rigidbody rb;

    private float speed = 1.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        // Определяем направление движения относительно камеры
        Vector3 forwardMovement = Camera.main.transform.forward * moveVertical;
        Vector3 rightMovement = Camera.main.transform.right * moveHorizontal;

        // Нормализуем векторы движения
        Vector3 movement = (forwardMovement + rightMovement).normalized * speed;

        // Применяем движение к Rigidbody, перемещая персонажа
        rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
    }
}
