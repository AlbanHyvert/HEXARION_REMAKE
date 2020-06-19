using Engine.Singleton;
using UnityEngine;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager>
{
    public enum GameState
    {
        PRELOAD,
        MAINMENU,
        LOADING,
        GAME,
    }

    public enum Language
    {
        ENGLISH,
        FRENCH
    }

    [SerializeField] private GameState _gameState = GameState.GAME;

    private GameState _currentState = GameState.PRELOAD;
    private Dictionary<GameState, IGameStates> _states = null;

    public IGameStates CurrentStateType { get { return _states[_currentState]; } }
    public GameState CurrentState { get { return _currentState; } }
    public GameState ChoosenScene { get { return _gameState; } set { _gameState = value; } }

    private void Start()
    {
        _states = new Dictionary<GameState, IGameStates>();
        /*_states.Add(GameState.PRELOAD, new PreloadState());
        _states.Add(GameState.MAINMENU, new MainMenuState());
        _states.Add(GameState.LOADING, new LoadingState());
        _states.Add(GameState.GAME, new GameSceneState());*/
        _currentState = GameState.PRELOAD;
        ChangeState(GameState.MAINMENU);
    }

    public void ChangeState(GameState nextState)
    {
        _states[_currentState].Exit();
        _states[nextState].Enter();
        _currentState = nextState;
    }
}
