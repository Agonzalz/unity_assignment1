using TMPro;
using TMPro.Examples;
using Unity.Burst;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{   
    public static GameManager current;
    [SerializeField] private TextMeshProUGUI attemptUI;
    public int attempts;

    //when clicking the save button
    public static void Save() 
    {
        SaveSystem.SaveJson(new PlayerStats(SceneManager.GetActiveScene().name, current.attempts));

    }

    public void CheckSave() {
        PlayerStats player = SaveSystem.LoadJson();
        if (player.current_level == SceneManager.GetActiveScene().name) {
            current.attempts = player.attempts;
        } else {
            return;
        }
    }

    public void IncreaseAttempts() {
        attempts++;
        UpdateAttempt();
    }

    private void UpdateAttempt() {
        attemptUI.text = "Attempts: " + attempts;   
    
    }

    private void Awake()
    {
       
    }

    void Start()
    {     
        current = this;
         if (attemptUI == null)
        {
            Debug.LogError("TextMeshProUGUI component is not assigned in GameManager.");
        }
        CheckSave();
        UpdateAttempt();
    }
    
}