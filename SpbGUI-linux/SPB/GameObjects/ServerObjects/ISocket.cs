// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using SPB.Security;

namespace SPB.GameObjects.ServerObjects
{
    /// <summary>
    /// an interface for Sockets.
    /// </summary>
    public interface ISocket
    {
        //-------------------------------------------------
        #region Properties Region

        #endregion
        //-------------------------------------------------
        #region Method's Region
        StrongString GetForServer();
        #endregion
        //-------------------------------------------------
    }
}
