// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using GUISharp.Client;
using GUISharp.GUIObjects.Resources;
using GUISharp.Controls.Elements;

namespace SPB.Client
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public sealed partial class MainClient : GUIClient
    {
        //-------------------------------------------------
        #region Constant's Region
		public const string EntityNameInRes = "EntityElement";
		public const string LookupButtonNameInRes = "Button1";
		public const int from_the_edge = 10;
        #endregion
        //-------------------------------------------------
        #region Properties Region
		public FlatElement EntityElement { get; set; }
		public InputElement InputBox { get; set; }
		public ButtonElement LookupButton { get; set; }
		public override WotoRes MyRes {get; set;}
        #endregion
        //-------------------------------------------------
        #region field's Region

        #endregion
        //-------------------------------------------------
        #region Constructor's Region
        public MainClient() : base(ClientSizeMode.HalfMiddle)
        {
			//InitializeComponents();
        }
        #endregion
        //-------------------------------------------------
        #region Get Method's Region
		
        #endregion
        //-------------------------------------------------
    }
}
