// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using SPB.GameObjects.Resources;

namespace SPB.Controls
{
    /// <summary>
    /// Woto Resources Provider.
    /// </summary>
    public interface IRes
    {
        //-------------------------------------------------
        #region Properties Region
        /// <summary>
        /// Woto ResourceManager.
        /// </summary>
        WotoRes MyRes { get; set; }
        #endregion
        //-------------------------------------------------
    }
}
