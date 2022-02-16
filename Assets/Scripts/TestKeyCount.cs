using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestKeyCount : MonoBehaviour
{
    public LevelManager lvl_mngr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = lvl_mngr.getKeysFound().ToString();
    }
}
