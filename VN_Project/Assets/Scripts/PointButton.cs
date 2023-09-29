using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointButton : MonoBehaviour
{
    public int pointsToAdd = 1;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(AddPoints);
        }
    }

    private void AddPoints()
    {
        FindObjectOfType<EndingManager>().AddPoints(pointsToAdd);
    }
}
