using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

[SerializeField] AudioSource audioSource;

[SerializeField] private AudioClip music;
[SerializeField] private AudioClip notes;

void Start() {
}

// IEnumerator MyCoroutine()
// {
//     yield return new WaitForSeconds(5f);
//     //code here will execute after 5 seconds
// }

public void playSound() {
    audioSource.PlayOneShot(notes);
}

}

