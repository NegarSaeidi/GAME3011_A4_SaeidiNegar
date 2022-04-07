using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat : MonoBehaviour
{
    public GameObject cover;

    public void onCheatClick()
    {
        cover.gameObject.SetActive(false);
        StartCoroutine(causeDelay());
    }

    IEnumerator causeDelay()
    {
        yield return new WaitForSeconds(1.0f);
        cover.gameObject.SetActive(true);
    }
}
