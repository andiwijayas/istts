﻿using System;
using System.Collections.Generic;

namespace Patterns.Observer
{
    public class Payload
    {
        public string Message { get; set; }
    }
    public class Subject : IObservable<Payload>
    {
        public IList<IObserver<Payload>> Observers { get; set; }

        public Subject()
        {
            Observers = new List<IObserver<Payload>>();
        }

        public IDisposable Subscribe(IObserver<Payload> observer)
        {         
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
            return new Unsubscriber(observer, Observers);
        }

        public void SendMessage(string message)
        {
            foreach (var observer in Observers)
            {
                observer.OnNext(new Payload { Message = message });
            }
        }
    }
    public class Unsubscriber : IDisposable
    {
        private IObserver<Payload> observer;
        private IList<IObserver<Payload>> observers;
        public Unsubscriber(
            IObserver<Payload> observer,
            IList<IObserver<Payload>> observers)
        {
            this.observer = observer;
            this.observers = observers;
        }

        public void Dispose()
        {
            if (observer != null && observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
    public class Observer : IObserver<Payload>
    {
        public string Message { get; set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Payload value)
        {
            Message = value.Message;
        }

        public IDisposable Register(Subject subject)
        {
            return subject.Subscribe(this);
        }
    }
}