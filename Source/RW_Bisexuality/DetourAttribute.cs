﻿using System;
using System.Reflection;

namespace RW_Bisexuality
{

    [AttributeUsage(AttributeTargets.Method)]
    internal class DetourAttribute : Attribute
    {
        public Type source;
        public BindingFlags bindingFlags;

        public DetourAttribute(Type source)
        {
            this.source = source;
        }
    }

}