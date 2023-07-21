using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour{
    //The format of a single Character
    [System.Serializable]
    public struct SceneMusic{
        public string Name;
        public AudioClip Music;
        public SceneMusic(string name , AudioClip music){
            this.Name = name;
            this.Music = music;
        }
    }
    public SceneMusic[] scenes;
    public AudioSource audioSource;
    
    public void Awake(){
        DontDestroyOnLoad(this.gameObject);
        GameObject[] results = GameObject.FindGameObjectsWithTag("Music 1");
        if (results.Length > 1){
            Destroy(gameObject);
        }
    }
    
    void Start() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        for (int i = 0; i < scenes.Length; i++){
            if (scenes[i].Name == scene.name){
                if (audioSource.clip != scenes[i].Music){
                    audioSource.clip = scenes[i].Music;
                    audioSource.time = 0;
                    audioSource.Play();
                    break;
                }
            }
        }
    }
}
