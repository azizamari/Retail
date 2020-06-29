using GoogleARCore.Examples.ObjectManipulation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject[] objects;
    public PawnManipulator manipulator;

    public void SetTo1()
    {
        manipulator.PawnPrefab = objects[0];
    }
    public void SetTo2()
    {
        manipulator.PawnPrefab = objects[1];
    }
    public void SetTo3()
    {
        manipulator.PawnPrefab = objects[2];
    }
    public void SetTo4()
    {
        manipulator.PawnPrefab = objects[3];
    }
    public void SetTo5()
    {
        manipulator.PawnPrefab = objects[4];
    }
}
