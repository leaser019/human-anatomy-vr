using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggle : MonoBehaviour
{
    public GameObject gameObject;
    public bool isActive = true;
    // Start is called before the first frame update
    public void ToggleMesh()
    {
        if (isActive)
        {
            gameObject.SetActive(false);
            isActive = false;
        }
        else
        {
            gameObject.SetActive(true);
            isActive = true;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
