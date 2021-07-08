using System;
using Microsoft.Xna.Framework;
using GUISharp.Controls;
using GUISharp.GUIObjects.Texts;
using GUISharp.Controls.Elements;
using GUISharp.WotoProvider.Enums;
using SPB.IntelliCore;
using static SPB.Constants.WotoParams;

namespace SPB.Client
{
	partial class MainClient
	{
		//-------------------------------------------------
		#region Initialize Method's Region
		protected override void InitializeComponents()
		{
			//---------------------------------------------
			//news:
			this.MyRes = new(typeof(MainClient));
			this.ChangeSize(1.5f * Width, 1.5f * Height);
			var w = this.GetDevice().DisplayMode.Width;
			var h = this.GetDevice().DisplayMode.Height;
			this.ChangeLocation((w / 2) - (this.Width / 2),
				(h / 2) - (this.Height / 2));
			this.CalculateRates();
			this.EntityElement = new FlatElement(this);
			this.InputBox = new InputElement(this);
			this.LookupButton = new ButtonElement(this);
			//---------------------------------------------
			//names:
			this.EntityElement.SetLabelName(EntityNameInRes);
			this.LookupButton.SetLabelName(LookupButtonNameInRes);
			//status:
			//fontAndTextAligns:
			this.EntityElement.ChangeFont(FontManager.GetSprite(GUISharp_Fonts.noto_sans_JP, 42));
			this.InputBox.ChangeFont(FontManager.GetSprite(GUISharp_Fonts.noto_sans_JP, 40));
			this.LookupButton.ChangeFont(FontManager.GetSprite(GUISharp_Fonts.noto_sans_JP, 38));
			this.InputBox.ChangeAlignmation(StringAlignmation.MiddleCenter);
			this.LookupButton.ChangeAlignmation(StringAlignmation.MiddleCenter);
			//priorities:
			//sizes:
			this.EntityElement.ChangeSize(PWidth / 4, PHeight / 8);
			this.InputBox.ChangeSize();
			this.InputBox.ChangeSize(1.8f * this.InputBox.Width, 
				this.InputBox.Height);
			this.LookupButton.ChangeSize();
			//ownering:
			//locations:
			this.EntityElement.ChangeLocation(10, 10);
			this.LookupButton.ChangeLocation((this.Width / 2) - 
				(this.LookupButton.Width / 2), 
				this.Height - this.LookupButton.Height - 
				(2 * from_the_edge));
			this.InputBox.ChangeLocation((this.Width / 2) - 
				(this.InputBox.Width / 2), 
				this.LookupButton.RealY - 
				this.InputBox.Height - 
				(2 * from_the_edge));
			//movements:
			//colors:
			this.EntityElement.ChangeForeColor(Color.WhiteSmoke);
			this.InputBox.ChangeForeColor(Color.FloralWhite);
			this.LookupButton.ChangeBorder(ButtonColors.NormalGreenGreen);
			//enableds:
			this.EntityElement.Enable();
			this.LookupButton.Enable();
			this.InputBox.Enable();
			this.LookupButton.EnableMouseEnterEffect();
			this.InputBox.EnableMouseEnterEffect();
			//texts:
			this.EntityElement.SetLabelText();
			this.LookupButton.SetLabelText();
			//images:
			//applyAndShow:
			this.EntityElement.Apply();
			this.EntityElement.Show();
			this.InputBox.Apply();
			this.InputBox.Show();
			this.LookupButton.Apply();
			this.LookupButton.Show();
			//events:
			this.LookupButton.Click += LookupButton_Click;
			//---------------------------------------------
			//addRanges:
			this.ElementManager.AddRange(
				this.EntityElement,
				this.InputBox,
				this.LookupButton);
			//---------------------------------------------
			//finalBlow:
			//---------------------------------------------
		}
		#endregion
		//-------------------------------------------------
		#region Graphical Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region event Method's Region
		private void LookupButton_Click(object sender, System.EventArgs e)
		{
			var spb = Request.ApiRequest(this.InputBox.Text);
			this.EntityElement.ChangeText(spb.Data.Results.EntityType);
		}
		#endregion
		//-------------------------------------------------
		#region overrided Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region ordinary Method's Region
		private void CalculateRates()
		{
			float w = this.GetDevice().DisplayMode.Width;
			float h = this.GetDevice().DisplayMode.Height;
			Woto_WRate = WOTO_STD_WIDTH / w;
			Woto_HRate = WOTO_STD_HEIGHT / h;
			PWidth = (int)(Woto_WRate * Width);
			PHeight = (int)(Woto_HRate * Height);
		}
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------
		#region Set Method's Region
			// some methods here
		#endregion
		//-------------------------------------------------

	}
}