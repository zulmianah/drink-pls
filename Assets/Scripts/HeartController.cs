using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    [SerializeField]
    public GameObject[] hearts;
    private static int life = 2;
    public static bool trash = false;
    // Start is called before the first frame update
    void Start()
    {
        life = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (trash)
        {
            Trash();
        }

    }
    void Trash()
    {
        GameObject heart = (GameObject) hearts.GetValue(life);
        heart.SetActive(false);
        life--;
        if (life == 0)
            GameOver();
    }

    private void GameOver()
    {
        print("Game Over");
    }
}
