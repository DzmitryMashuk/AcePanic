using UnityEngine.UI;
using UnityEngine;

public class Points : MonoBehaviour
{
    public static int points;
    public Text pointsText;

    void Start()
    {
        points = 0;
    }

    void Update()
    {
        pointsText.text = points.ToString();
    }
}
