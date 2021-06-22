// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using WotoProvider.EventHandlers;
using WotoProvider.Enums;
using SPB.SandBox;
using SPB.Controls;
using SPB.Constants;
using SPB.GameObjects.UGW;
using SPB.Controls.Elements;
using SPB.GameObjects.Resources;
using Microsoft.Xna.Framework.Input;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;

namespace SPB.Client
{
	partial class MainClient
	{
		//-------------------------------------------------
		#region MainForm Region

		//-------------------------------------------------
		#region Initialize Region
		/// <summary>
		/// MainForm Initialize Component.
		/// </summary>
		private void MF_InitializeComponents()
		{
			//try
			//{
			//	// HttpListener _listener = new HttpListener();
			//	TcpClient _tcp = new TcpClient();
			//	NetworkStream _stream;
			//	_tcp.Connect("localhost", 37372);
			//	_stream = _tcp.GetStream();
			//	byte[] _b = new byte[512];
			//	var _result = _stream.Read(_b);
			//	var _str = System.Text.Encoding.UTF8.GetString(_b).TrimEnd();
			//	Console.WriteLine("got something! :" + _str + " - " + _str.Length + " - "+ _b.Length);
			//}
			//catch
			//{
			//	
			//}
			
#if BUTTON_TEST_1
			//---------------------------------------------
			//news:
			this.MyRes = new WotoRes(typeof(MainClient));
			this.FirstFlatElement = new FlatElement(this, ElementMovements.HorizontalMovements);
			ButtonElement test = new ButtonElement(this);
			FlatElement _f1 = new FlatElement(this, ElementMovements.VerticalHorizontalMovements);
			FlatElement _f2 = new FlatElement(this, ElementMovements.HorizontalMovements);
			this.LoadMFBackGround();
			//---------------------------------------------
			//names:
			this.FirstFlatElement.SetLabelName(FirstLabelNameInRes);

			//fontAndTextAligns:
			this.FirstFlatElement.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 19));
			test.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 19));
			_f1.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 19));
			_f2.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 19));
			
			this.FirstFlatElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			test.ChangeAlignmation(StringAlignmation.MiddleCenter);
			_f1.ChangeAlignmation(StringAlignmation.MiddleCenter);
			_f2.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			this.FirstFlatElement.ChangePriority(ElementPriority.Normal);
			_f1.ChangePriority(ElementPriority.Normal);
			_f2.ChangePriority(ElementPriority.VeryHigh);
			test.ChangePriority(ElementPriority.High);
			//sizes:
			this.FirstFlatElement.ChangeSize(this.Width / 6, this.Height / 6);
			test.ChangeSize(150, 46);
			_f1.ChangeSize(200, 300);
			_f2.ChangeSize(100, 100);
			//ownering:
			_f2.SetOwner(_f1);
			//locations:
			this.FirstFlatElement.ChangeLocation((Width - FirstFlatElement.Width) -
				(2 * SandBoxBase.from_the_edge),
				(Height - FirstFlatElement.Height) - SandBoxBase.from_the_edge);

			test.ChangeLocation(100f, 100f);
			_f1.ChangeLocation(300f, 200f);
			_f2.ChangeLocation(10f, 10f);
			//movements:
			this.FirstFlatElement.ChangeMovements(ElementMovements.VerticalMovements);
			_f1.ChangeMovements(ElementMovements.VerticalHorizontalMovements);
			//colors:
			// this.FirstFlatElement.ChangeBackColor(Color.Red);
			this.FirstFlatElement.ChangeForeColor(Color.DarkSeaGreen);
			test.ChangeBorder(WotoProvider.Enums.ButtonColors.WhiteSmoke);
			_f1.ChangeBackColor(new Color(Color.Orange, 0.5f));
			_f2.ChangeBackColor(Color.Blue);
			_f2.ChangeForeColor(new Color(Color.Red, 0.7f));
			//test.ChangeForeColor(Color.Red);
			//enableds:
			test.EnableMouseEnterEffect();
			//texts:
			this.FirstFlatElement.SetLabelText();
			test.SetLabelText("Test");
			//_f1.SetLabelText("F1");
			_f2.SetLabelText("Flat2");
			//images:
			this.FirstFlatElement.ChangeImage();
			
			
			//applyAndShow:
			this.FirstFlatElement.Apply();
			this.FirstFlatElement.Show();
			_f2.Apply();
			_f2.Show();
			_f1.Apply();
			_f1.Show();

			test.Apply();
			test.Show();
			//events:
			this.GameUniverse.WotoPlanet.MouseDown += WotoPlanet_MouseDown;
			this.GameUniverse.WotoPlanet.MouseUp += WotoPlanet_MouseUp;
			this.Window.TextInput += Window_TextInput;
			//---------------------------------------------
			//addRanges:
			this.ElementManager.Add(this.FirstFlatElement);
			this.ElementManager.Add(test);
			this.ElementManager.Add(_f1);
			//---------------------------------------------
#endif
			//---------------------------------------------
			//news:
			this.MyRes = new WotoRes(typeof(MainClient));
			this.FirstFlatElement = new(this);
			this.UserNoticeElement = new(this);
			this.UserInputElement = new(this);
			this.LookupButtonElement = new(this);
			this.ExitButtonElement = new(this);
			this.LoadMFBackGround();
			//---------------------------------------------
			//names:
			this.FirstFlatElement.SetLabelName(FirstLabelNameInRes);
			this.UserNoticeElement.SetLabelName(NoticeLabelNameInRes);
			this.LookupButtonElement.SetLabelName(LookupButtonNameInRes);
			this.ExitButtonElement.SetLabelName(ExitButtonNameInRes);
			//status:
			this.FirstFlatElement.SetStatus(1);
			this.UserNoticeElement.SetStatus(1);
			this.UserInputElement.SetStatus(1);
			this.LookupButtonElement.SetStatus(1);
			this.ExitButtonElement.SetStatus(1);
			//fontAndTextAligns:
			this.FirstFlatElement.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 26));
			this.UserNoticeElement.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 26));
			this.UserInputElement.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 25));
			this.LookupButtonElement.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 23));
			this.ExitButtonElement.ChangeFont(this.FontManager.GetSprite(SPB_Fonts.SPB_tt_regular, 23));
			this.FirstFlatElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.UserNoticeElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.UserInputElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.LookupButtonElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.ExitButtonElement.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			this.FirstFlatElement.ChangePriority(ElementPriority.Normal);
			this.UserNoticeElement.ChangePriority(ElementPriority.High);
			this.UserInputElement.ChangePriority(ElementPriority.Normal);
			this.LookupButtonElement.ChangePriority(ElementPriority.High);
			this.ExitButtonElement.ChangePriority(ElementPriority.High);
			//sizes:
			this.FirstFlatElement.ChangeSize(this.Width / 6, this.Height / 6);
			this.UserNoticeElement.ChangeSize(2 * (this.Width / 7) + 
				(2 * SandBoxBase.from_the_edge), this.Height / 7);
			this.UserInputElement.ChangeSize(2 * (this.Width / 7), default);
			this.LookupButtonElement.ChangeSize();
			this.ExitButtonElement.ChangeSize();
			//ownering:
			//locations:
			this.FirstFlatElement.ChangeLocation((this.Width - FirstFlatElement.Width) -
				(2 * SandBoxBase.from_the_edge),
				(Height - FirstFlatElement.Height) - SandBoxBase.from_the_edge);
			this.UserInputElement.ChangeLocation((9 * (this.Width / 10)) - 
				this.UserInputElement.Width, (3 * (this.Height / 5)) -
				this.UserInputElement.Height);
			this.LookupButtonElement.ChangeLocation(this.UserInputElement.RealX + 
				(this.UserInputElement.Width / 2) + SandBoxBase.from_the_edge,
				this.UserInputElement.RealY + this.UserInputElement.Height + 
			SandBoxBase.from_the_edge);
			this.ExitButtonElement.ChangeLocation(this.UserInputElement.RealX + 
				(this.UserInputElement.Width / 2) - SandBoxBase.from_the_edge -
				this.ExitButtonElement.Width,
				this.LookupButtonElement.RealY);
			this.UserNoticeElement.ChangeLocation(this.UserInputElement.RealX +
				(this.UserInputElement.Width / 2) - (this.UserNoticeElement.Width / 2),
				this.UserInputElement.RealY - this.UserNoticeElement.Height -
				SandBoxBase.from_the_edge);
			//movements:
			//colors:
			this.UserInputElement.ChangeBorder(InputBorders.Goldenrod);
			this.FirstFlatElement.ChangeForeColor(Color.DarkSeaGreen);
			this.UserNoticeElement.ChangeForeColor(Color.WhiteSmoke);
			this.LookupButtonElement.ChangeBorder(ButtonColors.GreenYellow);
			this.ExitButtonElement.ChangeBorder(ButtonColors.Red);
			//enableds:
			this.FirstFlatElement.Enable(true);
			this.UserNoticeElement.Enable(true);
			this.UserInputElement.Enable(true);
			this.LookupButtonElement.Enable();
			this.LookupButtonElement.EnableMouseEnterEffect();
			this.ExitButtonElement.Enable();
			this.ExitButtonElement.EnableMouseEnterEffect();
			this.UserInputElement.EnableMouseEnterEffect();
			this.UserInputElement.Focus(true); // force it to focus itself
			//texts:
			this.FirstFlatElement.SetLabelText();
			this.UserNoticeElement.SetLabelText();
			this.LookupButtonElement.SetLabelText();
			this.ExitButtonElement.SetLabelText();
			//images:
			this.FirstFlatElement.ChangeImage();
			//applyAndShow:
			this.FirstFlatElement.Apply();
			this.FirstFlatElement.Show();
			this.UserNoticeElement.Apply();
			this.UserNoticeElement.Show();
			this.UserInputElement.Apply();
			this.UserInputElement.Show();
			this.LookupButtonElement.Apply();
			this.LookupButtonElement.Show();
			this.ExitButtonElement.Apply();
			this.ExitButtonElement.Show();
			//events:
			this.InitializeMainEvents();
			//---------------------------------------------
			//addRanges:
			this.ElementManager.AddRange(
				this.FirstFlatElement,
				this.UserNoticeElement,
				this.UserInputElement,
				this.LookupButtonElement,
				this.ExitButtonElement);
			//---------------------------------------------
			//finalBlow:
			//---------------------------------------------
		}

		
		/// <summary>
		/// add the main events.
		/// </summary>
		private void InitializeMainEvents()
		{
			//---------------------------------------------
			this.GameUniverse.MouseDown		-= WotoPlanet_MouseDown;
			this.GameUniverse.MouseUp		-= WotoPlanet_MouseUp;
			this.Window.TextInput			-= Window_TextInput;
			this.GameUniverse.MouseDown		+= WotoPlanet_MouseDown;
			this.GameUniverse.MouseUp		+= WotoPlanet_MouseUp;
			this.Window.TextInput			+= Window_TextInput;
			//---------------------------------------------
		}
		/// <summary>
		/// Load the Main Form Background of the game.
		/// </summary>
		/// <param name="_loading"></param>
		private void LoadMFBackGround(bool _loading = true)
		{
			if (_loading)
			{
				this.BackGroundTexture?.Dispose();
				var num = DateTime.Now.Second % EntryCount;
				var name = EntryPicNameInRes + num.ToString();
				var b = (byte[])this.MyRes.GetObject(name);
				if (b == null)
				{
					return;
				}

				using (var m = new MemoryStream(b))
				{
					this.BackGroundTexture = Texture2D.FromStream(GraphicsDevice, m);
				}
			}
			else
			{
				// Not Completed
				this.BackGroundTexture?.Dispose();
				using (var m = this.MyRes.GetStream(AincradNameInRes))
				{
					this.BackGroundTexture = Texture2D.FromStream(GraphicsDevice, m);
				}
			}
			
		}
		#endregion
		//-------------------------------------------------

		#endregion
		//-------------------------------------------------
		#region MainClient Region

		#endregion
		//-------------------------------------------------
		#region overrided Method's Region
		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			ThereIsConstants.Forming.MainClient = this;
			this.FontManager = FontManager.GenerateManager(this);
			this.ElementManager = new ElementManager();
			this.MF_InitializeComponents();
			base.Initialize();
			// check if the game window position is zero or not.
			if (Window.Position != Point.Zero)
			{
				// set the game window position to zero.
				Window.Position = Point.Zero;
			}
#if __LINUX__
			// check if game universe have to check the 
			// __mmf__ assist file or not.
			if (!this.GameUniverse._checkFile)
			{
				this.GameUniverse._checkFile = true;
			}
#endif
			// game should always be in the fullscreen mode.
			this.GraphicsDM.ToggleFullScreen();
		}


		//private FontSystem Fonts;
		//private SpriteFont test;
		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			//---------------------------------------------
			//news:
			this.SpriteBatch = new SpriteBatch(GraphicsDevice);
			//---------------------------------------------
		}
		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			//---------------------------------------------
			//---------------------------------------------
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			// Allows the game to exit
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
			{
				this.Exit();
			}
			// update the game universe, so it can handle its own events.
			this.GameUniverse?.UpdateUniverse();
			// check the requests came from outside of the envinment of the Game. 
			this.CheckRequests();
			// check mouse actions of the elements.
			this.MouseActions();
			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			this.GraphicsDevice.Clear(Color.Black);
			this.DrawBackGround();
			this.ElementManager?.Draw(gameTime, this.SpriteBatch);
			base.Draw(gameTime);
		}
		#endregion
		//-------------------------------------------------
		#region Background Method's Region
		/// <summary>
		/// allow the <see cref="MainClient"/> to draw its background.
		/// </summary>
		private void DrawBackGround()
		{
			if (this.BackGroundTexture == null || this.BackGroundTexture.IsDisposed)
			{
				return;
			}
			this.SpriteBatch.Begin();
			this.SpriteBatch.Draw(this.BackGroundTexture, this.GameUniverse.XRectangle, 
				this.BackGroundTexture.Bounds, 
				Color.White);
			this.SpriteBatch.End();
		}
		#endregion
		//-------------------------------------------------
		#region Odrinary Method's Region
		private void CheckRequests()
		{
			// chec if there is a request from the universe or not.
			if (this.Universe_Request)
			{
				switch (Request)
				{
					case RequestType.None:
						break;
					case RequestType.Activate:
					{
						try
						{
							this.Universe_Request = false;
							this.Request = RequestType.None;
							// this.GameUniverse.WotoPlanet?.Show();
							// this.GameUniverse.WotoPlanet?.BringToFront();
							// this.GameUniverse.WotoPlanet?.Activate();
							// this.GameUniverse.WotoPlanet?.Focus();
							this.GraphicsDM.ToggleFullScreen();
						}
						catch
						{
							// the activating was not successful,
							// so what should we do??
							// here was the last step that we could avtive the
							// holy planet of woto, but it failed, 
							// it means there is no further steps.
							// so the story will end right here right now.
						}
						break;
					}
					default:
						break;
				}

			}
		}
		private void MouseActions()
		{
			this.LastMouseState = this.CurrentState;
			this.CurrentState = Mouse.GetState();
			if (this.ElementManager != null)
			{
				if (this.ElementManager.MouseContains())
				{
					this.ElementManager.MouseChange();
				}
			}
		}
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
		public void ActivateInputable(IInputable inputElement)
		{
			if (inputElement == null || inputElement == this.InputElement)
			{
				return;
			}
			this.InputElement = inputElement;
			this.InputElement.Focus(true);
		}
		public void DeactiveInputable()
		{
			if (this.InputElement != null)
			{
				this.InputElement?.UnFocus();
				this.InputElement = null;
			}
		}
		#endregion
		//-------------------------------------------------
		#region event Method's Region
		private void WotoPlanet_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (this.IsLeftDown)
				{
					this.PreviousLeftDownPoint = this.LeftDownPoint;
					this.LeftDownPoint = null;
					this.IsLeftDown = false;
				}
			}
			else if (e.Button == MouseButtons.Right)
			{
				if (this.IsRightDown)
				{
					this.PreviousRightDownPoint = this.RightDownPoint;
					this.RightDownPoint = null;
					this.IsRightDown = false;
				}
			}
		}

		private void WotoPlanet_MouseDown(object sender, MouseEventArgs e)
		{
			
			if (e.Button == MouseButtons.Left)
			{
				if (!this.IsLeftDown)
				{
					this.LeftDownPoint = this.CurrentState.Position;
					this.IsLeftDown = true;
				}
			}
			else if (e.Button == MouseButtons.Right)
			{
				if (!this.IsRightDown)
				{
					this.RightDownPoint = this.CurrentState.Position;
					this.IsRightDown = true;
				}
			}
		}

		private void Window_TextInput(object sender, TextInputEventArgs e)
		{
			this.InputElement?.InputEvent(sender, e);
			//this.FirstFlatElement.ChangeText(
				//this.FirstFlatElement.Text.Append(e.Character, true));
		}
		#endregion
		//-------------------------------------------------
	}
}
