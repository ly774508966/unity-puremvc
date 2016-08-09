﻿using UnityEngine;
using System.Collections;
using System;

public class Notification<T> : INotification<T>
{
    public Notification() { }
	public Notification(ObserverName observerName)
    {
        ObserverName = observerName;
    }
	public Notification(ObserverName observerName, T body)
    {
        this.ObserverName = observerName;
        this.Body = body;
    }
	public Notification(ObserverName observerName, T body, Type type)
    {
        ObserverName = observerName;
        Type = type;
        Body = body;
    }

    public T Body { get; set; }
    public Type Type { get; set; }
	public ObserverName ObserverName { get; set; }
    public new string ToString
    {
        get
        {
            string msg = "";
            msg += "\nObserverName:" + ObserverName.ToString();
            msg += "\nBody:" + ((Body == null) ? "null" : Body.ToString());
            msg += "\nType:" + ((Type == null) ? "null" : Type.ToString());
            return msg;
        }
    }
    public bool isUsing { get; set; }
}