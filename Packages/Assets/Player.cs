using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public float speed = 10.0F; //Velocidad de movimiento
    public float rotationSpeed = 200.0F; //Velocidad de rotaci�n

    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);

    }
}