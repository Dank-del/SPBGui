﻿// WotoProvider (for SPB)
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

namespace WotoProvider.Interfaces
{
    /// <summary>
    /// Represent an object that has a 
    /// Location.
    /// </summary>
    public interface ILocation
    {
        float X { get; }
        float Y { get; }
    }
}
