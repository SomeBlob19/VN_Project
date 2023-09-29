using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{
    public GameObject[] endingPanels;

    private int accumulatedPoints = 0;

    public void AddPoints(int pointsToAdd)
    {
        accumulatedPoints += pointsToAdd;
        // Print the accumulated points to the console for debugging.
        Debug.Log("Accumulated Points: " + accumulatedPoints);
    }

    public void CheckEndings()
    {
        // Add your logic to check for different endings based on accumulated points.
        // For example:
        if (accumulatedPoints < 25)
        {
            ShowEndingPanel(0); // Show ending panel 0 when less than 5
        }
        else if (accumulatedPoints >= 25 && accumulatedPoints < 35)
        {
            ShowEndingPanel(1); // Show ending panel 1 when 5-10
        }
        else
        {
            ShowEndingPanel(2); // Show real end
        }
    }

    public void ShowEndingPanel(int panelIndex)
    {
        // Disable all ending panels first.
        foreach (var panel in endingPanels)
        {
            panel.SetActive(false);
        }

        // Enable the selected ending panel.
        endingPanels[panelIndex].SetActive(true);
    }
}
