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
    public GameObject part1;
    public Renderer render1;
    public GameObject part2;
    public Renderer render2;
    public GameObject part3;
    public Renderer render3;
    public GameObject part4;
    public Renderer render4;
    public GameObject part5;
    public Renderer render5;
    public GameObject part6;
    public Renderer render6;
    public GameObject part7;
    public Renderer render7;
    public GameObject part8;
    public Renderer render8;


    void Start()
    {
        render1 = part1.GetComponent<MeshRenderer>();
        render2 = part2.GetComponent<MeshRenderer>();
        render3 = part3.GetComponent<MeshRenderer>();
        render4 = part4.GetComponent<MeshRenderer>();
        render5 = part5.GetComponent<MeshRenderer>();
        render6 = part6.GetComponent<MeshRenderer>();
        render7 = part7.GetComponent<MeshRenderer>();
        render8 = part8.GetComponent<MeshRenderer>();
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
            render1.enabled = true;
            render2.enabled = true;
            render3.enabled = true;
            render4.enabled = true;
            render5.enabled = true;
            render6.enabled = true;
            render7.enabled = true;
            render8.enabled = true;
        }
    }
}