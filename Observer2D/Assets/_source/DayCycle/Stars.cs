using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;




    public class Stars : IObserver
    {
        private List<SpriteRenderer> _stars;
        private List<float> _shadowLvl;
        IObservable timer;
        public Stars(List<SpriteRenderer> stars, List<float> shadows, IObservable clock)
        {
            timer = clock;
            _stars = stars;
            _shadowLvl = shadows;
            timer.CreateObserver(this);

        }   

        public void Update(int dayPart, float dayTime)
        {
            for (int i = 0; i < _stars.Count; i++)
            {
                Debug.Log("Звезды Работают");
                _stars[i].DOFade(_shadowLvl[dayPart], dayTime);
            }
        }
    }
