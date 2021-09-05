using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://www.raywenderlich.com/2826197-scriptableobject-tutorial-getting-started")]
[CreateAssetMenu(fileName = "New Game Event",menuName = "Game Event",order = 52)]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners = new List<GameEventListener>();//一个GameEventListeners的List，它将订阅你的GameEvent。
    
    public void Raise() //一个调用GameEvent的所有订阅者的方法。
    {
        //最后一个 GameEventListener 将首先被调用（后进先出）
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            //调用每个 GameEventListeners 的 UnityEvent
            listeners[i].OnEventRaised(); //事件发生时
        }
    }
    
    public void RegisterListener(GameEventListener listener)//一个允许GameEventListeners订阅此GameEvent的方法。
    {
        listeners.Add(listener);
    }
    
    public void UnregisterListener(GameEventListener listener)//一个允许GameEventListeners取消订阅此GameEvent的方法。
    {
        listeners.Remove(listener);
    }
}
