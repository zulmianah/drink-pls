using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    public UnityEngine.Experimental.Rendering.Universal.Light2D[]lights;
    int max;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayLight());
        max = lights.Length-1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator PlayLight()
    {
        int rnd = Random.Range(0, max);
        lights[rnd].intensity = 0f;
        yield return new WaitForSeconds(0.1f);
        lights[rnd].intensity = 1.23f;
        yield return new WaitForSeconds(1.2f);
        StartCoroutine(PlayLight());
    }
}
