using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;




    public class Sky : IObserver
    {

        [SerializeField] private List<Color> _skyColors;
        private SpriteRenderer _background;
        IObservable timer;

        public Sky(SpriteRenderer background, List<Color> colors, IObservable clock)
        {
            timer = clock;
            _background = background;
            colors = _skyColors;
            timer.CreateObserver(this);
        }


        public void Update(int dayPart, float dayTime)
        {
            Debug.Log("Небо работает");
            _background.DOColor(_skyColors[dayPart], dayTime);
        }


    }
