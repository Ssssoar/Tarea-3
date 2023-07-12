using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangeSort : MonoBehaviour{
    public SortingGroup sortComp;
    public void change(int target){
        sortComp.sortingOrder = target;
    }
}