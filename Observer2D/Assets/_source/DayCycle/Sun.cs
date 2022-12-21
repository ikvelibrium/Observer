using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;




    public class Sun : IObserver
    {
        private Transform _sunPosition;
        private List<Transform> _positions;
        IObservable timer;

        public Sun(Transform positionOfSun, List<Transform> allSunPositions, IObservable clocks)
        {
            _sunPosition = positionOfSun;
            _positions = allSunPositions;
            timer = clocks;
            timer.CreateObserver(this);



        }

        public void Update(int dayPart, float dayTime)
        {
            Debug.Log("Солнце Работают");
            _sunPosition.DOMove(_positions[dayPart].position, dayTime);
        }
    }
