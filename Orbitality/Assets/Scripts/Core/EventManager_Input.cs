using UnityEngine;
using System;

public class EventManager_Input : MonoBehaviour
{
    public static event EventHandler<GameEventArgs> BlockInput;
    public static event EventHandler<GameEventArgs> UnblockInput;
    public static event EventHandler<GameEventArgs> BackButtonPressed;

    public const string BLOCK_INPUT = "BlockInput";
    public const string UNBLOCK_INPUT = "UnblockInput";
    public const string BACK_BUTTON_PRESSED = "BackButtonPressed";

    public static void Subscribe(string type, EventHandler<GameEventArgs> handler)
    {
        switch (type)
        {
            case BLOCK_INPUT:
                BlockInput += handler;
                break;
            case UNBLOCK_INPUT:
                UnblockInput += handler;
                break;
            case BACK_BUTTON_PRESSED:
                BackButtonPressed += handler;
                break;
        }
    }

    public static void Unsubscribe(string type, EventHandler<GameEventArgs> handler)
    {
        switch (type)
        {
            case BLOCK_INPUT:
                BlockInput -= handler;
                break;
            case UNBLOCK_INPUT:
                UnblockInput -= handler;
                break;
            case BACK_BUTTON_PRESSED:
                BackButtonPressed -= handler;
                break;
        }
    }

    public static void Notify(object sender, GameEventArgs e)
    {
        switch (e.type)
        {
            case BLOCK_INPUT:
                BlockInput?.Invoke(sender, e);
                break;
            case UNBLOCK_INPUT:
                UnblockInput?.Invoke(sender, e);
                break;
            case BACK_BUTTON_PRESSED:
                BackButtonPressed?.Invoke(sender, e);
                break;
        }
    }

    public static void UnsubscribeAll()
    {
        BlockInput = null;
        UnblockInput = null;
        BackButtonPressed = null;
    }
}