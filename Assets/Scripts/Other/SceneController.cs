using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using System.Collections.Generic;

#if UNITY_EDITOR
    using UnityEditor;
#endif

public class SceneController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _pauseMessage;
    public static SceneController Instance;
    public Utilities.GameplayState State;
    [SerializeField] AudioSource mainAudioSource;
    [SerializeField] AudioSource SFXAudioSource;
    [SerializeField] AudioSource otherAudioSource;

    [SerializeField] private AudioClip theMusic;
    [SerializeField] private AudioClip otherElements;
    [SerializeField] private AudioClip notes;
    [SerializeField] private TextMeshProUGUI _scoreUI;
    private bool hasHappened = false;

    private Color targetColor = Color.white;

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

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        State = Utilities.GameplayState.Play;
        mainAudioSource.clip = theMusic;
        mainAudioSource.Play();
        StartCoroutine(OtherElementsTriggered());
        Camera.main.backgroundColor = Color.white;
        _pauseMessage.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
        QuitApp();
        }
    
        if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("yeah");
                State = State == Utilities.GameplayState.Play
                    ? Utilities.GameplayState.Pause
                    : Utilities.GameplayState.Play;
                _pauseMessage.enabled = !_pauseMessage.enabled;
            }
        switch (_score)
        {
            case 10:
                targetColor = Color.blue;
                break;
            case 15:
                targetColor = Color.yellow;
                break;
            case 20:
                targetColor = Color.green;
                break;
            case 25:
                targetColor = new Color(1f, 0.75f, 0.8f);
                break;
            case 30:
                targetColor = Color.red;
                break;
            case 35:
                targetColor = new Color(1f, 0.5f, 0f);
                break;
            case 40:
                targetColor = Color.cyan;
                break;
            case 45:
                targetColor = Color.black;
                break;
            case 50:
                targetColor = Color.white;
                break;
        }
        Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, targetColor, Time.deltaTime * 2f);
    }
    IEnumerator OtherElementsTriggered()
    {
        yield return new WaitUntil(() => _score == 10 && !hasHappened);
        otherAudioSource.clip = otherElements;
        otherAudioSource.Play();
        //code here will execute after a bit
        hasHappened = true;
    }

    public void playSound()
    {
        //Debug.Log("TEST");
        SFXAudioSource.PlayOneShot(notes);
        Score++;
    }
    void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    void QuitApp()
    {
#if UNITY_EDITOR
                // Set variable if game is running from Unity
                EditorApplication.isPlaying = false;
#else
        // Function will be called if game is running from a build
        Application.Quit();
#endif
    }

}

