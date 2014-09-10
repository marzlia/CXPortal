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


namespace L3.Cargo.Workstation.Plugins.XRayImageBase {
	
	public class TrimatEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(TrimatEffect), 0);
		public static readonly DependencyProperty ColorMappingProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("ColorMapping", typeof(TrimatEffect), 1);
		public TrimatEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri(@"/L3.Cargo.Workstation.Plugins.XRayImageBase;component/Effects/Trimat.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(ColorMappingProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		public Brush ColorMapping {
			get {
				return ((Brush)(this.GetValue(ColorMappingProperty)));
			}
			set {
				this.SetValue(ColorMappingProperty, value);
			}
		}
	}
}