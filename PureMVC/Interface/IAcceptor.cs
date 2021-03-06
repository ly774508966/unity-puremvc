﻿using System.Collections.Generic;

namespace PureMVC
{
    public interface IAcceptor
    {
        string Acceptor { get; }
    }
    public interface IAcceptors : IAcceptor
    {
        IList<string> Acceptors { get; }
    }
}