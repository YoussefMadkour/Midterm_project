using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityToggle : MonoBehaviour
{
    public GameObject objectToHide;
    public GameObject objectToShow;
    public Transform player; // Assign the player's Transform in the Inspector
    public float toggleDistance = 5.0f; // The distance at which the objects toggle visibility

    private void Start()
    {
        // Ensure the objectToShow is initially disabled if needed
        if (objectToShow != null)
            objectToShow.SetActive(false);
    }

    private void Update()
    {
        // Check the distance between the player and this GameObject every frame
        if (Vector3.Distance(player.position, transform.position) <= toggleDistance)
        {
            // Player is within the toggle distance
            if (objectToHide != null)
                objectToHide.SetActive(false);
            if (objectToShow != null)
                objectToShow.SetActive(true);
        }
        else
        {
            // Player is outside the toggle distance
            if (objectToHide != null)
                objectToHide.SetActive(true);
            if (objectToShow != null)
                objectToShow.SetActive(false);
        }
    }
}


