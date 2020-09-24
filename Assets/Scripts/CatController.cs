using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatController : MonoBehaviour
{
    public UnityEngine.UI.Text serveText;
    int serveMeNumber;
    string[] colors = new string[] { "White", "Red", "Yellow", "Blue", "Black" };
    int max;
    // Start is called before the first frame update
    void Start()
    {
        max = colors.Length;
        int rnd = Random.Range(0, max);
        gameObject.tag = colors[rnd];
        string serve = gameObject.tag;
        switch (serve)
        {
            case "White":
                serveMeNumber = 1;
                break;
            case "Red":
                serveMeNumber = 2;
                break;
            case "Yellow":
                serveMeNumber = 3;
                break;
            case "Blue":
                serveMeNumber = 4;
                break;
            case "Black":
                serveMeNumber = 5;
                break;
        }
        serveText.text = serveMeNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 