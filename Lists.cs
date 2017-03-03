using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lists : MonoBehaviour {

    public List<string> myWeaponList;
    public string[] myWeaponArray;

    void Start(){
        myWeaponList.Add("Gun");
        myWeaponList.Remove("Club");
        myWeaponList.Add("Bow");
        myWeaponList.RemoveAt(1);
    }

}
