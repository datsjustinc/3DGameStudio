using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;

            GameManager.Instance.OnArchEntered(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {

    }
}