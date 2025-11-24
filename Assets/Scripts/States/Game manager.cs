using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        GAMEPLAY,
        PAUSE
    }

    public GameState state;
    public bool has_changed_state = false;

    public void pausing()
    {
        switch (state)
        {
            case GameState.GAMEPLAY:
                state = GameState.PAUSE;
                has_changed_state = true;
                break;
            case GameState.PAUSE:
                state = GameState.GAMEPLAY;
                has_changed_state = true;
                break;
            default:
                break;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameState.GAMEPLAY;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        // checking if the game has been paused
        if (has_changed_state == true)
        {
            switch (state)
            {
                case GameState.PAUSE:
                    Time.timeScale = 0.0f;
                    break;
                case GameState.GAMEPLAY:
                    Time.timeScale = 1.0f;
                    break;
                default:
                    Time.timeScale = 1.0f;
                    break;
            }

            has_changed_state = false;
        }
    }


}
