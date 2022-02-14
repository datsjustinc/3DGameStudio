using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    public Color original;
    public Color original2;
    public Renderer cube;
    public Renderer slot;

    void Start()
    {
       cube = GetComponent<Renderer>();
       original = cube.material.color;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Slot")
        {
            slot = other.GetComponent<Renderer>();

            if (cube.material.color == slot.material.color)
            {
                
                cube.material.color = Color.green;
                original2 = slot.material.color;
                slot.material.color = Color.green;

                GameManager.Instance.AddPoints(1);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Slot")
        {
            if (cube.material.color == slot.material.color)
            {
                cube.material.color = original;
                slot.material.color = original2;

                GameManager.Instance.AddPoints(-1);
            }
        }
    }
}