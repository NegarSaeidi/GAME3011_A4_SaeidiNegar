using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void OnStart()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnReturn()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
