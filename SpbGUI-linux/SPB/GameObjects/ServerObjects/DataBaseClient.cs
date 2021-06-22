// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using Octokit;
using SPB.Security;
using SPB.Constants;

namespace SPB.GameObjects.ServerObjects
{
    public class DataBaseClient : GitHubClient
    {
        //-------------------------------------------------
        #region Constructor's Region
        public DataBaseClient(DataBaseHeader header, QString cridental) :
            base(header)
        {
            Credentials = new DataBaseCredential(cridental);
            SetRequestTimeout(ThereIsConstants.AppSettings.DefaultDataBaseTimeOut);
        }
        #endregion
        //-------------------------------------------------
    }
}
