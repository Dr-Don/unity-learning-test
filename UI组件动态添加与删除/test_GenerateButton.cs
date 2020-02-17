using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_GenerateButton : MonoBehaviour
{
    public GameObject btn;

    // Start is called before the first frame update
    void Start()
    {
        //or load the button from a folder
        //btn = (GameObject)Resources.Load<GameObject>("Button1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(btn);
            go.transform.SetParent(transform);
        }
    }
}
