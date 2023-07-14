using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STARTUP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //RATCHET ASS CODE
        GameObject[] musics = GameObject.FindGameObjectsWithTag("Music 1");
        for (int i = 0; i < musics.Length; i++){
            musics[i].GetComponent<DontDestroyOnLoad>().Awake();
        }
        musics = GameObject.FindGameObjectsWithTag("Music 2");
        for (int i = 0; i < musics.Length; i++){
            musics[i].GetComponent<DontDestroyOnLoad>().Awake();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
