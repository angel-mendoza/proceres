using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text theText;

    public TextAsset textFile;
    public string[] textLine;

    public int currentLine;
    public int endAtLine;

    public PlayerController player;

    // Use this for initialization
    void Start()
    {

        player = FindObjectOfType<PlayerController>();

        if (textFile != null)
        {
            textLine = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLine.Length - 1;
        }
    }

    void Update()
    {
        theText.text = textLine[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }

        if (currentLine > endAtLine)
        {
            textBox.SetActive(false);
        }
    }
}
