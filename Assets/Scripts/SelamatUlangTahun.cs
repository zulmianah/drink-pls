using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelamatUlangTahun : MonoBehaviour
{
    public string[] ucapan;
    public GameObject text, button;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        ucapan = new string[]{
            "Dor!",
            "Kakang!",
            "Selamat ulang tahu Kakang!",
            "Milad Mubarak!",
            "Zum geburtstag viel glück bruder!",
            "Kang!",
            "Semoga panjang umur",
            "Murah rejeki",
            "Sayang Bapak, Emak dan Adek yaaaa!",
            "Sehat selalu yaaa!",
            "Semoga cita-cita kakang tercapai!",
            "Kakang kakak paling hebat! <3 <3 <3",
            "Hati-hati ya Kang di luar sana!",
            "Semoga suka selamat ulang tahun.exe nyaaa",
            "Mazotoa zoky!",
            "Bisou",
            "Assalamualaikum!",
            ".",
            "..",
            "...",
            "The End!",
        };
        next();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void next()
    {
        if (i < ucapan.Length)
        {
            text.GetComponent<UnityEngine.UI.Text>().text = ucapan[i];
            i++;
        }
        else
        {
            Application.Quit();
        }
    }
}
