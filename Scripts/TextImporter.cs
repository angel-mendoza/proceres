using UnityEngine;
using System.Collections;

public class TextImporter : MonoBehaviour {

    public TextAsset textFile;
    public string[] textLine;

	// Use this for initialization
	void Start () {
	 if (textFile != null)
        {
            textLine = (textFile.text.Split('\n'));
        }
	}

}
