﻿using ServicesLifetime.Interfaces;
using System;

namespace ServicesLifetime.Services
{
    public class TransientService : ITransientService
    {
        private readonly string _guid;

        public TransientService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
