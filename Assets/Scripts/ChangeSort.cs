using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangeSort : MonoBehaviour{
    public void change(int target){
        SortingGroup sortComp = GameObject.FindWithTag("Player").GetComponent<SortingGroup>();
        sortComp.sortingOrder = target;
    }
}