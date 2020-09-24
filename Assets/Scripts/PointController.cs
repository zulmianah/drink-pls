using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    public UnityEngine.UI.Text score;
    public static bool getPoint=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (getPoint)
            addPoint();
        getPoint = false;
    }

    public void addPoint()
    {
        score.text = (int.Parse(score.text) + 1).ToString();
    }
}
