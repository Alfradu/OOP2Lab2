using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomDatastructures.Core;

namespace CustomCollections
{
    public class ObservableList<T> : IEnumerable<T>, IObservableList<T>
    {
        public List<T> internalList { get; set; }
        public event EventHandler<ListChangedEventArgs<T>> Changed;
        public event EventHandler<RejectableEventArgs<T>> BeforeChange;

        public ObservableList()
        {
            internalList = new List<T>();
        }

        public bool Contains(T item) { return internalList.Contains(item); }
        public void Add(T item) {
            RejectableArgs<T> eventObject = new RejectableArgs<T>(Operation.Add, item, internalList.Count);
            OnBeforeChangeEvent(eventObject);
            if (item.ToString().Trim().Length < 1)
            {
                throw new InvalidOperationException();
            }
            if (eventObject.IsOperationRejected)
            {
                throw new OperationRejectedException(String.Format("Failed to {0} item '{1}'.", eventObject.Operation, eventObject.Value));
            }
            internalList.Add(item);
            OnChangedEvent(new ListChangedEventArgs<T>(Operation.Add, item, internalList.Count));
        }

        public void Remove(T item) {
            RejectableArgs<T> eventObject = new RejectableArgs<T>(Operation.Remove, item, internalList.Count);
            OnBeforeChangeEvent(eventObject);
            if (internalList.IndexOf(item) < 0)
            {
                throw new InvalidOperationException();
            }
            else if (eventObject.IsOperationRejected)
            {
                throw new OperationRejectedException(String.Format("Failed to {0} item '{1}'.", eventObject.Operation, eventObject.Value));
            }
            internalList.Remove(item);
            OnChangedEvent(new ListChangedEventArgs<T>(Operation.Remove, item, internalList.Count));
        }
        public bool TryAdd(T item)
        {
            RejectableArgs<T> eventObject = new RejectableArgs<T>(Operation.Add, item, internalList.Count);
            OnBeforeChangeEvent(eventObject);
            if (eventObject.IsOperationRejected)
            {
                return false;
            }
            internalList.Add(item);
            OnChangedEvent(new ListChangedEventArgs<T>(Operation.Add, item, internalList.Count));
            return true;
        }

        public bool TryRemove(T item)
        {
            RejectableArgs<T> eventObject = new RejectableArgs<T>(Operation.Remove, item, internalList.Count);
            OnBeforeChangeEvent(eventObject);
            if (eventObject.IsOperationRejected || internalList.IndexOf(item) < 0)
            {
                return false;
            }
            internalList.Remove(item);
            OnChangedEvent(new ListChangedEventArgs<T>(Operation.Remove, item, internalList.Count));
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return internalList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)internalList).GetEnumerator();
        }

        private void OnChangedEvent(ListChangedEventArgs<T> listChangedEventArgs) => Changed?.Invoke(this, listChangedEventArgs);
        private void OnBeforeChangeEvent(RejectableArgs<T> rejectableEventArgs) => BeforeChange?.Invoke(this, rejectableEventArgs);
    }
}

