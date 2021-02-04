using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string inputsound;
    bool playerismoving;
    public float walkingspeed;
}