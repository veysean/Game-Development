using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Whale : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level1 Complete");
        }
    }

    void Update()
    {
        float moveX = (GameManager.Instance.worldSpeed * PlayerController.Instance.boost)*Time.deltaTime;
        transform.position += new Vector3(-moveX, 0);
        if(transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }

}