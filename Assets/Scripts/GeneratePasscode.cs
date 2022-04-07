using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GeneratePasscode : MonoBehaviour
{
    public GameObject tilePrefab;
    public static List<GameObject> PasscodeList;
    public GameObject tileParent;
    public static bool passcodeGenerated;
    public Sprite[] pins;
    public static bool regeneratePasscode;

    void Start()
    {
        PasscodeList = new List<GameObject>();
        regeneratePasscode = false;
        generateTiles();
    }
    private void Update()
    {
        if(regeneratePasscode)
        {
            regeneratePasscode = false;
            for (int i = 0; i < 5; i++)
                Destroy(PasscodeList[i].gameObject);
                PasscodeList.Clear();
            generateTiles();
        }
    }
    private void generateTiles()
    {
        for (int i = 1; i <= 5; i++)
        {
          GameObject newTile = Instantiate(tilePrefab, new Vector3(0, 0, 0), Quaternion.identity);
                newTile.gameObject.transform.SetParent(tileParent.gameObject.transform);
                newTile.GetComponent<Button>().interactable = false;
            newTile.gameObject.tag = "Passcode";
                int rand = Random.Range(0, PlayerSkill.pinCount);
                newTile.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = pins[rand];
                Color color = newTile.transform.GetChild(0).gameObject.GetComponent<Image>().color;
                newTile.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 255);
                PasscodeList.Add(newTile);
 
        }
        passcodeGenerated = true;
    }
}
