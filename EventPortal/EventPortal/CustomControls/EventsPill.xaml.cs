using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventPortal.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventsPill : Frame
	{
		public EventsPill ()
		{
			InitializeComponent ();
		}
        public static readonly BindableProperty UpperRightTextProperty = BindableProperty.Create(
           propertyName: nameof(UpperRightText),
           returnType: typeof(string),
           declaringType: typeof(EventsPill),
           defaultValue: String.Empty,
           defaultBindingMode: BindingMode.TwoWay
           );
        public string UpperRightText
        {
            get
            { return (string)GetValue(UpperRightTextProperty); }
            set
            {
                SetValue(UpperRightTextProperty, value);
            }
        }
        public static readonly BindableProperty LeftImageProperty = BindableProperty.Create(
           propertyName: nameof(LeftImage),
           returnType: typeof(string),
           declaringType: typeof(EventsPill),
           defaultValue: String.Empty,
           defaultBindingMode: BindingMode.TwoWay
           );
        public string LeftImage
        {
            get
            { return (string)GetValue(LeftImageProperty); }
            set
            {
                SetValue(LeftImageProperty, value);
            }
        }

        public static readonly BindableProperty HeadingTextProperty = BindableProperty.Create(
           propertyName: nameof(HeadingText),
           returnType: typeof(string),
           declaringType: typeof(EventsPill),
           defaultValue: String.Empty,
           defaultBindingMode: BindingMode.TwoWay
           );
        public string HeadingText
        {
            get
            { return (string)GetValue(HeadingTextProperty); }
            set
            {
                SetValue(HeadingTextProperty, value);
            }
        }
        public static readonly BindableProperty SubHeadingTextProperty = BindableProperty.Create(
           propertyName: nameof(SubHeadingText),
           returnType: typeof(string),
           declaringType: typeof(EventsPill),
           defaultValue: String.Empty,
           defaultBindingMode: BindingMode.TwoWay
           );
        public string SubHeadingText
        {
            get
            { return (string)GetValue(SubHeadingTextProperty); }
            set
            {
                SetValue(SubHeadingTextProperty, value);
            }
        }
        public static readonly BindableProperty LeftBottomTextProperty = BindableProperty.Create(
           propertyName: nameof(LeftBottomText),
           returnType: typeof(string),
           declaringType: typeof(EventsPill),
           defaultValue: String.Empty,
           defaultBindingMode: BindingMode.TwoWay
           );
        public string LeftBottomText
        {
            get
            { return (string)GetValue(LeftBottomTextProperty); }
            set
            {
                SetValue(LeftBottomTextProperty, value);
            }
        }
        public static readonly BindableProperty RightBottomTextProperty = BindableProperty.Create(
           propertyName: nameof(RightBottomText),
           returnType: typeof(string),
           declaringType: typeof(EventsPill),
           defaultValue: String.Empty,
           defaultBindingMode: BindingMode.TwoWay
           );
        public string RightBottomText
        {
            get
            { return (string)GetValue(RightBottomTextProperty); }
            set
            {
                SetValue(RightBottomTextProperty, value);
            }
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == UpperRightTextProperty.PropertyName)
            {
                //UpperRightLabel.Text = UpperRightText;
            }
            if (propertyName == LeftImageProperty.PropertyName)
            {
                LeftImg.Source = LeftImage;
            }
            if (propertyName == HeadingTextProperty.PropertyName)
            {
                Headinglbl.Text = HeadingText;
            }
            if (propertyName == SubHeadingTextProperty.PropertyName)
            {
                SubHeadinglbl.Text = SubHeadingText;
            }
            if (propertyName == LeftBottomTextProperty.PropertyName)
            {
                LeftBottomlbl.Text = LeftBottomText;
            }
            if (propertyName == RightBottomTextProperty.PropertyName)
            {
                RightBottomlbl.Text = RightBottomText;
            }
        }

    }
}