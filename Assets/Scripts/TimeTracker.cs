using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTracker : MonoBehaviour
{
    [SerializeField] int playtime = 0;
    private int seconds = 0;
    private int minutes = 0;

    void Start()
    {
        StartCoroutine("Playtimer");
    }

    private IEnumerator Playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = (playtime % 60);
            minutes = (playtime / 60) % 60;
        }
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 400, 50), "Time = " + minutes.ToString() + " Minutes " + seconds.ToString() + " Seconds ");
    }
}
