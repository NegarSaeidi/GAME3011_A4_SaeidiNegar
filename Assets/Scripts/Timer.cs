using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public GameObject timerText;
    public static float time;
    public GameObject gameOverPanel;
    private void Start()
    {
        time = 500;
    }
    void Update()
    {
        if (time > 1)
        {
            time -= Time.deltaTime;
        }
        else
            gameOverPanel.SetActive(true);
        timerText.GetComponent<TextMeshProUGUI>().text = Mathf.FloorToInt(time / 60) + " : " + Mathf.FloorToInt(time % 60);
    }
}