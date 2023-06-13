using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIndexer : MonoBehaviour{
    //The format of a single Character
    [System.Serializable]
    public struct Character{
        public string Name;
        public RuntimeAnimatorController Controller;
        public Character(string name, RuntimeAnimatorController controller){
            this.Name = name;
            this.Controller = controller;
        }
    }
    //An array of all the characters that will be in the game
    public Character[] chars;
}
