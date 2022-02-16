using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/LevelManager", order = 1)]
public class LevelManager : ScriptableObject
{
    public int num_keys;

    private int keys_found = 0;

    private void OnEnable()
    {
        keys_found = 0;  
    }

    public void keyFound()
    {
        keys_found++;
    }

    public void resetKeys()
    {
        keys_found = 0;
    }

    public int getKeysFound()
    {
        return keys_found;
    }
}
