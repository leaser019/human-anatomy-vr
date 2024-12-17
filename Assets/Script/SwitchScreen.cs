using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void switchSeneces(string sceneName)

    {//change senece with the stage of VR
        
        SceneManager.LoadScene(sceneName);
    }
}
