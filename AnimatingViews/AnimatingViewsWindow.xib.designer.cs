// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AnimatingViews {
	
	
	// Should subclass MonoMac.AppKit.NSWindow
	[Foundation.Register("AnimatingViewsWindow")]
	public partial class AnimatingViewsWindow {
		
		private global::AppKit.NSView __mt_simpleLayoutView;
		
		#pragma warning disable 0169
		[Foundation.Connect("simpleLayoutView")]
		private global::AppKit.NSView simpleLayoutView {
			get {
				this.__mt_simpleLayoutView = ((global::AppKit.NSView)(this.GetNativeField("simpleLayoutView")));
				return this.__mt_simpleLayoutView;
			}
			set {
				this.__mt_simpleLayoutView = value;
				this.SetNativeField("simpleLayoutView", value);
			}
		}
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[Foundation.Register("AnimatingViewsWindowController")]
	public partial class AnimatingViewsWindowController {
		
		private global::AppKit.NSColorWell __mt_colorWell;
		
		private global::AppKit.NSView __mt_simpleView;
		
		#pragma warning disable 0169
		[Foundation.Export("addABox:")]
		partial void addABox (AppKit.NSButton sender);

		[Foundation.Export("changeLayout:")]
		partial void changeLayout (AppKit.NSMatrix sender);

		[Foundation.Export("removeLastBox:")]
		partial void removeLastBox (AppKit.NSButton sender);

		[Foundation.Connect("colorWell")]
		private global::AppKit.NSColorWell colorWell {
			get {
				this.__mt_colorWell = ((global::AppKit.NSColorWell)(this.GetNativeField("colorWell")));
				return this.__mt_colorWell;
			}
			set {
				this.__mt_colorWell = value;
				this.SetNativeField("colorWell", value);
			}
		}
		
		[Foundation.Connect("simpleView")]
		private global::AppKit.NSView simpleView {
			get {
				this.__mt_simpleView = ((global::AppKit.NSView)(this.GetNativeField("simpleView")));
				return this.__mt_simpleView;
			}
			set {
				this.__mt_simpleView = value;
				this.SetNativeField("simpleView", value);
			}
		}
	}
}
