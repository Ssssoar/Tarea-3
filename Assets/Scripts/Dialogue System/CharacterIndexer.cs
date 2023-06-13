using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIndexer : MonoBehaviour
{
    [System.Serializable]
    public struct Character{
        public int A;
        public int B;
        public Character(int a, int b){
            this.A = a;
            this.B = b;
        }
    }
    
    public Character char1;
    public Vector2 vector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
