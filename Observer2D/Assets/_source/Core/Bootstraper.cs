using System.Collections;
using System.Collections.Generic;
using UnityEngine;






    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private Timer _clock;
        [SerializeField] private SpriteRenderer _backgroundImage;
        [SerializeField] private Transform _sun;
        [SerializeField] List<Color> _skyColors;
        [SerializeField] List<SpriteRenderer> _stars;
        [SerializeField] List<float> _ShadowValues;
        [SerializeField] List<Transform> _allSunPositions;




        private void Start()
        {
            Debug.Log("Бутстраппер работает");
            new Sky(_backgroundImage, _skyColors, _clock);
            new Stars(_stars, _ShadowValues, _clock);
            new Sun(_sun, _allSunPositions, _clock);

            _clock.Notify();
        }
    }
