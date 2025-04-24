using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] int _health = 5;

    private bool _isAlive;

    public bool IsAlive
    {
        get => _isAlive;
        set => _isAlive = value;
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        Debug.Log($"Health: {_health}");
    }

    public void Die() {
        IsAlive = false;

        SceneManager.LoadScene("SampleScene");
    }
    
    void Update () {
        if (transform.position.y < -5) {
            Die();

        }
    }

}
