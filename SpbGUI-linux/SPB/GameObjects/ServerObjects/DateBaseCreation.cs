// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using Octokit;
using SPB.Security;
using SPB.Constants;

namespace SPB.GameObjects.ServerObjects
{
    public class DataBaseCreation : CreateFileRequest
    {
        //-------------------------------------------------
        #region Constants Region

        #endregion
        //-------------------------------------------------
        #region Contructors Region
        public DataBaseCreation(StrongString theMessage, 
            QString theContext) :
            base(theMessage.GetValue(), theContext.GetString())
        {
            // do nothing here...
        }
        public DataBaseCreation(StrongString theMessage,
            string theContext) : this(theMessage, QString.Parse(theContext.ToStrong()))
        {

        }
        #endregion
        //-------------------------------------------------
    }
}
