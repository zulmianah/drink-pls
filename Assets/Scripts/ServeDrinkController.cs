using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeDrinkController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool white = false;
    public String drinkType;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HeartController.trash)
            Trash();
        if (white)
            rb.velocity = Vector2.zero;
        else
            rb.velocity = new Vector2(5, rb.velocity.y);
    }

    private void Trash()
    {
        gameObject.SetActive(false);
        HeartController.trash = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag(drinkType))
        {
            white = true;
            StartCoroutine(WaitFor());
        }
        if (collision.gameObject.CompareTag("Trash"))
        {
            HeartController.trash = true;
        }
    }
    IEnumerator WaitFor()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        PointController.getPoint = true;
    }
}
