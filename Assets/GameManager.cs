using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text score;
    public Text winText;
    public int totalItems;
    public int itemsCollected; // aca voy a contar cuantos junte

    private void Start()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Item").Length;
        winText.enabled = false;
        UpdateUI();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            itemsCollected++; // le sumo uno
            UpdateUI();

            if (itemsCollected == totalItems)
            {

                Debug.Log("Ganaste");
                winText.enabled = true;
            }
        }
    }

    private void UpdateUI()
    {
        score.text = itemsCollected.ToString() + " / " + totalItems.ToString();
    }

}

