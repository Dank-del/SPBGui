// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using FontStashSharp;
using SPB.GameObjects.Resources;

namespace SPB.GameObjects.UGW
{
	partial class FontManager
	{
		//-------------------------------------------------
		#region Initialize Method's Region
		/// <summary>
		/// Initializ the components.
		/// </summary>
		private void InitializeComponents()
		{
			//---------------------------------------------
			//news:
			this.MyRes 						= new WotoRes(typeof(FontManager));
			this._ranges 					= _getRanges();
			this._old_story_bold 			= _generate();
			this._old_story_bold_italic 	= _generate();
			this._SPB_bold					= _generate();
			this._SPB_regular				= _generate();
			this._noto_sans_regular			= _generate();
			byte[] _old_story_bold_ 		= _fromRes(OSBFileInRes);
			byte[] _old_story_bold_italic_	= _fromRes(OSBIFileInRes);
			byte[] _SPB_bold_ 				= _fromRes(SPBTTBoldFileInRes);
			byte[] _SPB_regular_ 			= _fromRes(SPBTTRFileInRes);
			byte[] _noto_sans_regular_ 		= _fromRes(NSRFileInRes);
			//---------------------------------------------
			//add colection fonts:
			this._old_story_bold?.AddFont(_old_story_bold_);
			this._old_story_bold?.AddFont(_noto_sans_regular_);
			this._old_story_bold_italic?.AddFont(_old_story_bold_italic_);
			this._old_story_bold_italic?.AddFont(_noto_sans_regular_);
			this._SPB_bold?.AddFont(_SPB_bold_);
			this._SPB_bold?.AddFont(_noto_sans_regular_);
			this._SPB_regular?.AddFont(_SPB_regular_);
			this._SPB_regular?.AddFont(_noto_sans_regular_);
			this._noto_sans_regular?.AddFont(_noto_sans_regular_);
			this._noto_sans_regular?.AddFont(_SPB_bold_);
			//---------------------------------------------
			//localFunctions:
			FontSystem _generate()
			{
				return FontSystemFactory.CreateStroked(this.Client.GraphicsDevice, 
					STROKE_AMOUNT, 
					this.GraphicsLevel * FontBitmapWidth,
					this.GraphicsLevel * FontBitmapHeight);;
			}
			//---------------------------------------------
		}
		#endregion
		//-------------------------------------------------
		#region Ordinary Method's Region
		public void Dispose()
		{
			if (this.MyRes != null)
			{
				this.MyRes = null;
			}
			#if (OLD_SPB)
			if (this._collection != null)
			{
				this._collection = null;
			}
			#endif
		}
		public bool Contains(char c)
		{
			for (int i = 0; i < _ranges.Length; i++)
			{
				if (_ranges[i].Contains(c))
				{
					return true;
				}
			}	
			return false;
		}
		#endregion
		//-------------------------------------------------
		#region Get Method's Region
		/// <summary>
		/// Get a byte array from the resource manager with 
		/// the specified name.
		/// </summary>
		private byte[] _fromRes(string _name)
		{
			if (this.MyRes != null && _name != null)
			{
				return this.MyRes.GetBytes(_name);
			}
			return null;
		}
		private CharacterRange[] _getRanges()
		{
			return new[] 
			{
				CharacterRange.BasicLatin,
				CharacterRange.Latin1Supplement,
				CharacterRange.LatinExtendedA,
				CharacterRange.LatinExtendedB,
				CharacterRange.Cyrillic,
				CharacterRange.CyrillicSupplement,
				CharacterRange.Hiragana,
				CharacterRange.Katakana,
				CharacterRange.Kanji,
			};
			
		}
		#endregion
		//-------------------------------------------------
	}
}