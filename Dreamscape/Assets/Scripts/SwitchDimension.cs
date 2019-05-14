using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDimension : MonoBehaviour
{

    [SerializeField]
    private GameObject notsonight;

    [SerializeField]
    private GameObject nightnight;
    private bool isNight;

    // Start is called before the first frame update
    void Start()
    {
        //nightnight = GameObject.Find("Nightmare Realm");
        isNight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Primary Ability"))
        {
            isNight = !isNight;
            nightnight.SetActive(isNight);
            notsonight.SetActive(!isNight);
        }
    }


}
