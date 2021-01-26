using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSetter : MonoBehaviour
{
    public string floorName;
    
    void Start()
    {
        SceneWatcher.sceneName = floorName;
    }

}
