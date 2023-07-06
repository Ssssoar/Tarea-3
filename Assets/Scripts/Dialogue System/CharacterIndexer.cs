using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIndexer : MonoBehaviour{
    //The format of a single Character
    [System.Serializable]
    public struct Character{
        public string Name;
        public RuntimeAnimatorController Controller;
        public Sprite Bg;
        public Character(string name, RuntimeAnimatorController controller, Sprite bg){
            this.Name = name;
            this.Controller = controller;
            this.Bg = bg;
        }
    }
    //An array of all the characters that will be in the game
    public Character[] chars;
}
