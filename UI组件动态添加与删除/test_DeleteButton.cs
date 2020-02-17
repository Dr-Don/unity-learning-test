using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test_DeleteButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void delete()
    {
        gameObject.GetComponent<LayoutElement>().ignoreLayout = true;
        Destroy(gameObject);
    }
}
