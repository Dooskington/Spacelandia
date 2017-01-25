﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Source.Data
{
    [CreateAssetMenu(menuName = "Data/Ore")]
    public class Ore : ScriptableObject
    {
        public string oreName;
        public Sprite sprite;
    }
}