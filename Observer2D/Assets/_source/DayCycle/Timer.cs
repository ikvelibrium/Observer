using System.Collections;
using System.Collections.Generic;
using UnityEngine;





    public class Timer : MonoBehaviour, IObservable
    {
        [SerializeField] private float _oneSectionTime;
        [SerializeField] private int _dayPart;
        private List<IObserver> _observers;
        private float _timeRightNow;
        private bool _kostl = true;

        private void Start()
        {
            Debug.Log("таймер start");
            _observers = new List<IObserver>();
            _timeRightNow = _oneSectionTime;
        }
        private void Update()
        {
            Debug.Log("update работает");
            if (_timeRightNow <= 0 || _kostl == true)
            {
                
                Notify();
                _kostl = false;
            }
            _timeRightNow -= Time.deltaTime;
        }

        public void CreateObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void DeleteObserver(IObserver o)
        {
            _observers.Remove(o);
        }
        public void Notify()
        {
            _timeRightNow = _oneSectionTime;
            foreach (IObserver o in _observers)
            {
                Debug.Log("форич в тайме запустился");
                o.Update(_dayPart, _timeRightNow);
                _dayPart++;
                if (_dayPart >= 5)
                {
                    _dayPart = 0;
                }
            }
        }
    }
