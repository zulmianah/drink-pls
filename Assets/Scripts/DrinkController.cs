using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkController : MonoBehaviour
{
    public GameObject myPrefab;
    public Sprite newSprite;
    public string drinkType;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        serveDrink();
    }

    void serveDrink()
    {
        Instantiate(myPrefab, new Vector3(-3.40831f, -1.997259f, 0), Quaternion.identity);
        myPrefab.GetComponent<SpriteRenderer>().sprite = newSprite;
        myPrefab.GetComponent<ServeDrinkController>().drinkType = drinkType;
        myPrefab.tag = drinkType;
    }
}
