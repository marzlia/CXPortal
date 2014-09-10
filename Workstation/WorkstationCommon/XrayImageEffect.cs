﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace L3.Cargo.Workstation.Common {
	
	public class XrayImageEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(XrayImageEffect), 0);
		public static readonly DependencyProperty LowerBoundColorProperty = DependencyProperty.Register("LowerBoundColor", typeof(Color), typeof(XrayImageEffect), new UIPropertyMetadata(Color.FromArgb(255, 0, 0, 255), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty UpperBoundColorProperty = DependencyProperty.Register("UpperBoundColor", typeof(Color), typeof(XrayImageEffect), new UIPropertyMetadata(Color.FromArgb(255, 0, 128, 0), PixelShaderConstantCallback(1)));
		public static readonly DependencyProperty LowerBoundProperty = DependencyProperty.Register("LowerBound", typeof(double), typeof(XrayImageEffect), new UIPropertyMetadata(((double)(0D)), PixelShaderConstantCallback(2)));
		public static readonly DependencyProperty UpperBoundProperty = DependencyProperty.Register("UpperBound", typeof(double), typeof(XrayImageEffect), new UIPropertyMetadata(((double)(1D)), PixelShaderConstantCallback(3)));
		public static readonly DependencyProperty EnableLogProperty = DependencyProperty.Register("EnableLog", typeof(double), typeof(XrayImageEffect), new UIPropertyMetadata(((double)(0D)), PixelShaderConstantCallback(4)));
		public static readonly DependencyProperty EnableSquarerootProperty = DependencyProperty.Register("EnableSquareroot", typeof(double), typeof(XrayImageEffect), new UIPropertyMetadata(((double)(0D)), PixelShaderConstantCallback(5)));
		public static readonly DependencyProperty EnableSquareProperty = DependencyProperty.Register("EnableSquare", typeof(double), typeof(XrayImageEffect), new UIPropertyMetadata(((double)(0D)), PixelShaderConstantCallback(6)));
		public XrayImageEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/L3.Cargo.Workstation.Common;component/XrayImage.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(LowerBoundColorProperty);
			this.UpdateShaderValue(UpperBoundColorProperty);
			this.UpdateShaderValue(LowerBoundProperty);
			this.UpdateShaderValue(UpperBoundProperty);
			this.UpdateShaderValue(EnableLogProperty);
			this.UpdateShaderValue(EnableSquarerootProperty);
			this.UpdateShaderValue(EnableSquareProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		public Color LowerBoundColor {
			get {
				return ((Color)(this.GetValue(LowerBoundColorProperty)));
			}
			set {
				this.SetValue(LowerBoundColorProperty, value);
			}
		}
		public Color UpperBoundColor {
			get {
				return ((Color)(this.GetValue(UpperBoundColorProperty)));
			}
			set {
				this.SetValue(UpperBoundColorProperty, value);
			}
		}
		/// <summary>The lowest pixel value allowed to be displayed.</summary>
		public double LowerBound {
			get {
				return ((double)(this.GetValue(LowerBoundProperty)));
			}
			set {
				this.SetValue(LowerBoundProperty, value);
			}
		}
		/// <summary>The highest pixel value allowed to be displayed.</summary>
		public double UpperBound {
			get {
				return ((double)(this.GetValue(UpperBoundProperty)));
			}
			set {
				this.SetValue(UpperBoundProperty, value);
			}
		}
		/// <summary>Enable of Disable Log curve.</summary>
		public double EnableLog {
			get {
				return ((double)(this.GetValue(EnableLogProperty)));
			}
			set {
				this.SetValue(EnableLogProperty, value);
			}
		}
		/// <summary>Enable of Disable Squareroot curve.</summary>
		public double EnableSquareroot {
			get {
				return ((double)(this.GetValue(EnableSquarerootProperty)));
			}
			set {
				this.SetValue(EnableSquarerootProperty, value);
			}
		}
		/// <summary>Enable of Disable Square curve.</summary>
		public double EnableSquare {
			get {
				return ((double)(this.GetValue(EnableSquareProperty)));
			}
			set {
				this.SetValue(EnableSquareProperty, value);
			}
		}
	}
}