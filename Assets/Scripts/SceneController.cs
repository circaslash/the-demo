using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;

    [SerializeField] private AudioClip music;
    [SerializeField] private AudioClip notes;
    [SerializeField] private TextMeshProUGUI _scoreUI;

    private int _score;

    public int Score

        {
        // Getter property
        get => _score;
        
        // Setter property
        set
        {
            _score = value;
            _scoreUI.text = Score.ToString();
        }
    }

    void Start() {
    }

    // IEnumerator MyCoroutine()
    // {
    //     yield return new WaitForSeconds(5f);
    //     //code here will execute after 5 seconds
    // }

    public void playSound() {
        //Debug.Log("TEST");
        audioSource.PlayOneShot(notes);
        Score++;
    }

}

