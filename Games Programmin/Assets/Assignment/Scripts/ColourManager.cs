using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourManager : MonoBehaviour
{
    public Material[] AMaterials;
    public Material[] BMaterials;
    public Material[] CMaterials;
    public Material[] DMaterials; // a for map, b for player, c for enemy, d for tertiary stuff
    
    public Material[] ABaseMaterials;
    public Material[] BBaseMaterials;
    public Material[] CBaseMaterials;
    public Material[] DBaseMaterials;

    public float   AHue = 230f; // current Hues
    public float   BHue = 175f;
    public float   CHue = 0f;
    public float   DHue = 125f;

    private Camera Camera;

    private void Start()
    {
        Camera = Camera.main;
        setColour(); // resets the materials at the start of the game
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q)) // temp input
        {
            updateHue(1);
        }
    }

    public void setColour()
    {
        for (int I = 0; I < AMaterials.Length; I++)
        {
            AMaterials[I].color = ABaseMaterials[I].color;
        }
        for (int I = 0; I < BMaterials.Length; I++)
        {
            BMaterials[I].color = BBaseMaterials[I].color;
        }
        for (int I = 0; I < CMaterials.Length; I++)
        {
            CMaterials[I].color = CBaseMaterials[I].color;
        }
        for (int I = 0; I < DMaterials.Length; I++)
        {
            DMaterials[I].color = DBaseMaterials[I].color;
        }
        Camera.backgroundColor = BMaterials[0].color;
    }

    public void updateHue(float amount)
    {
        amount = amount / 360; // amount over 360 because we are using the radial wheel
        
        // Update the hues of the colours by the amount variable
        for (int I = 0; I < AMaterials.Length; I++)
        {
            float H, S, V;
            Color.RGBToHSV(AMaterials[I].color, out H, out S, out V); // gets the h,s and v of the current color
            H += amount;
            AMaterials[I].color = Color.HSVToRGB(H, S, V);
        }
        for (int I = 0; I < BMaterials.Length; I++)
        {
            float H, S, V;
            Color.RGBToHSV(BMaterials[I].color, out H, out S, out V); // gets the h,s and v of the current color
            H += amount;
            BMaterials[I].color = Color.HSVToRGB(H, S, V);
        }
        for (int I = 0; I < CMaterials.Length; I++)
        {
            float H, S, V;
            Color.RGBToHSV(CMaterials[I].color, out H, out S, out V); // gets the h,s and v of the current color
            H += amount;
            CMaterials[I].color = Color.HSVToRGB(H, S, V);
        }
        for (int I = 0; I < DMaterials.Length; I++)
        {
            float H, S, V;
            Color.RGBToHSV(DMaterials[I].color, out H, out S, out V); // gets the h,s and v of the current color
            H += amount;
            DMaterials[I].color = Color.HSVToRGB(H, S, V);
        }
        Camera.backgroundColor = BMaterials[0].color;
    }
}

