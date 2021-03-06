using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour // singleton class, any other class can access it
{
    // This is private, so that we can show an error if its not set up yet
    private static GameManager staticInstance; // using static allows other classes to use it
    //public List <GameObject> Arches;
    //private float CurrentArchIndex = 0;
    public float NumberOfPoints = 0;
    public List <GameObject> Weapon;
    public MeshRenderer grab;


    void Start()
    {
        //render1 = part1.GetComponent<MeshRenderer>();
        //Weapon = new List<GameObject>();
    }

    public static GameManager Instance // set as instance so all other objects in game world can access it
    {
        get
        {
            // If the static instance isn't set yet, throw an error
            if (staticInstance is null)
            {
                Debug.LogError("Game Manager is NULL");
            }

            return staticInstance;
        }
    }

    private void Awake()
    {
        // Set the static instance to this instance
        staticInstance = this;
    }

    public void AddPoints(float PointsToAdd)
    {
        NumberOfPoints += PointsToAdd; 
        Debug.Log("Add Points " + NumberOfPoints);
    }

    public void OnArchEntered(GameObject archObject)
    {
        //Debug.Log(Arches.Count);
    }

    void Update()
    {
        if (NumberOfPoints == 4)
        {
            Debug.Log("Achieved.");
            for (int i = 0; i < Weapon.Count; i++)
            {
                Debug.Log(Weapon.Count);
                grab = Weapon[i].GetComponent<MeshRenderer>();
                grab.enabled = true;
                //Debug.Log(grab.enabled);
                //Debug.Log("Enabling Weapon Renderer");
            }
        }

        else
        {
            for (int i = 0; i < Weapon.Count; i ++)
            {
                grab = Weapon[i].GetComponent<MeshRenderer>();
                grab.enabled = false;
                //Debug.Log("Disabling Weapon Renderer");
            }
        }
    }
}