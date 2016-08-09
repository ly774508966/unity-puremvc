﻿using UnityEngine;
using System;

public interface IFacade:INotifier
{
    void RegisterProxy(IProxy prox);
    IProxy RetrieveProxy(string name);
    T RetrieveProxy<T>(string name) where T : IProxy;
    IProxy RemoveProxy(string name);

    void RegisterMediator(IMediator mediator);
    IMediator RetrieveMediator(string name);
    T RetrieveMediator<T>(string name) where T : IMediator;
    void RemoveMediator(string name);

    void RegisterCommand(string noti, Type cmd);
    Type RemoveCommand(string noti);
}