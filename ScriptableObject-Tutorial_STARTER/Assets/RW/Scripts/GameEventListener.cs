using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    //订阅的事件
    [SerializeField] private GameEvent gameEvent; //此(这个脚本) GameEventListener 将订阅的 GameEvent
    //事件触发时的响应
    [SerializeField] private UnityEvent response;//当 GameEvent 引发此 GameEventListener 时将调用的 UnityEvent 响应

    private void OnEnable()
    {
        //启用此 GameObject 时，将 GameEvent 注册到 GameEventListener。
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        //当此 GameObject 被禁用时，从 GameEventListener 取消注册 GameEvent。
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        //当引发 GameEvent 导致 GameEventListener 调用 UnityEvent 时调用。
        //当事件发生时调用
        response.Invoke();
    }
}
