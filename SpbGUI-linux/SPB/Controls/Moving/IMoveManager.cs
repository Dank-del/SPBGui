﻿// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

namespace SPB.Controls.Moving
{
    /// <summary>
    /// represent a MoveManager interface for using as
    /// a manager of movements for a graphic element in SPB.
    /// </summary>
    public interface IMoveManager
    {
        //-------------------------------------------------
        #region Properties Region
        bool IsShocked { get; }
        bool Enabled { get; }
        bool MustDown { get; set; }
        IMoveable Activated { get; }
        #endregion
        //-------------------------------------------------
        #region Method's Region
        void MoveUs();
        void Enable();
        void Disable();
        void AddMe(IMoveable me);
        void Remove(IMoveable moveable);
        void Shocker(IMoveable sender);
        void Discharge(IMoveable sender);
        #endregion
        //-------------------------------------------------
    }
}
