using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Images : MonoBehaviour
{
    Image myImageComponent;
    public Sprite myFirstImage;
    public Sprite mySecondImage;
    public Sprite myThirdImage;

    public int BuildingLevel;


    public Images(int buildingLevel)
    {
        BuildingLevel = buildingLevel;
    }
    void Start()
    {
        myImageComponent = GetComponent<Image>();
    }

    void Update()
    {
        if(BuildingLevel < 3)
        {
            SetImage(myFirstImage);
        }
        else if(BuildingLevel >= 3 && BuildingLevel < 7)
        {
            SetImage(mySecondImage);
        }
        else if(BuildingLevel >= 7 && BuildingLevel <= 10)
        {
            SetImage(myThirdImage);
        }
    }

    void SetImage(Sprite s)
    {
        myImageComponent.sprite = s;
    }
}

