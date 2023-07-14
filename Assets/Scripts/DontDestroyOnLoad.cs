using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour{
    public string thisName;
    public string otherName;
    public AudioSource audioSource;
    private bool preLoaded = false;
    public void Awake(){
        DontDestroyOnLoad(this.gameObject);
        if (preLoaded){
            GameObject[] clones = GameObject.FindGameObjectsWithTag(thisName);
            GameObject other = GameObject.Find(otherName);
            for (int i = 0; i < clones.Length; i++){
                Debug.Log(clones[i]);
                if (clones[i] != this.gameObject){
                    Destroy(clones[i]);
                }
            }
            if (other != null){
                Destroy(this.gameObject);
            }
        }
    }
    
    void Start() {
        preLoaded = true;
    }
}
