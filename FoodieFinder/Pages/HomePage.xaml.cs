using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class HomePage : ContentPage
{
	private HomePageViewModel _viewModel;

	public HomePage()
	{
		InitializeComponent();

        //_viewModel = new();
        //BindingContext = _viewModel;

        graphicsView.Drawable = new DrawableClass();
	}
}

class DrawableClass : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {

        // View:     frameView
        // NodeName: MAIN
        // NodeType: FRAME
        // NodeId:   65:1254
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(222f, -443f, 389f, 840f, 0f);
        canvas.RestoreState();


        // View:     frameView1
        // NodeName: MAIN
        // NodeType: FRAME
        // NodeId:   65:1255
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(63, 78, 79);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(222f, -445f, 389f, 841.83594f, 39.897427f);
        canvas.RestoreState();


        // View:     frameView2
        // NodeName: Frame 7
        // NodeType: FRAME
        // NodeId:   65:1256
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView3
        // NodeName: Frame 6
        // NodeType: FRAME
        // NodeId:   65:1257
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView4
        // NodeName: Frame 5
        // NodeType: FRAME
        // NodeId:   65:1258
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView
        // NodeName: Welcome, Robert
        // NodeType: TEXT
        // NodeId:   65:1259
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(149, 149, 149);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.958971977233887f;
        canvas.DrawString(@"Welcome, Robert", 248f, -387.0692f, 139f, 26f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView5
        // NodeName: chevron-down
        // NodeType: FRAME
        // NodeId:   65:1260
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView
        // NodeName: Ellipse 1
        // NodeType: VECTOR
        // NodeId:   65:1261
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(217, 217, 217);
        canvas.Alpha = 1;
        canvas.Translate(525.64355f, -401f);
        var vector0Builder = new PathBuilder();
        var vector0path = vector0Builder.BuildPath("M53.8615 26.9308C53.8615 41.8042 41.8042 53.8615 26.9308 53.8615C12.0573 53.8615 0 41.8042 0 26.9308C0 12.0573 12.0573 0 26.9308 0C41.8042 0 53.8615 12.0573 53.8615 26.9308Z");
        canvas.FillPath(vector0path);
        canvas.RestoreState();


        // View:     textView1
        // NodeName: Categories:
        // NodeType: TEXT
        // NodeId:   65:1262
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.958971977233887f;
        canvas.DrawString(@"Categories:", 248f, -317f, 94f, 26f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView6
        // NodeName: Frame 14
        // NodeType: FRAME
        // NodeId:   65:1263
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView7
        // NodeName: Frame 11
        // NodeType: FRAME
        // NodeId:   65:1264
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(247, 237, 227);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(245f, -272.11798f, 118.86667f, 51.93846f, 15.823729f);
        canvas.RestoreState();


        // View:     frameView8
        // NodeName: Frame 8
        // NodeType: FRAME
        // NodeId:   65:1265
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView9
        // NodeName: Pizza
        // NodeType: FRAME
        // NodeId:   72:1074
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView1
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1075
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(242, 192, 90);
        canvas.Alpha = 1;
        canvas.Translate(269.6535f, -243.85695f);
        var vector1Builder = new PathBuilder();
        var vector1path = vector1Builder.BuildPath("M0 0.0514154L0 2.9678L23.1134 2.9678C23.7632 2.9678 24.2589 0 24.2589 0L0 0.0514154Z");
        canvas.FillPath(vector1path);
        canvas.RestoreState();


        // View:     imageView2
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1076
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(268.93845f, -244.57034f);
        var vector2Builder = new PathBuilder();
        var vector2path = vector2Builder.BuildPath("M0.714764 4.39458C0.314191 4.39458 0 4.08112 0 3.68119L0 0.764517C0 0.371303 0.320633 0.0514153 0.714764 0.0514153L24.991 0C25.1927 0 25.4015 0.0955281 25.5227 0.243348C25.6621 0.410157 25.7157 0.612899 25.675 0.81564C25.0826 4.39458 24.184 4.39458 23.8458 4.39458L0.714764 4.39458ZM23.6285 2.98503L23.6765 2.88892C23.7848 2.67274 23.9099 2.28917 24.0821 1.64501L24.1406 1.4262L1.4468 1.4782L1.4468 2.98503L1.62074 2.98503L23.6285 2.98503Z");
        canvas.FillPath(vector2path);
        canvas.RestoreState();


        // View:     imageView3
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1077
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 222, 138);
        canvas.Alpha = 1;
        canvas.Translate(269.67047f, -258.3878f);
        var vector3Builder = new PathBuilder();
        var vector3path = vector3Builder.BuildPath("M18.019 0.152547C17.5233 -0.103363 16.9078 -0.0350035 16.4975 0.34039L0 14.5823L3.0775 14.5823L3.0775 22.7863C3.0775 23.7585 3.86371 24.5429 4.8382 24.5429C5.81269 24.5429 6.5989 23.7585 6.5989 22.7863L6.5989 14.5823L8.42812 14.5823L8.42812 18.4539C8.42812 19.4431 9.24859 20.2619 10.2404 20.2619C11.2318 20.2619 12.0526 19.4434 12.0526 18.4539L12.0526 14.5823L14.6683 14.5823C14.9248 15.5545 15.7968 16.2708 16.8395 16.2708C17.8826 16.2708 18.7713 15.5545 19.0108 14.5823L24.2762 14.5653C25.9341 5.13315 20.2585 1.27843 18.019 0.152547Z");
        canvas.FillPath(vector3path);
        canvas.RestoreState();


        // View:     imageView4
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1078
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 92, 92);
        canvas.Alpha = 1;
        canvas.Translate(280.5606f, -255.4208f);
        var vector4Builder = new PathBuilder();
        var vector4path = vector4Builder.BuildPath("M1.69248 3.39402C2.70093 3.39402 3.50471 2.5924 3.50471 1.586C3.50471 0.886629 3.11146 0.306742 2.5472 0L0 2.20007C0.256507 2.89944 0.905972 3.39402 1.69248 3.39402Z");
        canvas.FillPath(vector4path);
        canvas.RestoreState();


        // View:     imageView5
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1079
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(280.1955f, -255.78577f);
        var vector5Builder = new PathBuilder();
        var vector5path = vector5Builder.BuildPath("M2.05758 4.11714C1.15132 4.11714 0.330846 3.53725 0.023096 2.68451C-0.0281467 2.54808 0.00582058 2.39471 0.125582 2.29247L2.67279 0.0921065C2.77527 -0.0101407 2.94628 -0.0273765 3.06575 0.0409831C3.78373 0.416376 4.21124 1.14963 4.21124 1.93431C4.22881 3.14492 3.25432 4.11714 2.05758 4.11714ZM0.792324 2.66757C1.04883 3.12826 1.52758 3.41806 2.05758 3.41806C2.86107 3.41806 3.51083 2.77011 3.51083 1.9682C3.51083 1.50779 3.28858 1.08128 2.92929 0.808421L0.792324 2.66757Z");
        canvas.FillPath(vector5path);
        canvas.RestoreState();


        // View:     imageView6
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1080
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 92, 92);
        canvas.Alpha = 1;
        canvas.Translate(288.21152f, -251.7367f);
        var vector6Builder = new PathBuilder();
        var vector6path = vector6Builder.BuildPath("M0.0422323 1.26202C-0.163031 2.132 0.401225 3.01892 1.27294 3.20647C1.88844 3.3429 2.48666 3.12117 2.86293 2.67771L1.42696 0C0.760217 0.0853034 0.19596 0.562652 0.0422323 1.26202Z");
        canvas.FillPath(vector6path);
        canvas.RestoreState();


        // View:     imageView7
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1081
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(287.86398f, -252.08017f);
        var vector7Builder = new PathBuilder();
        var vector7path = vector7Builder.BuildPath("M1.97948 3.94228C1.84273 3.94228 1.689 3.92534 1.55226 3.89116C0.492265 3.65248 -0.19146 2.59495 0.0477708 1.52048C0.235759 0.718864 0.9025 0.104797 1.74025 0.00254956C1.87699 -0.0143943 2.03101 0.0536732 2.09924 0.1901L3.53521 2.85086C3.60373 2.98729 3.58645 3.14066 3.48396 3.2432C3.09071 3.68637 2.54373 3.94228 1.97948 3.94228ZM0.731495 1.67385C0.662976 2.01507 0.714512 2.35599 0.902207 2.62884C1.09049 2.91864 1.36398 3.12343 1.70569 3.19179C2.08196 3.27709 2.47492 3.17484 2.78267 2.93587L1.60321 0.735808C1.15901 0.889179 0.833981 1.2301 0.731495 1.67385Z");
        canvas.FillPath(vector7path);
        canvas.RestoreState();


        // View:     imageView8
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1082
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(268.9478f, -259.10403f);
        var vector8Builder = new PathBuilder();
        var vector8path = vector8Builder.BuildPath("M5.54359 25.9553C4.17848 25.9553 3.06754 24.8472 3.06754 23.485L3.06754 15.9944L0.705392 15.9944C0.400864 15.9944 0.143478 15.8136 0.0497772 15.5334C-0.0626641 15.2515 0.01991 14.9407 0.25182 14.7499L16.7526 0.505393C17.135 0.179955 17.6199 0 18.1174 0C18.4451 0 18.761 0.0747865 19.0568 0.222607C21.0602 1.23018 27.46 5.29962 25.682 15.3534C25.6278 15.6909 25.3268 15.9433 24.9813 15.9433L20.2078 15.9608L20.1595 16.0543C19.6503 17.0379 18.6483 17.649 17.5447 17.649C16.4413 17.649 15.4393 17.0382 14.9298 16.0543L14.8809 15.9602L13.4728 15.9602L13.4728 19.1188C13.4728 20.4997 12.3469 21.6229 10.9627 21.6229C9.57859 21.6229 8.45301 20.4997 8.45301 19.1191L8.45301 15.9605L8.03633 15.9605L8.03633 23.4511C8.02052 24.8312 6.90226 25.9553 5.54359 25.9553ZM18.0998 1.42766C17.9388 1.42766 17.7897 1.48434 17.6685 1.59184L2.61455 14.5851L3.78259 14.5851C3.98083 14.5851 4.15359 14.6555 4.26867 14.7835C4.40951 14.9243 4.48037 15.1002 4.48037 15.2985L4.48037 23.5025C4.48037 24.0874 4.95737 24.5633 5.5433 24.5633C6.13947 24.5633 6.60622 24.0973 6.60622 23.5025L6.60622 15.2982C6.60622 14.905 6.92685 14.5851 7.32098 14.5851L9.1502 14.5851C9.34815 14.5851 9.52091 14.6555 9.63628 14.7835C9.77712 14.9243 9.84798 15.1002 9.84798 15.2985L9.84798 19.1702C9.84798 19.7737 10.3402 20.2648 10.9452 20.2648C11.5501 20.2648 12.0423 19.7737 12.0423 19.1702L12.0423 15.2813C12.0423 14.8878 12.363 14.5679 12.7571 14.5679L15.3728 14.5679C15.6996 14.5679 15.9754 14.7832 16.0592 15.1034C16.234 15.7823 16.8448 16.2567 17.5441 16.2567C18.2433 16.2567 18.8541 15.7823 19.0289 15.1031C19.1127 14.7835 19.3885 14.5682 19.715 14.5682L24.3799 14.5507L24.4006 14.4017C25.5652 6.08459 20.5993 2.6076 18.4102 1.49865C18.3042 1.45045 18.202 1.42766 18.0998 1.42766Z");
        canvas.FillPath(vector8path);
        canvas.RestoreState();


        // View:     imageView9
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1083
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 176, 123);
        canvas.Alpha = 1;
        canvas.Translate(284.954f, -258.42035f);
        var vector9Builder = new PathBuilder();
        var vector9path = vector9Builder.BuildPath("M8.97539 14.5634C10.6851 4.96092 4.73571 1.15733 2.59874 0.117035C2.17123 -0.0877516 1.65822 -0.0193921 1.29922 0.287642L0 1.41353C2.83797 3.52829 7.60765 7.43443 6.1544 14.5809L8.97539 14.5634Z");
        canvas.FillPath(vector9path);
        canvas.RestoreState();


        // View:     imageView10
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1084
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(284.2204f, -259.14874f);
        var vector10Builder = new PathBuilder();
        var vector10path = vector10Builder.BuildPath("M6.8883 16.0052C6.6807 16.0052 6.47485 15.9073 6.3384 15.7434C6.20224 15.5807 6.14572 15.361 6.18701 15.1551C7.43851 8.98227 3.90861 5.39573 0.290871 2.70166C0.119867 2.58335 0.0162103 2.38294 0.00127666 2.14778C-0.0119001 1.93569 0.0774092 1.73324 0.246657 1.59272L1.54852 0.464494C1.89609 0.165056 2.3356 0 2.78596 0C3.07233 0 3.35783 0.0686517 3.61228 0.19836C5.65848 1.19396 12.1842 5.22892 10.3755 15.4151C10.3213 15.7528 10.0203 16.0052 9.67504 16.0052L6.8883 16.0052L6.8883 16.0052ZM2.79591 1.42766C2.67791 1.42766 2.56195 1.47031 2.46854 1.54802L1.84719 2.0987L2.01116 2.22694C3.65093 3.51175 8.6411 7.42169 7.74128 14.3827L7.7161 14.5784L9.09145 14.5784L9.11224 14.4288C10.2984 5.95312 5.23097 2.54537 2.99737 1.47353C2.93793 1.44402 2.86765 1.42766 2.79591 1.42766Z");
        canvas.FillPath(vector10path);
        canvas.RestoreState();


        // View:     imageView11
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1085
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(226, 128, 61);
        canvas.Alpha = 1;
        canvas.Translate(290.27097f, -243.85695f);
        var vector11Builder = new PathBuilder();
        var vector11path = vector11Builder.BuildPath("M0.837746 0C0.837746 0 0.683725 1.87609 0 2.9678L2.51295 2.9678C2.51295 2.9678 3.40194 2.49016 3.65844 0L0.837746 0Z");
        canvas.FillPath(vector11path);
        canvas.RestoreState();


        // View:     imageView12
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1086
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(289.56262f, -244.5531f);
        var vector12Builder = new PathBuilder();
        var vector12path = vector12Builder.BuildPath("M0.708337 4.37735C0.445095 4.37735 0.215236 4.23975 0.0928386 4.00926C-0.035122 3.78169 -0.0301433 3.50971 0.103674 3.29557C0.595897 2.49571 0.798526 1.07564 0.830736 0.640943C0.857382 0.281325 1.16425 0 1.5291 0L4.3498 0C4.55916 0 4.74656 0.0823814 4.86486 0.226404C5.0139 0.390292 5.07569 0.577842 5.04904 0.775618C4.75915 3.51643 3.73547 4.18834 3.53313 4.29526C3.45114 4.34872 3.3349 4.37735 3.22128 4.37735L0.708337 4.37735L0.708337 4.37735ZM2.16158 1.54919C2.09394 1.8869 2.00961 2.30728 1.8755 2.74315L1.8064 2.9678L2.95306 2.9678L3.00519 2.8936C3.1229 2.72562 3.34544 2.33708 3.51088 1.62222L3.56007 1.40955L2.18969 1.40955L2.16158 1.54919Z");
        canvas.FillPath(vector12path);
        canvas.RestoreState();


        // View:     imageView13
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1087
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 92, 92);
        canvas.Alpha = 1;
        canvas.Translate(277.53464f, -248.5983f);
        var vector13Builder = new PathBuilder();
        var vector13path = vector13Builder.BuildPath("M0 1.17672C0 1.82672 0.527946 2.35344 1.17946 2.35344C1.83098 2.35344 2.35892 1.82672 2.35892 1.17672C2.35892 0.526719 1.83098 0 1.17946 0C0.527946 0 0 0.526719 0 1.17672Z");
        canvas.FillPath(vector13path);
        canvas.RestoreState();


        // View:     imageView14
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1088
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(277.17535f, -248.95645f);
        var vector14Builder = new PathBuilder();
        var vector14path = vector14Builder.BuildPath("M1.53875 3.07004C0.701001 3.07004 0 2.38791 0 1.53517C0 0.682427 0.683725 0 1.53875 0C2.39348 0 3.0772 0.682135 3.0772 1.53517C3.0772 2.38762 2.39348 3.07004 1.53875 3.07004ZM1.53875 0.716315C1.07727 0.716315 0.718278 1.09171 0.718278 1.53488C0.718278 1.97834 1.09425 2.35344 1.53875 2.35344C1.98324 2.35344 2.35922 1.97805 2.35922 1.53488C2.35922 1.09142 2.00023 0.716315 1.53875 0.716315Z");
        canvas.FillPath(vector14path);
        canvas.RestoreState();


        // View:     imageView15
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1089
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(61, 226, 92);
        canvas.Alpha = 1;
        canvas.Translate(281.79132f, -247.31934f);
        var vector15Builder = new PathBuilder();
        var vector15path = vector15Builder.BuildPath("M2.73548 1.07477L0.256506 1.07477C0.119761 1.07477 0 0.955282 0 0.818855L0 0.25591C0 0.119483 0.119761 0 0.256506 0L2.73548 0C2.87223 0 2.99199 0.119483 2.99199 0.25591L2.99199 0.818855C3.00897 0.955282 2.88921 1.07477 2.73548 1.07477Z");
        canvas.FillPath(vector15path);
        canvas.RestoreState();


        // View:     imageView16
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1090
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(281.4496f, -247.66025f);
        var vector16Builder = new PathBuilder();
        var vector16path = vector16Builder.BuildPath("M2.80371 1.77384L0.888989 1.77384C0.393252 1.77384 0 1.3815 0 0.886921C0 0.392337 0.393252 0 0.888989 0L2.80371 0C3.29945 0 3.6927 0.392337 3.6927 0.886921C3.6927 1.3815 3.29945 1.77384 2.80371 1.77384ZM0.888989 0.699079C0.786503 0.699079 0.701001 0.784382 0.701001 0.886629C0.701001 0.989168 0.786503 1.07447 0.888989 1.07447L2.80371 1.07447C2.9062 1.07447 2.9917 0.989168 2.9917 0.886629C2.9917 0.784382 2.9062 0.699079 2.80371 0.699079L0.888989 0.699079Z");
        canvas.FillPath(vector16path);
        canvas.RestoreState();


        // View:     imageView17
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1091
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(61, 226, 92);
        canvas.Alpha = 1;
        canvas.Translate(284.88132f, -251.02455f);
        var vector17Builder = new PathBuilder();
        var vector17path = vector17Builder.BuildPath("M1.35493 2.20423L0.0384321 0.771601C-0.0128107 0.720477 -0.0128107 0.635174 0.0384321 0.58405L0.636654 0.0383427C0.687897 -0.0127809 0.7734 -0.0127809 0.824935 0.0383427L2.14143 1.47097C2.19268 1.5221 2.19268 1.6074 2.14143 1.65852L1.54321 2.20423C1.50866 2.25565 1.40617 2.25565 1.35493 2.20423Z");
        canvas.FillPath(vector17path);
        canvas.RestoreState();


        // View:     imageView18
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1092
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(284.57834f, -251.31047f);
        var vector18Builder = new PathBuilder();
        var vector18path = vector18Builder.BuildPath("M1.77769 2.83137L1.74372 2.83137C1.57271 2.83137 1.41869 2.74607 1.29922 2.62658L0.171004 1.41569C0.0512426 1.2962 0 1.12589 0 0.955281C0 0.784967 0.0855023 0.631304 0.205264 0.511821L0.581239 0.170607C0.701001 0.0511241 0.872005 0 1.04301 0C1.21401 0 1.36774 0.0853034 1.4875 0.204787L2.61572 1.41569C2.73549 1.53517 2.78673 1.70578 2.78673 1.87638C2.78673 2.04699 2.70123 2.20036 2.58146 2.31984L2.20549 2.66106C2.08543 2.76301 1.93141 2.83137 1.77769 2.83137ZM0.751951 0.972225L1.77769 2.08088L2.05117 1.82497L1.02544 0.716315L0.751951 0.972225Z");
        canvas.FillPath(vector18path);
        canvas.RestoreState();


        // View:     textView2
        // NodeName: Dishes
        // NodeType: TEXT
        // NodeId:   65:1267
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 11.969229698181152f;
        canvas.DrawString(@"Dishes", 298.9282f, -260.14874f, 41f, 28f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView10
        // NodeName: Group 1
        // NodeType: GROUP
        // NodeId:   65:1268
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView19
        // NodeName: Rectangle 5
        // NodeType: VECTOR
        // NodeId:   65:1269
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(220, 215, 201);
        canvas.Alpha = 1;
        canvas.Translate(221.99998f, 321.03082f);
        var vector19Builder = new PathBuilder();
        var vector19path = vector19Builder.BuildPath("M0 0L148.149 0C153.688 0 158.503 3.80005 159.79 9.18701L162.838 21.9399C170.926 55.7808 219.148 55.5651 226.933 21.6533L229.771 9.29123C231.019 3.85397 235.858 0 241.437 0L389 0L389 79.6214L0 79.6214L0 0Z");
        canvas.FillPath(vector19path);
        canvas.RestoreState();


        // View:     elipseView
        // NodeName: Ellipse 5
        // NodeType: ELLIPSE
        // NodeId:   65:1270
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.FillEllipse(387.57446f, 299f, 57.851288f, 57.851288f);
        canvas.RestoreState();


        // View:     frameView11
        // NodeName: vuesax/linear/message
        // NodeType: COMPONENT
        // NodeId:   65:1271
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView
        // NodeName: 2729063 1
        // NodeType: RECTANGLE
        // NodeId:   65:1272
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView12
        // NodeName: Status Bar, Time, Date
        // NodeType: GROUP
        // NodeId:   65:1278
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView20
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1280
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(348.33594f, -327.22656f);
        var vector20Builder = new PathBuilder();
        var vector20path = vector20Builder.BuildPath("M1.40625 45C1.28906 44.375 1.64062 44.0625 2.10938 44.0625L4.02344 44.0625C4.60938 44.0625 4.84375 44.3359 5 44.8047C6.32812 50.5469 11.5625 54.8828 18.9062 54.8828C29.6094 54.8828 35.7812 44.8438 36.2891 28.8281C36.3281 27.7734 36.2891 26.4844 36.2891 25.3516L36.1719 25.3516C34.3359 32.3047 27.0703 37.7344 18.7109 37.7344C7.92969 37.7344 0 29.8438 0 19.4141C0 8.32031 8.08594 0 19.1406 0C25.7031 0 31.1328 2.96875 34.6094 8.04688C37.9688 12.6562 39.7266 19.1797 39.7266 27.6172C39.7266 46.2891 31.9141 58.0469 18.9062 58.0469C9.6875 58.0469 3.08594 52.6953 1.40625 45Z");
        canvas.FillPath(vector20path);
        canvas.RestoreState();


        // View:     imageView21
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1281
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(351.89062f, -323.98438f);
        var vector21Builder = new PathBuilder();
        var vector21path = vector21Builder.BuildPath("M31.4453 16.4062C31.4453 7.30469 24.6094 0 15.625 0C6.71875 0 0 6.95312 0 16.0938C0 24.5312 6.48438 31.3281 15.5469 31.3281C24.3359 31.3281 31.4453 24.375 31.4453 16.4062Z");
        canvas.FillPath(vector21path);
        canvas.RestoreState();


        // View:     imageView22
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1282
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(398.33594f, -315.8203f);
        var vector22Builder = new PathBuilder();
        var vector22path = vector22Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.33594 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.33594 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector22path);
        canvas.RestoreState();


        // View:     imageView23
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1283
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(398.33594f, -285.7422f);
        var vector23Builder = new PathBuilder();
        var vector23path = vector23Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.375 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.375 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector23path);
        canvas.RestoreState();


        // View:     imageView24
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1284
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(413.53125f, -326.52344f);
        var vector24Builder = new PathBuilder();
        var vector24path = vector24Builder.BuildPath("M28.9453 55.625L28.9453 42.6953L0.898438 42.6953C0.351562 42.6953 0 42.3438 0 41.7969L0 39.8438C0 39.4922 0.078125 39.2578 0.273438 38.9453C7.85156 27.1094 16.0547 15.2734 26.8359 0.625C27.1484 0.234375 27.3828 0 27.9688 0L31.5234 0C32.0312 0 32.3828 0.351562 32.3828 0.898438L32.3828 39.4922L40.3516 39.4922C40.8984 39.4922 41.25 39.8438 41.25 40.3906L41.25 41.7969C41.25 42.3438 40.8984 42.6953 40.3516 42.6953L32.3828 42.6953L32.3828 55.625C32.3828 56.1719 32.0312 56.5234 31.5234 56.5234L29.8438 56.5234C29.2969 56.5234 28.9453 56.1719 28.9453 55.625Z");
        canvas.FillPath(vector24path);
        canvas.RestoreState();


        // View:     imageView25
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1285
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(417.3203f, -323.125f);
        var vector25Builder = new PathBuilder();
        var vector25path = vector25Builder.BuildPath("M0 36.0938L25.1562 36.0938L25.1562 0L25.0781 0C15.3906 13.0469 7.03125 25.1172 0 36.0156L0 36.0938Z");
        canvas.FillPath(vector25path);
        canvas.RestoreState();


        // View:     imageView26
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1286
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(459.39062f, -326.3672f);
        var vector26Builder = new PathBuilder();
        var vector26path = vector26Builder.BuildPath("M15.4297 55.4688L15.4297 3.94531L15.3516 3.94531C11.9922 6.05469 5.46875 10.3906 1.28906 13.0859C0.78125 13.4375 0 13.2812 0 12.5781L0 10.8203C0 10.1562 0.15625 9.96094 0.625 9.64844C4.60938 7.03125 10.4688 3.125 14.7266 0.46875C15.1562 0.195312 15.5078 0 16.1328 0L18.0078 0C18.5547 0 18.9062 0.351562 18.9062 0.898438L18.9062 55.4688C18.9062 56.0156 18.5547 56.3672 18.0078 56.3672L16.3281 56.3672C15.7812 56.3672 15.4297 56.0156 15.4297 55.4688Z");
        canvas.FillPath(vector26path);
        canvas.RestoreState();


        // View:     textView3
        // NodeName: 9 41
        // NodeType: TEXT
        // NodeId:   65:1287
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"9 41", 338f, -348f, 144f, 99f, HorizontalAlignment.Right, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     frameView13
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   65:1288
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView14
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   I65:1288;362:15667
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView15
        // NodeName: Notch
        // NodeType: GROUP
        // NodeId:   I65:1288;362:15667;362:15633
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView1
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1288;362:15667;362:15634
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(222f, -445f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     rectangleView2
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1288;362:15667;362:15636
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(214, 217, 221);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(222f, -445f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     imageView27
        // NodeName: Notch
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15637
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(307f, -447f);
        var vector27Builder = new PathBuilder();
        var vector27path = vector27Builder.BuildPath("M0 0L219 0L219 0C216.894 0.602689 215.418 2.49525 215.345 4.68446L215.317 5.5618L215.317 5.5618C215.317 19.0587 204.375 30 190.878 30L28.1217 30C14.6249 30 3.68349 19.0587 3.68349 5.5618L3.68349 5.5618L3.65455 4.68447C3.58233 2.49525 2.10586 0.602689 0 0L0 0Z");
        canvas.FillPath(vector27path);
        canvas.RestoreState();


        // View:     frameView16
        // NodeName: Right Side
        // NodeType: GROUP
        // NodeId:   I65:1288;362:15667;362:15638
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView17
        // NodeName: Battery
        // NodeType: GROUP
        // NodeId:   I65:1288;362:15667;362:15639
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView28
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15640
        canvas.SaveState();
        canvas.StrokeSize = 1;
        canvas.Translate(572f, -427.66663f);
        var vector28Builder = new PathBuilder();
        var vector28path = vector28Builder.BuildPath("M0 2.66666C0 1.19391 1.19391 0 2.66667 0L19.3333 0C20.8061 0 22 1.19391 22 2.66667L22 8.66667C22 10.1394 20.8061 11.3333 19.3333 11.3333L2.66667 11.3333C1.19391 11.3333 0 10.1394 0 8.66667L0 2.66666Z");
        canvas.DrawPath(vector28path);
        canvas.RestoreState();


        // View:     imageView29
        // NodeName: Combined Shape
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15641
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(595f, -423.99997f);
        var vector29Builder = new PathBuilder();
        var vector29path = vector29Builder.BuildPath("M0 0L0 4C0.804731 3.66122 1.32804 2.87313 1.32804 2C1.32804 1.12687 0.804731 0.338777 0 0");
        canvas.FillPath(vector29path);
        canvas.RestoreState();


        // View:     imageView30
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15642
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(574f, -425.66663f);
        var vector30Builder = new PathBuilder();
        var vector30path = vector30Builder.BuildPath("M0 1.33333C0 0.596955 0.596954 0 1.33333 0L16.6667 0C17.403 0 18 0.596954 18 1.33333L18 6C18 6.73638 17.403 7.33333 16.6667 7.33333L1.33333 7.33333C0.596954 7.33333 0 6.73638 0 6L0 1.33333Z");
        canvas.FillPath(vector30path);
        canvas.RestoreState();


        // View:     imageView31
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15644
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(551.6937f, -427.6693f);
        var vector31Builder = new PathBuilder();
        var vector31path = vector31Builder.BuildPath("M7.63661 2.27733C9.8525 2.27742 11.9837 3.12886 13.5896 4.65566C13.7105 4.77354 13.9038 4.77205 14.0229 4.65233L15.1789 3.48566C15.2392 3.42494 15.2729 3.34269 15.2724 3.25711C15.2719 3.17153 15.2373 3.08967 15.1763 3.02966C10.9612 -1.00989 4.31137 -1.00989 0.0962725 3.02966C0.0352139 3.08963 0.00057 3.17146 6.97078e-06 3.25704C-0.000556058 3.34262 0.0330082 3.42489 0.0932725 3.48566L1.24961 4.65233C1.36863 4.77223 1.56208 4.77372 1.68294 4.65566C3.28909 3.12876 5.4205 2.27732 7.63661 2.27733L7.63661 2.27733Z");
        canvas.FillPath(vector31path);
        canvas.RestoreState();


        // View:     imageView32
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15645
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(554.357f, -423.87527f);
        var vector32Builder = new PathBuilder();
        var vector32path = vector32Builder.BuildPath("M4.97332 2.27895C6.19081 2.27888 7.36486 2.73141 8.26732 3.54862C8.38939 3.6646 8.58167 3.66209 8.70066 3.54295L9.85532 2.37629C9.91613 2.31509 9.94987 2.23208 9.94899 2.14581C9.94812 2.05955 9.9127 1.97723 9.85066 1.91729C7.10246 -0.639096 2.84652 -0.639096 0.0983249 1.91729C0.0362471 1.97723 0.000829042 2.05959 1.4369e-05 2.14588C-0.000800304 2.23217 0.0330566 2.31518 0.0939916 2.37629L1.24832 3.54295C1.36731 3.66209 1.55959 3.6646 1.68166 3.54862C2.58353 2.73195 3.75664 2.27946 4.97332 2.27895L4.97332 2.27895Z");
        canvas.FillPath(vector32path);
        canvas.RestoreState();


        // View:     imageView33
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15646
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(557.0171f, -420.07816f);
        var vector33Builder = new PathBuilder();
        var vector33path = vector33Builder.BuildPath("M4.53223 1.26616C4.59399 1.20556 4.62799 1.12215 4.62623 1.03565C4.62446 0.949141 4.58708 0.867197 4.5229 0.809163C3.24733 -0.269721 1.37914 -0.269721 0.103567 0.809163C0.0393462 0.86715 0.00190016 0.949069 7.03234e-05 1.03558C-0.00175952 1.12208 0.032189 1.20551 0.0939003 1.26616L2.09157 3.28183C2.15012 3.34107 2.22994 3.37441 2.31323 3.37441C2.39652 3.37441 2.47635 3.34107 2.5349 3.28183L4.53223 1.26616Z");
        canvas.FillPath(vector33path);
        canvas.RestoreState();


        // View:     imageView34
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15648
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(529.6666f, -420.66672f);
        var vector34Builder = new PathBuilder();
        var vector34path = vector34Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 3C3 3.55228 2.55228 4 2 4L1 4C0.447715 4 0 3.55228 0 3L0 1C0 0.447715 0.447715 0 1 0L1 0Z");
        canvas.FillPath(vector34path);
        canvas.RestoreState();


        // View:     imageView35
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15649
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(534.33325f, -422.66672f);
        var vector35Builder = new PathBuilder();
        var vector35path = vector35Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 5C3 5.55228 2.55228 6 2 6L1 6C0.447715 6 0 5.55228 0 5L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector35path);
        canvas.RestoreState();


        // View:     imageView36
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15650
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(539f, -425.00003f);
        var vector36Builder = new PathBuilder();
        var vector36path = vector36Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 7.33333C3 7.88562 2.55228 8.33333 2 8.33333L1 8.33333C0.447715 8.33333 0 7.88562 0 7.33333L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector36path);
        canvas.RestoreState();


        // View:     imageView37
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15651
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(543.6666f, -427.33337f);
        var vector37Builder = new PathBuilder();
        var vector37path = vector37Builder.BuildPath("M1 2.36848e-15L2 2.36848e-15C2.55228 0 3 0.447715 3 1L3 9.66667C3 10.219 2.55228 10.6667 2 10.6667L1 10.6667C0.447715 10.6667 0 10.219 0 9.66667L0 1C0 0.447715 0.447715 0 1 0L1 2.36848e-15Z");
        canvas.FillPath(vector37path);
        canvas.RestoreState();


        // View:     frameView18
        // NodeName: Recording Indicator
        // NodeType: GROUP
        // NodeId:   I65:1288;362:15667;362:15652
        canvas.SaveState();
        canvas.RestoreState();


        // View:     elipseView1
        // NodeName: Indicator
        // NodeType: ELLIPSE
        // NodeId:   I65:1288;362:15667;362:15653
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 149, 0);
        canvas.Alpha = 1;
        canvas.FillEllipse(534f, -436.99988f, 6f, 6f);
        canvas.RestoreState();


        // View:     frameView19
        // NodeName: Left Side
        // NodeType: GROUP
        // NodeId:   I65:1288;362:15667;362:15654
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView20
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1288;362:15667;362:15655
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView21
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1288;362:15667;362:15655;362:15623
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView38
        // NodeName: 9:41
        // NodeType: VECTOR
        // NodeId:   I65:1288;362:15667;362:15655;362:15623;362:15615
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(255.45352f, -427.83252f);
        var vector38Builder = new PathBuilder();
        var vector38path = vector38Builder.BuildPath("M3.86719 11.0889C6.55518 11.0889 8.15186 8.98682 8.15186 5.42725C8.15186 4.08691 7.89551 2.95898 7.40479 2.0874C6.69434 0.732422 5.47119 0 3.92578 0C1.62598 0 0 1.54541 0 3.71338C0 5.74951 1.46484 7.229 3.479 7.229C4.7168 7.229 5.72021 6.65039 6.21826 5.64697L6.24023 5.64697C6.24023 5.64697 6.26953 5.64697 6.27686 5.64697C6.2915 5.64697 6.34277 5.64697 6.34277 5.64697C6.34277 8.06396 5.42725 9.50684 3.88184 9.50684C2.97363 9.50684 2.27051 9.00879 2.02881 8.21045L0.146484 8.21045C0.461426 9.94629 1.93359 11.0889 3.86719 11.0889ZM3.93311 5.72754C2.71729 5.72754 1.85303 4.86328 1.85303 3.65479C1.85303 2.47559 2.76123 1.57471 3.94043 1.57471C5.11963 1.57471 6.02783 2.49023 6.02783 3.68408C6.02783 4.86328 5.1416 5.72754 3.93311 5.72754Z");
        canvas.FillPath(vector38path);
        canvas.Translate(255.45352f, -427.83252f);
        var vector39Builder = new PathBuilder();
        var vector39path = vector39Builder.BuildPath("M11.243 10.9863C11.9388 10.9863 12.4148 10.4883 12.4148 9.8291C12.4148 9.1626 11.9388 8.67188 11.243 8.67188C10.5545 8.67188 10.0711 9.1626 10.0711 9.8291C10.0711 10.4883 10.5545 10.9863 11.243 10.9863ZM11.243 5.49316C11.9388 5.49316 12.4148 5.00244 12.4148 4.34326C12.4148 3.67676 11.9388 3.18604 11.243 3.18604C10.5545 3.18604 10.0711 3.67676 10.0711 4.34326C10.0711 5.00244 10.5545 5.49316 11.243 5.49316Z");
        canvas.FillPath(vector39path);
        canvas.Translate(255.45352f, -427.83252f);
        var vector40Builder = new PathBuilder();
        var vector40path = vector40Builder.BuildPath("M19.2706 10.8325L21.0797 10.8325L21.0797 8.8623L22.5079 8.8623L22.5079 7.26562L21.0797 7.26562L21.0797 0.263672L18.4137 0.263672C16.546 3.07617 15.0592 5.42725 14.107 7.17773L14.107 8.8623L19.2706 8.8623L19.2706 10.8325ZM15.8575 7.19971C17.088 5.03174 18.1866 3.2959 19.1974 1.80176L19.2999 1.80176L19.2999 7.30957L15.8575 7.30957L15.8575 7.19971Z");
        canvas.FillPath(vector40path);
        canvas.Translate(255.45352f, -427.83252f);
        var vector41Builder = new PathBuilder();
        var vector41path = vector41Builder.BuildPath("M26.5365 10.8325L28.4262 10.8325L28.4262 0.263672L26.5438 0.263672L23.7826 2.19727L23.7826 4.01367L26.412 2.16797L26.5365 2.16797L26.5365 10.8325Z");
        canvas.FillPath(vector41path);
        canvas.RestoreState();


        // View:     frameView22
        // NodeName: Frame 15
        // NodeType: FRAME
        // NodeId:   65:1289
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(352f, -318f, 28.530823f, 27.203796f, 11.943128f);
        canvas.RestoreState();


        // View:     frameView23
        // NodeName: Things to do
        // NodeType: FRAME
        // NodeId:   65:1292
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(51, 51, 51);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(248f, 82f, 275f, 180f, 15.82f);
        canvas.RestoreState();


        // View:     frameView24
        // NodeName: checkbox
        // NodeType: INSTANCE
        // NodeId:   65:1293
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView25
        // NodeName: checkbox / checked
        // NodeType: FRAME
        // NodeId:   I65:1293;1:129
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView39
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1293;1:130
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(41, 171, 226);
        canvas.Alpha = 1;
        canvas.Translate(280f, 100f);
        var vector42Builder = new PathBuilder();
        var vector42path = vector42Builder.BuildPath("M24 6C24 4.4087 23.3679 2.88258 22.2426 1.75736C21.1174 0.632141 19.5913 6.18553e-16 18 0L6 0C4.4087 7.61296e-16 2.88258 0.632141 1.75736 1.75736C0.632141 2.88258 1.18952e-15 4.4087 0 6L9.5162e-16 18C1.61775e-15 19.5913 0.632141 21.1174 1.75736 22.2426C2.88258 23.3679 4.4087 24 6 24L18 24C19.5913 24 21.1174 23.3679 22.2426 22.2426C23.3679 21.1174 24 19.5913 24 18L24 6ZM18.3686 6.70629C18.5013 6.81074 18.612 6.94038 18.6945 7.08775C18.7769 7.23512 18.8294 7.39732 18.849 7.56505C18.8686 7.73278 18.8549 7.90272 18.8086 8.06513C18.7624 8.22754 18.6845 8.37921 18.5794 8.51143L11.8389 17.028C11.6753 17.2779 11.4613 17.4908 11.2106 17.6531C10.9598 17.8153 10.6779 17.9233 10.383 17.9702C10.088 18.017 9.78649 18.0016 9.49783 17.9249C9.20918 17.8483 8.93975 17.7121 8.70686 17.5251L5.64343 15.1611C5.37336 14.9529 5.19708 14.6459 5.15336 14.3077C5.10963 13.9695 5.20205 13.6278 5.41029 13.3577C5.61852 13.0876 5.92551 12.9114 6.26371 12.8676C6.60192 12.8239 6.94365 12.9163 7.21371 13.1246L9.63086 14.9914C9.72078 15.0596 9.83388 15.0897 9.94578 15.0753C10.0577 15.0608 10.1594 15.003 10.2291 14.9143L16.572 6.91371C16.7833 6.64876 17.0908 6.47821 17.4275 6.43934C17.7641 6.40048 18.1025 6.49645 18.3686 6.70629Z");
        canvas.FillPath(vector42path);
        canvas.RestoreState();


        // View:     imageView40
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1293;1:131
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(285.14282f, 106.43088f);
        var vector43Builder = new PathBuilder();
        var vector43path = vector43Builder.BuildPath("M13.5517 0.656871C13.4693 0.5095 13.3585 0.379865 13.2258 0.275409C12.9597 0.0655706 12.6214 -0.0304014 12.2848 0.00846679C11.9481 0.047335 11.6405 0.217883 11.4293 0.482838L5.0864 8.48341C5.01671 8.57214 4.91495 8.62995 4.80304 8.64438C4.69114 8.65881 4.57804 8.62871 4.48812 8.56055L2.07098 6.6937C1.80091 6.48546 1.45918 6.39304 1.12098 6.43676C0.782768 6.48049 0.47578 6.65677 0.267547 6.92684C0.0593145 7.1969 -0.0331058 7.53863 0.010617 7.87684C0.0543398 8.21505 0.230625 8.52203 0.500691 8.73027L3.56412 11.0943C3.79701 11.2812 4.06644 11.4174 4.35509 11.4941C4.64375 11.5707 4.94525 11.5861 5.24021 11.5393C5.53518 11.4925 5.81708 11.3845 6.06782 11.2222C6.31855 11.0599 6.53257 10.847 6.69612 10.5971L13.4367 2.08055C13.5417 1.94833 13.6196 1.79666 13.6659 1.63425C13.7121 1.47185 13.7259 1.3019 13.7063 1.13418C13.6867 0.966448 13.6342 0.804242 13.5517 0.656871Z");
        canvas.FillPath(vector43path);
        canvas.RestoreState();


        // View:     textView4
        // NodeName: text
        // NodeType: TEXT
        // NodeId:   I65:1293;1:132
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Rubik-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 16f;
        canvas.DrawString(@"Milk", 316f, 102.5f, 29f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView26
        // NodeName: checkbox
        // NodeType: INSTANCE
        // NodeId:   68:1090
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView27
        // NodeName: checkbox / default
        // NodeType: FRAME
        // NodeId:   I68:1090;1:125
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView41
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I68:1090;1:126
        canvas.SaveState();
        canvas.StrokeSize = 2;
        canvas.Translate(280f, 140f);
        var vector44Builder = new PathBuilder();
        var vector44path = vector44Builder.BuildPath("M24 6C24 4.4087 23.3679 2.88258 22.2426 1.75736C21.1174 0.632141 19.5913 6.18553e-16 18 0L6 0C4.4087 7.61296e-16 2.88258 0.632141 1.75736 1.75736C0.632141 2.88258 1.18952e-15 4.4087 0 6L9.5162e-16 18C1.61775e-15 19.5913 0.632141 21.1174 1.75736 22.2426C2.88258 23.3679 4.4087 24 6 24L18 24C19.5913 24 21.1174 23.3679 22.2426 22.2426C23.3679 21.1174 24 19.5913 24 18L24 6Z");
        canvas.DrawPath(vector44path);
        canvas.RestoreState();


        // View:     textView5
        // NodeName: text
        // NodeType: TEXT
        // NodeId:   I68:1090;1:127
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Rubik-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 16f;
        canvas.DrawString(@"Lemon", 316f, 142.5f, 51f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView28
        // NodeName: checkbox
        // NodeType: INSTANCE
        // NodeId:   65:1294
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView29
        // NodeName: checkbox / default
        // NodeType: FRAME
        // NodeId:   I65:1294;1:125
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView42
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1294;1:126
        canvas.SaveState();
        canvas.StrokeSize = 2;
        canvas.Translate(280f, 180f);
        var vector45Builder = new PathBuilder();
        var vector45path = vector45Builder.BuildPath("M24 6C24 4.4087 23.3679 2.88258 22.2426 1.75736C21.1174 0.632141 19.5913 6.18553e-16 18 0L6 0C4.4087 7.61296e-16 2.88258 0.632141 1.75736 1.75736C0.632141 2.88258 1.18952e-15 4.4087 0 6L9.5162e-16 18C1.61775e-15 19.5913 0.632141 21.1174 1.75736 22.2426C2.88258 23.3679 4.4087 24 6 24L18 24C19.5913 24 21.1174 23.3679 22.2426 22.2426C23.3679 21.1174 24 19.5913 24 18L24 6Z");
        canvas.DrawPath(vector45path);
        canvas.RestoreState();


        // View:     textView6
        // NodeName: text
        // NodeType: TEXT
        // NodeId:   I65:1294;1:127
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Rubik-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 16f;
        canvas.DrawString(@"Eggs 4pcs.", 316f, 182.5f, 82f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView30
        // NodeName: checkbox
        // NodeType: INSTANCE
        // NodeId:   65:1295
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView31
        // NodeName: checkbox / default
        // NodeType: FRAME
        // NodeId:   I65:1295;1:125
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView43
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1295;1:126
        canvas.SaveState();
        canvas.StrokeSize = 2;
        canvas.Translate(280f, 220f);
        var vector46Builder = new PathBuilder();
        var vector46path = vector46Builder.BuildPath("M24 6C24 4.4087 23.3679 2.88258 22.2426 1.75736C21.1174 0.632141 19.5913 6.18553e-16 18 0L6 0C4.4087 7.61296e-16 2.88258 0.632141 1.75736 1.75736C0.632141 2.88258 1.18952e-15 4.4087 0 6L9.5162e-16 18C1.61775e-15 19.5913 0.632141 21.1174 1.75736 22.2426C2.88258 23.3679 4.4087 24 6 24L18 24C19.5913 24 21.1174 23.3679 22.2426 22.2426C23.3679 21.1174 24 19.5913 24 18L24 6Z");
        canvas.DrawPath(vector46path);
        canvas.RestoreState();


        // View:     textView7
        // NodeName: text
        // NodeType: TEXT
        // NodeId:   I65:1295;1:127
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Rubik-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 16f;
        canvas.DrawString(@"Onion", 316f, 222.5f, 44f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView8
        // NodeName: Bucket list:
        // NodeType: TEXT
        // NodeId:   65:1296
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.958971977233887f;
        canvas.DrawString(@"Bucket list:", 250f, 45f, 97f, 10f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView9
        // NodeName: Your recipes:
        // NodeType: TEXT
        // NodeId:   65:1297
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.958971977233887f;
        canvas.DrawString(@"Your recipes:
", 247f, -144f, 107f, 20f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     rectangleView3
        // NodeName: image 3
        // NodeType: RECTANGLE
        // NodeId:   65:1299
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(243f, -107f, 113f, 80f, 15.82f);
        canvas.RestoreState();


        // View:     frameView32
        // NodeName: Filter_alt
        // NodeType: COMPONENT
        // NodeId:   72:1061
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView44
        // NodeName: Vector 51
        // NodeType: VECTOR
        // NodeId:   72:1063
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(363.5f, -305.66666f);
        var vector47Builder = new PathBuilder();
        var vector47path = vector47Builder.BuildPath("M5 6.30629L5 0.5C5 0.223858 4.77614 0 4.5 0L0.5 0C0.223858 0 0 0.223857 0 0.5L0 7.63962C0 7.9809 0.334348 8.22188 0.658114 8.11396L4.65811 6.78063C4.86228 6.71257 5 6.5215 5 6.30629Z");
        canvas.FillPath(vector47path);
        canvas.RestoreState();


        // View:     imageView45
        // NodeName: Rectangle 44
        // NodeType: VECTOR
        // NodeId:   72:1064
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(196, 196, 196);
        canvas.Alpha = 1;
        canvas.Translate(359.33334f, -310.66666f);
        var vector48Builder = new PathBuilder();
        var vector48path = vector48Builder.BuildPath("M0 0L13.3333 0L13.3333 2.5L6.66667 9.16667L0 2.5L0 0Z");
        canvas.FillPath(vector48path);
        canvas.RestoreState();


        // View:     frameView33
        // NodeName: NAVBAR
        // NodeType: GROUP
        // NodeId:   77:1057
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView46
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1273

        // View:     frameView34
        // NodeName: BookBookmark
        // NodeType: COMPONENT
        // NodeId:   65:1301
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView47
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1302

        // View:     imageView48
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1303

        // View:     imageView49
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1304

        // View:     imageView50
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1305

        // View:     frameView35
        // NodeName: Materials
        // NodeType: COMPONENT
        // NodeId:   72:1066
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView51
        // NodeName: Vector 99
        // NodeType: VECTOR
        // NodeId:   72:1067

        // View:     imageView52
        // NodeName: Vector 100
        // NodeType: VECTOR
        // NodeId:   72:1068

        // View:     frameView36
        // NodeName: Search_alt
        // NodeType: COMPONENT
        // NodeId:   72:1069
        canvas.SaveState();
        canvas.RestoreState();


        // View:     elipseView2
        // NodeName: Ellipse 65
        // NodeType: ELLIPSE
        // NodeId:   72:1070
        canvas.SaveState();
        canvas.StrokeColor = Color.FromRgb(255, 149, 0);
        canvas.Alpha = 1;
        canvas.StrokeSize = 2;
        canvas.DrawEllipse(492.16666f, 349.16666f, 18.083344f, 18.083344f);
        canvas.RestoreState();


        // View:     elipseView3
        // NodeName: Ellipse 66
        // NodeType: ELLIPSE
        // NodeId:   72:1071
        canvas.SaveState();
        canvas.StrokeColor = Color.FromRgb(255, 149, 0);
        canvas.Alpha = 1;
        canvas.StrokeSize = 2;
        canvas.DrawEllipse(497.33334f, 354.33334f, 7.75f, 7.75f);
        canvas.RestoreState();


        // View:     imageView53
        // NodeName: Vector 109
        // NodeType: VECTOR
        // NodeId:   72:1072

        // View:     frameView37
        // NodeName: Lockscreen
        // NodeType: INSTANCE
        // NodeId:   65:1300
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView38
        // NodeName: Lockscreen Assets
        // NodeType: FRAME
        // NodeId:   I65:1300;362:14396
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView4
        // NodeName: Wallpaper
        // NodeType: RECTANGLE
        // NodeId:   I65:1300;362:14397
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(222f, -453f, 389f, 840f, 0f);
        canvas.RestoreState();


        // View:     frameView39
        // NodeName: Bottom UI
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14398
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView40
        // NodeName: Home Indicator
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14399
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView41
        // NodeName: Home Indicator
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14399;362:15725
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView5
        // NodeName: Home Indicator
        // NodeType: RECTANGLE
        // NodeId:   I65:1300;362:14399;362:15725;362:15723
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(350f, 374f, 134f, 5f, 100f);
        canvas.RestoreState();


        // View:     textView10
        // NodeName: swipe up to open
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14400
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 17f;
        canvas.DrawString(@"swipe up to open", 351f, 259f, 131f, 20f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView42
        // NodeName: Camera button
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14401
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView54
        // NodeName: Oval Copy
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14402
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.Translate(515f, 287f);
        var vector49Builder = new PathBuilder();
        var vector49path = vector49Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.FillPath(vector49path);
        canvas.StrokeColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.StrokeSize = 0;
        canvas.Translate(515f, 287f);
        var vector50Builder = new PathBuilder();
        var vector50path = vector50Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.DrawPath(vector50path);
        canvas.RestoreState();


        // View:     imageView55
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14404
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(536.0125f, 308.31403f);
        var vector51Builder = new PathBuilder();
        var vector51path = vector51Builder.BuildPath("M3.995 0C1.789 0 0 1.793 0 4.005C0 6.216 1.789 8.01 3.995 8.01C6.202 8.01 7.99 6.216 7.99 4.005C7.99 1.793 6.202 0 3.995 0L3.995 0Z");
        canvas.FillPath(vector51path);
        canvas.RestoreState();


        // View:     imageView56
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14405
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(545.68054f, 307.315f);
        var vector52Builder = new PathBuilder();
        var vector52path = vector52Builder.BuildPath("M0.668 1.348C0.3 1.348 0 1.046 0 0.674C0 0.302 0.3 0 0.668 0C1.036 0 1.335 0.302 1.335 0.674C1.335 1.046 1.036 1.348 0.668 1.348L0.668 1.348Z");
        canvas.FillPath(vector52path);
        canvas.RestoreState();


        // View:     imageView57
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14406
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(535.0445f, 307.36603f);
        var vector53Builder = new PathBuilder();
        var vector53path = vector53Builder.BuildPath("M4.958 9.937C2.219 9.937 0 7.712 0 4.968C0 2.224 2.219 0 4.958 0C7.696 0 9.916 2.224 9.916 4.968C9.916 7.712 7.696 9.937 4.958 9.937L4.958 9.937Z");
        canvas.FillPath(vector53path);
        canvas.RestoreState();


        // View:     imageView58
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14407
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(529.0005f, 302.99976f);
        var vector54Builder = new PathBuilder();
        var vector54path = vector54Builder.BuildPath("M21.999 5.43925C21.999 5.34525 21.999 5.25225 21.998 5.15925C21.998 5.08025 21.997 5.00125 21.995 4.92225C21.99 4.75125 21.98 4.50125 21.95 4.33125C21.919 4.15925 21.869 4.07525 21.791 3.91825C21.713 3.76525 21.612 3.62425 21.491 3.50225C21.371 3.37925 21.231 3.27825 21.079 3.19925C20.924 3.12025 20.766 3.06925 20.595 3.03825C20.427 3.00725 20.256 2.99725 20.086 2.99325C20.008 2.99125 19.93 2.99025 19.852 2.99025C19.76 2.98925 19.667 2.98925 19.575 2.98925L18.829 2.98925L17.346 2.98925C17.2 2.98225 17.054 2.98325 16.911 2.95725C16.716 2.92125 16.535 2.84925 16.358 2.75725C16.185 2.66825 16.027 2.55525 15.889 2.41525C15.752 2.27525 15.579 1.62925 15.44 1.30425C15.396 1.20225 15.38 1.14325 15.34 1.06425C15.252 0.88925 15.136 0.72625 15 0.58625C14.861 0.44625 14.702 0.32825 14.53 0.23825C14.353 0.14625 14.172 0.08925 13.977 0.05425C13.786 0.01825 13.59 0.00825 13.396 0.00225C13.307 -0.00075 8.628 -0.00075 8.539 0.00225C8.346 0.00825 8.15 0.01825 7.959 0.05425C7.765 0.08925 7.584 0.14625 7.407 0.23825C7.234 0.32825 7.075 0.44525 6.937 0.58525C6.799 0.72525 6.684 0.88825 6.596 1.06425C6.557 1.14325 6.524 1.22225 6.497 1.30325C6.358 1.64925 6.189 2.26425 6.051 2.40425C5.914 2.54425 5.755 2.65825 5.581 2.74725C5.405 2.84025 5.224 2.91125 5.03 2.94625C4.838 2.98125 4.643 2.97925 4.449 2.98325C4.36 2.98725 4.459 2.98725 4.369 2.98825C4.264 2.98925 4.159 2.98925 4.053 2.98925L3.17 2.98925L2.424 2.98925C2.332 2.98925 2.24 2.98925 2.147 2.99025C2.069 2.99025 1.991 2.99125 1.913 2.99325C1.743 2.99725 1.572 3.00725 1.404 3.03825C1.233 3.06925 1.075 3.12025 0.92 3.19925C0.768 3.27825 0.628 3.37925 0.508 3.50225C0.387 3.62425 0.286 3.76525 0.209 3.91825C0.13 4.07525 0.079 4.23525 0.049 4.40825C0.019 4.57725 0.008 4.75125 0.004 4.92225C0.002 5.00125 0.002 5.08025 0.001 5.15925C0 5.25225 0 5.34525 0 5.43925L0 5.93325L0 13.4622L0 14.2172C0 14.3112 0 14.4042 0.001 14.4972C0.002 14.5772 0.002 14.6552 0.004 14.7343C0.008 14.9062 0.019 15.0782 0.049 15.2483C0.079 15.4213 0.13 15.5813 0.209 15.7382C0.286 15.8923 0.387 16.0322 0.508 16.1542C0.628 16.2762 0.768 16.3783 0.92 16.4573C1.075 16.5363 1.233 16.5872 1.404 16.6182C1.572 16.6493 1.743 16.6593 1.913 16.6632C1.991 16.6653 2.069 16.6663 2.147 16.6672C2.24 16.6672 2.332 16.6672 2.424 16.6672L19.575 16.6672C19.667 16.6672 19.76 16.6672 19.852 16.6672C19.93 16.6663 20.008 16.6653 20.086 16.6632C20.256 16.6593 20.427 16.6493 20.595 16.6182C20.766 16.5872 20.924 16.5363 21.079 16.4573C21.231 16.3783 21.371 16.2762 21.491 16.1542C21.612 16.0322 21.713 15.8923 21.791 15.7382C21.869 15.5813 21.919 15.4213 21.95 15.2483C21.98 15.0782 21.99 14.9062 21.995 14.7343C21.997 14.6552 21.998 14.5772 21.998 14.4972C21.999 14.4042 21.999 14.3112 21.999 14.2172L21.999 13.4622L21.999 6.19425L21.999 5.43925Z");
        canvas.FillPath(vector54path);
        canvas.RestoreState();


        // View:     imageView59
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14408
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(531.00354f, 304.352f);
        var vector55Builder = new PathBuilder();
        var vector55path = vector55Builder.BuildPath("M0.128 0.968L2.198 0.968C2.269 0.968 2.327 0.91 2.327 0.839L2.327 0.401C2.327 0.387 2.327 0.372 2.326 0.358C2.325 0.326 2.322 0.294 2.317 0.263C2.312 0.231 2.303 0.201 2.288 0.172C2.274 0.144 2.256 0.118 2.234 0.096C2.211 0.073 2.186 0.054 2.159 0.04C2.13 0.025 2.101 0.015 2.07 0.01C2.039 0.004 2.008 0.002 1.977 0.001C1.963 0.001 1.948 0 1.934 0L0.396 0C0.383 0 0.368 0.001 0.354 0.001C0.323 0.002 0.292 0.004 0.261 0.01C0.23 0.015 0.201 0.025 0.173 0.04C0.145 0.054 0.12 0.073 0.097 0.096C0.075 0.118 0.058 0.144 0.043 0.172C0.028 0.201 0.02 0.231 0.014 0.263C0.008 0.294 0.006 0.326 0.006 0.358C0.005 0.372 0.002 0.387 0.002 0.401C0.002 0.418 0 0.436 0 0.453L0 0.839C0 0.91 0.058 0.968 0.128 0.968L0.128 0.968Z");
        canvas.FillPath(vector55path);
        canvas.RestoreState();


        // View:     frameView43
        // NodeName: Flashlight button
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14409
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView60
        // NodeName: Oval
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14410
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.Translate(268f, 287f);
        var vector56Builder = new PathBuilder();
        var vector56path = vector56Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.FillPath(vector56path);
        canvas.StrokeColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.StrokeSize = 0;
        canvas.Translate(268f, 287f);
        var vector57Builder = new PathBuilder();
        var vector57path = vector57Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.DrawPath(vector57path);
        canvas.RestoreState();


        // View:     imageView61
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14412
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(292.0006f, 313.33447f);
        var vector58Builder = new PathBuilder();
        var vector58path = vector58Builder.BuildPath("M1.998 0.999C1.998 1.551 1.551 1.998 0.999 1.998C0.447 1.998 0 1.551 0 0.999C0 0.447 0.447 0 0.999 0C1.551 0 1.998 0.447 1.998 0.999L1.998 0.999Z");
        canvas.FillPath(vector58path);
        canvas.RestoreState();


        // View:     imageView62
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14413
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(291.3296f, 310.0185f);
        var vector59Builder = new PathBuilder();
        var vector59path = vector59Builder.BuildPath("M0 1.67L0 4.294C0 5.216 0.748 5.963 1.67 5.963C2.592 5.963 3.34 5.216 3.34 4.294L3.34 1.67C3.34 0.747 2.592 0 1.67 0C0.748 0 0 0.747 0 1.67L0 1.67Z");
        canvas.FillPath(vector59path);
        canvas.RestoreState();


        // View:     imageView63
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14414
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(287.9996f, 302.6665f);
        var vector60Builder = new PathBuilder();
        var vector60path = vector60Builder.BuildPath("M5.251 0L10.001 0C10.001 1.268 10 2.262 8.75 4.001C7.761 5.377 7.667 5.97 7.667 7.5L7.667 19.25L7.667 21.251L7.667 21.5C7.667 22.329 6.996 23 6.167 23L3.834 23C3.005 23 2.334 22.329 2.334 21.5L2.334 21.251L2.334 19.25L2.334 7.5C2.334 5.97 2.24 5.377 1.25 4.001C0.00100005 2.262 0 1.268 0 0L4.751 0L5.251 0Z");
        canvas.FillPath(vector60path);
        canvas.RestoreState();


        // View:     imageView64
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14415
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(287.9996f, 300.0005f);
        var vector61Builder = new PathBuilder();
        var vector61path = vector61Builder.BuildPath("M0 0.5C0 0.224 0.224 0 0.5 0L9.501 0C9.777 0 10.001 0.224 10.001 0.5L10.001 1.666L0 1.666L0 0.5Z");
        canvas.FillPath(vector61path);
        canvas.RestoreState();


        // View:     frameView44
        // NodeName: Status Bar, Time, Date
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14416
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView11
        // NodeName: Date
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14417
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 22f;
        canvas.DrawString(@"Monday, June 3", 338f, -263f, 157f, 26f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     imageView65
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14419
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(348.33594f, -335.22656f);
        var vector62Builder = new PathBuilder();
        var vector62path = vector62Builder.BuildPath("M1.40625 45C1.28906 44.375 1.64062 44.0625 2.10938 44.0625L4.02344 44.0625C4.60938 44.0625 4.84375 44.3359 5 44.8047C6.32812 50.5469 11.5625 54.8828 18.9062 54.8828C29.6094 54.8828 35.7812 44.8438 36.2891 28.8281C36.3281 27.7734 36.2891 26.4844 36.2891 25.3516L36.1719 25.3516C34.3359 32.3047 27.0703 37.7344 18.7109 37.7344C7.92969 37.7344 0 29.8438 0 19.4141C0 8.32031 8.08594 0 19.1406 0C25.7031 0 31.1328 2.96875 34.6094 8.04688C37.9688 12.6562 39.7266 19.1797 39.7266 27.6172C39.7266 46.2891 31.9141 58.0469 18.9062 58.0469C9.6875 58.0469 3.08594 52.6953 1.40625 45Z");
        canvas.FillPath(vector62path);
        canvas.RestoreState();


        // View:     imageView66
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14420
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(351.89062f, -331.98438f);
        var vector63Builder = new PathBuilder();
        var vector63path = vector63Builder.BuildPath("M31.4453 16.4062C31.4453 7.30469 24.6094 0 15.625 0C6.71875 0 0 6.95312 0 16.0938C0 24.5312 6.48438 31.3281 15.5469 31.3281C24.3359 31.3281 31.4453 24.375 31.4453 16.4062Z");
        canvas.FillPath(vector63path);
        canvas.RestoreState();


        // View:     imageView67
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14421
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(398.33594f, -323.8203f);
        var vector64Builder = new PathBuilder();
        var vector64path = vector64Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.33594 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.33594 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector64path);
        canvas.RestoreState();


        // View:     imageView68
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14422
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(398.33594f, -293.7422f);
        var vector65Builder = new PathBuilder();
        var vector65path = vector65Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.375 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.375 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector65path);
        canvas.RestoreState();


        // View:     imageView69
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14423
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(413.53125f, -334.52344f);
        var vector66Builder = new PathBuilder();
        var vector66path = vector66Builder.BuildPath("M28.9453 55.625L28.9453 42.6953L0.898438 42.6953C0.351562 42.6953 0 42.3438 0 41.7969L0 39.8438C0 39.4922 0.078125 39.2578 0.273438 38.9453C7.85156 27.1094 16.0547 15.2734 26.8359 0.625C27.1484 0.234375 27.3828 0 27.9688 0L31.5234 0C32.0312 0 32.3828 0.351562 32.3828 0.898438L32.3828 39.4922L40.3516 39.4922C40.8984 39.4922 41.25 39.8438 41.25 40.3906L41.25 41.7969C41.25 42.3438 40.8984 42.6953 40.3516 42.6953L32.3828 42.6953L32.3828 55.625C32.3828 56.1719 32.0312 56.5234 31.5234 56.5234L29.8438 56.5234C29.2969 56.5234 28.9453 56.1719 28.9453 55.625Z");
        canvas.FillPath(vector66path);
        canvas.RestoreState();


        // View:     imageView70
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14424
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(417.3203f, -331.125f);
        var vector67Builder = new PathBuilder();
        var vector67path = vector67Builder.BuildPath("M0 36.0938L25.1562 36.0938L25.1562 0L25.0781 0C15.3906 13.0469 7.03125 25.1172 0 36.0156L0 36.0938Z");
        canvas.FillPath(vector67path);
        canvas.RestoreState();


        // View:     imageView71
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14425
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(459.39062f, -334.3672f);
        var vector68Builder = new PathBuilder();
        var vector68path = vector68Builder.BuildPath("M15.4297 55.4688L15.4297 3.94531L15.3516 3.94531C11.9922 6.05469 5.46875 10.3906 1.28906 13.0859C0.78125 13.4375 0 13.2812 0 12.5781L0 10.8203C0 10.1562 0.15625 9.96094 0.625 9.64844C4.60938 7.03125 10.4688 3.125 14.7266 0.46875C15.1562 0.195312 15.5078 0 16.1328 0L18.0078 0C18.5547 0 18.9062 0.351562 18.9062 0.898438L18.9062 55.4688C18.9062 56.0156 18.5547 56.3672 18.0078 56.3672L16.3281 56.3672C15.7812 56.3672 15.4297 56.0156 15.4297 55.4688Z");
        canvas.FillPath(vector68path);
        canvas.RestoreState();


        // View:     textView12
        // NodeName: 9 41
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14426
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"9 41", 338f, -356f, 144f, 99f, HorizontalAlignment.Right, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     frameView45
        // NodeName: Editable Time
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14427
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView13
        // NodeName: 41
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14428
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"41", 409f, -356f, 80f, 99f, HorizontalAlignment.Left, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     imageView72
        // NodeName: :
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14429
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(398.78467f, -323.5f);
        var vector69Builder = new PathBuilder();
        var vector69path = vector69Builder.BuildPath("M2.71533 5.39014C4.17432 5.39014 5.39014 4.17432 5.39014 2.6748C5.39014 1.21582 4.17432 0 2.71533 0C1.21582 0 0 1.21582 0 2.6748C0 4.17432 1.21582 5.39014 2.71533 5.39014ZM2.71533 34.8242C4.17432 34.8242 5.39014 33.6084 5.39014 32.1089C5.39014 30.6499 4.17432 29.4341 2.71533 29.4341C1.21582 29.4341 0 30.6499 0 32.1089C0 33.6084 1.21582 34.8242 2.71533 34.8242Z");
        canvas.FillPath(vector69path);
        canvas.RestoreState();


        // View:     textView14
        // NodeName: 9
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14430
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"9", 345f, -356f, 48f, 99f, HorizontalAlignment.Right, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     imageView73
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14432
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(410.48535f, -390.86432f);
        var vector70Builder = new PathBuilder();
        var vector70path = vector70Builder.BuildPath("M11.6946 10.532L0.334703 10.532C0.219024 10.532 0.108345 10.532 0 10.532L0 8.26133C0 6.89733 0.00933436 5.89033 0.214357 4.87667C0.412045 3.90067 0.776085 3.05633 1.32715 2.323C2.43493 0.849 4.17913 0 6.01466 0C7.85053 0 9.59439 0.849 10.7022 2.323C11.2536 3.05633 11.6176 3.90067 11.815 4.87667C12.0203 5.89033 12.0293 6.89733 12.0293 8.26133L12.0293 10.532C11.9213 10.532 11.8106 10.532 11.6946 10.532L11.6946 10.532Z");
        canvas.FillPath(vector70path);
        canvas.RestoreState();


        // View:     imageView74
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14433
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(405f, -394f);
        var vector71Builder = new PathBuilder();
        var vector71path = vector71Builder.BuildPath("M22.9999 19.5157C22.9999 18.744 23.0013 18.141 22.9923 17.748C22.9826 17.317 22.9586 16.951 22.8963 16.5983C22.7689 15.8817 22.4755 15.243 21.9538 14.7187C21.5798 14.3427 21.1457 14.0863 20.6677 13.9233L20.6677 11.397C20.6677 9.867 20.654 8.56333 20.343 7.16933C20.0419 5.821 19.4919 4.58767 18.6518 3.49767C16.9583 1.30067 14.313 0 11.5 0C8.68702 0 6.04173 1.30067 4.34821 3.49767C3.50812 4.58767 2.95806 5.821 2.65736 7.16933C2.34599 8.56333 2.33233 9.867 2.33233 11.397L2.33233 13.9233C1.85427 14.0863 1.42023 14.3427 1.04618 14.7187C0.524461 15.243 0.231095 15.8817 0.103748 16.5983C0.0410742 16.951 0.0174049 17.317 0.00773718 17.748C-0.00126381 18.141 6.96675e-05 18.744 6.96675e-05 19.5157L6.96675e-05 27.484C6.96675e-05 28.2557 -0.00126381 28.8587 0.00773718 29.2517C0.0174049 29.6827 0.0410742 30.049 0.103748 30.4013C0.231095 31.118 0.524461 31.757 1.04618 32.281C1.56758 32.8053 2.20365 33.0997 2.91672 33.228C3.26776 33.2907 3.63214 33.3147 4.06052 33.3243C4.45223 33.3333 5.05229 33.3323 5.82004 33.3323L17.18 33.3323C17.9477 33.3323 18.5481 33.3333 18.9391 33.3243C19.3679 33.3147 19.7322 33.2907 20.0833 33.228C20.7964 33.0997 21.4324 32.8053 21.9538 32.281C22.4755 31.757 22.7689 31.118 22.8963 30.4013C22.9586 30.049 22.9826 29.6827 22.9923 29.2517C23.0013 28.8587 22.9999 28.2557 22.9999 27.484L22.9999 19.5157Z");
        canvas.FillPath(vector71path);
        canvas.RestoreState();


        // View:     frameView46
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14434
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView47
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14434;362:15667
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView48
        // NodeName: Notch
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14434;362:15667;362:15633
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView6
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1300;362:14434;362:15667;362:15634
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(222f, -453f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     rectangleView7
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1300;362:14434;362:15667;362:15636
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(214, 217, 221);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(222f, -453f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     imageView75
        // NodeName: Notch
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15637
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(307f, -455f);
        var vector72Builder = new PathBuilder();
        var vector72path = vector72Builder.BuildPath("M0 0L219 0L219 0C216.894 0.602689 215.418 2.49525 215.345 4.68446L215.317 5.5618L215.317 5.5618C215.317 19.0587 204.375 30 190.878 30L28.1217 30C14.6249 30 3.68349 19.0587 3.68349 5.5618L3.68349 5.5618L3.65455 4.68447C3.58233 2.49525 2.10586 0.602689 0 0L0 0Z");
        canvas.FillPath(vector72path);
        canvas.RestoreState();


        // View:     frameView49
        // NodeName: Right Side
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14434;362:15667;362:15638
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView50
        // NodeName: Battery
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14434;362:15667;362:15639
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView76
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15640
        canvas.SaveState();
        canvas.StrokeSize = 1;
        canvas.Translate(572f, -435.66663f);
        var vector73Builder = new PathBuilder();
        var vector73path = vector73Builder.BuildPath("M0 2.66666C0 1.19391 1.19391 0 2.66667 0L19.3333 0C20.8061 0 22 1.19391 22 2.66667L22 8.66667C22 10.1394 20.8061 11.3333 19.3333 11.3333L2.66667 11.3333C1.19391 11.3333 0 10.1394 0 8.66667L0 2.66666Z");
        canvas.DrawPath(vector73path);
        canvas.RestoreState();


        // View:     imageView77
        // NodeName: Combined Shape
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15641
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(595f, -431.99997f);
        var vector74Builder = new PathBuilder();
        var vector74path = vector74Builder.BuildPath("M0 0L0 4C0.804731 3.66122 1.32804 2.87313 1.32804 2C1.32804 1.12687 0.804731 0.338777 0 0");
        canvas.FillPath(vector74path);
        canvas.RestoreState();


        // View:     imageView78
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15642
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(574f, -433.66663f);
        var vector75Builder = new PathBuilder();
        var vector75path = vector75Builder.BuildPath("M0 1.33333C0 0.596955 0.596954 0 1.33333 0L16.6667 0C17.403 0 18 0.596954 18 1.33333L18 6C18 6.73638 17.403 7.33333 16.6667 7.33333L1.33333 7.33333C0.596954 7.33333 0 6.73638 0 6L0 1.33333Z");
        canvas.FillPath(vector75path);
        canvas.RestoreState();


        // View:     imageView79
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15644
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(551.6937f, -435.6693f);
        var vector76Builder = new PathBuilder();
        var vector76path = vector76Builder.BuildPath("M7.63661 2.27733C9.8525 2.27742 11.9837 3.12886 13.5896 4.65566C13.7105 4.77354 13.9038 4.77205 14.0229 4.65233L15.1789 3.48566C15.2392 3.42494 15.2729 3.34269 15.2724 3.25711C15.2719 3.17153 15.2373 3.08967 15.1763 3.02966C10.9612 -1.00989 4.31137 -1.00989 0.0962725 3.02966C0.0352139 3.08963 0.00057 3.17146 6.97078e-06 3.25704C-0.000556058 3.34262 0.0330082 3.42489 0.0932725 3.48566L1.24961 4.65233C1.36863 4.77223 1.56208 4.77372 1.68294 4.65566C3.28909 3.12876 5.4205 2.27732 7.63661 2.27733L7.63661 2.27733Z");
        canvas.FillPath(vector76path);
        canvas.RestoreState();


        // View:     imageView80
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15645
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(554.357f, -431.87527f);
        var vector77Builder = new PathBuilder();
        var vector77path = vector77Builder.BuildPath("M4.97332 2.27895C6.19081 2.27888 7.36486 2.73141 8.26732 3.54862C8.38939 3.6646 8.58167 3.66209 8.70066 3.54295L9.85532 2.37629C9.91613 2.31509 9.94987 2.23208 9.94899 2.14581C9.94812 2.05955 9.9127 1.97723 9.85066 1.91729C7.10246 -0.639096 2.84652 -0.639096 0.0983249 1.91729C0.0362471 1.97723 0.000829042 2.05959 1.4369e-05 2.14588C-0.000800304 2.23217 0.0330566 2.31518 0.0939916 2.37629L1.24832 3.54295C1.36731 3.66209 1.55959 3.6646 1.68166 3.54862C2.58353 2.73195 3.75664 2.27946 4.97332 2.27895L4.97332 2.27895Z");
        canvas.FillPath(vector77path);
        canvas.RestoreState();


        // View:     imageView81
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15646
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(557.0171f, -428.07816f);
        var vector78Builder = new PathBuilder();
        var vector78path = vector78Builder.BuildPath("M4.53223 1.26616C4.59399 1.20556 4.62799 1.12215 4.62623 1.03565C4.62446 0.949141 4.58708 0.867197 4.5229 0.809163C3.24733 -0.269721 1.37914 -0.269721 0.103567 0.809163C0.0393462 0.86715 0.00190016 0.949069 7.03234e-05 1.03558C-0.00175952 1.12208 0.032189 1.20551 0.0939003 1.26616L2.09157 3.28183C2.15012 3.34107 2.22994 3.37441 2.31323 3.37441C2.39652 3.37441 2.47635 3.34107 2.5349 3.28183L4.53223 1.26616Z");
        canvas.FillPath(vector78path);
        canvas.RestoreState();


        // View:     imageView82
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15648
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(529.6666f, -428.66672f);
        var vector79Builder = new PathBuilder();
        var vector79path = vector79Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 3C3 3.55228 2.55228 4 2 4L1 4C0.447715 4 0 3.55228 0 3L0 1C0 0.447715 0.447715 0 1 0L1 0Z");
        canvas.FillPath(vector79path);
        canvas.RestoreState();


        // View:     imageView83
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15649
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(534.33325f, -430.66672f);
        var vector80Builder = new PathBuilder();
        var vector80path = vector80Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 5C3 5.55228 2.55228 6 2 6L1 6C0.447715 6 0 5.55228 0 5L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector80path);
        canvas.RestoreState();


        // View:     imageView84
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15650
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(539f, -433.00003f);
        var vector81Builder = new PathBuilder();
        var vector81path = vector81Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 7.33333C3 7.88562 2.55228 8.33333 2 8.33333L1 8.33333C0.447715 8.33333 0 7.88562 0 7.33333L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector81path);
        canvas.RestoreState();


        // View:     imageView85
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15651
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(543.6666f, -435.33337f);
        var vector82Builder = new PathBuilder();
        var vector82path = vector82Builder.BuildPath("M1 2.36848e-15L2 2.36848e-15C2.55228 0 3 0.447715 3 1L3 9.66667C3 10.219 2.55228 10.6667 2 10.6667L1 10.6667C0.447715 10.6667 0 10.219 0 9.66667L0 1C0 0.447715 0.447715 0 1 0L1 2.36848e-15Z");
        canvas.FillPath(vector82path);
        canvas.RestoreState();


        // View:     frameView51
        // NodeName: Recording Indicator
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14434;362:15667;362:15652
        canvas.SaveState();
        canvas.RestoreState();


        // View:     elipseView4
        // NodeName: Indicator
        // NodeType: ELLIPSE
        // NodeId:   I65:1300;362:14434;362:15667;362:15653
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 149, 0);
        canvas.Alpha = 1;
        canvas.FillEllipse(534f, -444.99988f, 6f, 6f);
        canvas.RestoreState();


        // View:     frameView52
        // NodeName: Left Side
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14434;362:15667;362:15654
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView53
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14434;362:15667;362:15655
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView54
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14434;362:15667;362:15655;362:15623
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView86
        // NodeName: 9:41
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14434;362:15667;362:15655;362:15623;362:15615
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(255.45352f, -435.83252f);
        var vector83Builder = new PathBuilder();
        var vector83path = vector83Builder.BuildPath("M3.86719 11.0889C6.55518 11.0889 8.15186 8.98682 8.15186 5.42725C8.15186 4.08691 7.89551 2.95898 7.40479 2.0874C6.69434 0.732422 5.47119 0 3.92578 0C1.62598 0 0 1.54541 0 3.71338C0 5.74951 1.46484 7.229 3.479 7.229C4.7168 7.229 5.72021 6.65039 6.21826 5.64697L6.24023 5.64697C6.24023 5.64697 6.26953 5.64697 6.27686 5.64697C6.2915 5.64697 6.34277 5.64697 6.34277 5.64697C6.34277 8.06396 5.42725 9.50684 3.88184 9.50684C2.97363 9.50684 2.27051 9.00879 2.02881 8.21045L0.146484 8.21045C0.461426 9.94629 1.93359 11.0889 3.86719 11.0889ZM3.93311 5.72754C2.71729 5.72754 1.85303 4.86328 1.85303 3.65479C1.85303 2.47559 2.76123 1.57471 3.94043 1.57471C5.11963 1.57471 6.02783 2.49023 6.02783 3.68408C6.02783 4.86328 5.1416 5.72754 3.93311 5.72754Z");
        canvas.FillPath(vector83path);
        canvas.Translate(255.45352f, -435.83252f);
        var vector84Builder = new PathBuilder();
        var vector84path = vector84Builder.BuildPath("M11.243 10.9863C11.9388 10.9863 12.4148 10.4883 12.4148 9.8291C12.4148 9.1626 11.9388 8.67188 11.243 8.67188C10.5545 8.67188 10.0711 9.1626 10.0711 9.8291C10.0711 10.4883 10.5545 10.9863 11.243 10.9863ZM11.243 5.49316C11.9388 5.49316 12.4148 5.00244 12.4148 4.34326C12.4148 3.67676 11.9388 3.18604 11.243 3.18604C10.5545 3.18604 10.0711 3.67676 10.0711 4.34326C10.0711 5.00244 10.5545 5.49316 11.243 5.49316Z");
        canvas.FillPath(vector84path);
        canvas.Translate(255.45352f, -435.83252f);
        var vector85Builder = new PathBuilder();
        var vector85path = vector85Builder.BuildPath("M19.2706 10.8325L21.0797 10.8325L21.0797 8.8623L22.5079 8.8623L22.5079 7.26562L21.0797 7.26562L21.0797 0.263672L18.4137 0.263672C16.546 3.07617 15.0592 5.42725 14.107 7.17773L14.107 8.8623L19.2706 8.8623L19.2706 10.8325ZM15.8575 7.19971C17.088 5.03174 18.1866 3.2959 19.1974 1.80176L19.2999 1.80176L19.2999 7.30957L15.8575 7.30957L15.8575 7.19971Z");
        canvas.FillPath(vector85path);
        canvas.Translate(255.45352f, -435.83252f);
        var vector86Builder = new PathBuilder();
        var vector86path = vector86Builder.BuildPath("M26.5365 10.8325L28.4262 10.8325L28.4262 0.263672L26.5438 0.263672L23.7826 2.19727L23.7826 4.01367L26.412 2.16797L26.5365 2.16797L26.5365 10.8325Z");
        canvas.FillPath(vector86path);
        canvas.RestoreState();


        // View:     frameView55
        // NodeName: Notification
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14435
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(245, 245, 245);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(230f, -213f, 373f, 106f, 13f);
        canvas.RestoreState();


        // View:     frameView56
        // NodeName: Content
        // NodeType: FRAME
        // NodeId:   I65:1300;362:14435;362:16326
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView15
        // NodeName: Title
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14435;362:16327
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Semibold", 600, FontStyleType.Normal);
        canvas.FontSize = 15f;
        canvas.DrawString(@"Notification Title", 242f, -175f, 119f, 20f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView16
        // NodeName: Description
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14435;362:16328
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 15f;
        canvas.DrawString(@"Notification text would be placed right here. This is where notification text would be placed.", 242f, -153f, 333f, 40f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView57
        // NodeName: Right Item (Dots or Text)
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14435;362:16329
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView87
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14435;362:16331
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(142, 142, 147);
        canvas.Alpha = 1;
        canvas.Translate(568f, -193f);
        var vector87Builder = new PathBuilder();
        var vector87path = vector87Builder.BuildPath("M2.502 0C1.119 0 0 1.119 0 2.5C0 3.857 1.083 4.963 2.435 4.999L2.569 4.999C3.919 4.963 5.002 3.857 5.002 2.5C5.002 1.119 3.882 0 2.502 0");
        canvas.FillPath(vector87path);
        canvas.RestoreState();


        // View:     imageView88
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14435;362:16332
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(142, 142, 147);
        canvas.Alpha = 1;
        canvas.Translate(559.001f, -193f);
        var vector88Builder = new PathBuilder();
        var vector88path = vector88Builder.BuildPath("M2.5 0C1.118 0 0 1.119 0 2.5C0 3.857 1.082 4.963 2.433 4.999L2.567 4.999C3.918 4.963 5 3.857 5 2.5C5 1.119 3.882 0 2.5 0");
        canvas.FillPath(vector88path);
        canvas.RestoreState();


        // View:     imageView89
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1300;362:14435;362:16333
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(142, 142, 147);
        canvas.Alpha = 1;
        canvas.Translate(550f, -193f);
        var vector89Builder = new PathBuilder();
        var vector89path = vector89Builder.BuildPath("M2.5 0C1.119 0 0 1.119 0 2.5C0 3.857 1.083 4.963 2.433 4.999L2.567 4.999C3.919 4.963 5.003 3.857 5.003 2.5C5.003 1.119 3.882 0 2.5 0");
        canvas.FillPath(vector89path);
        canvas.RestoreState();


        // View:     textView17
        // NodeName: now
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14435;362:16334
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 13f;
        canvas.DrawString(@"now", 548f, -200f, 25f, 18f, HorizontalAlignment.Right, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView58
        // NodeName: App Icon + Name
        // NodeType: GROUP
        // NodeId:   I65:1300;362:14435;362:16335
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView18
        // NodeName: App Name
        // NodeType: TEXT
        // NodeId:   I65:1300;362:14435;362:16336
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 13f;
        canvas.DrawString(@"FIGMA", 266f, -202f, 41f, 18f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView59
        // NodeName: App Icon
        // NodeType: INSTANCE
        // NodeId:   I65:1300;362:14435;362:16337
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(55, 27, 27);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(240f, -203f, 20f, 20f, 4.3333335f);
        canvas.StrokeColor = Color.FromRgb(55, 27, 27);
        canvas.Alpha = 1;
        canvas.StrokeSize = 0;
        canvas.DrawRoundedRectangle(240f, -203f, 20f, 20f, 4.3333335f);
        canvas.RestoreState();


        // View:     rectangleView8
        // NodeName: Mask
        // NodeType: RECTANGLE
        // NodeId:   I65:1300;362:14435;362:16337;362:16290
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(240f, -203f, 20f, 20f, 4.3333335f);
        canvas.RestoreState();


        // View:     rectangleView9
        // NodeName: REPLACE ME
        // NodeType: RECTANGLE
        // NodeId:   I65:1300;362:14435;362:16337;362:16291
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(240f, -203f, 20f, 20f, 4.3333335f);
        canvas.RestoreState();


        // View:     frameView60
        // NodeName: Frame 12
        // NodeType: FRAME
        // NodeId:   65:1306
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(242, 248, 234);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(366f, -272f, 109.86667f, 51.93846f, 15.823729f);
        canvas.RestoreState();


        // View:     frameView61
        // NodeName: Frame 9
        // NodeType: FRAME
        // NodeId:   65:1307
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView62
        // NodeName: Zongzi(Chinese food)
        // NodeType: FRAME
        // NodeId:   72:1122
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView90
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1123
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(53, 154, 96);
        canvas.Alpha = 1;
        canvas.Translate(394.09314f, -251.58037f);
        var vector90Builder = new PathBuilder();
        var vector90path = vector90Builder.BuildPath("M0.00764625 0C0.00764625 0 10.4677 6.48227 9.22201 11.79C9.22201 11.79 -0.307469 8.58337 0.00764625 0Z");
        canvas.FillPath(vector90path);
        canvas.RestoreState();


        // View:     imageView91
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1124
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(393.47705f, -252.63063f);
        var vector91Builder = new PathBuilder();
        var vector91path = vector91Builder.BuildPath("M10.2624 13.6283L9.63274 13.421C9.53687 13.3932 -0.307438 9.9655 0.00739328 1.03652L0.0485201 0L0.92466 0.538877C1.36287 0.815473 11.7546 7.31177 10.3991 12.9786L10.2624 13.6283ZM1.23978 2.18357C1.67799 8.15473 7.33248 11.1263 9.33152 11.9833C9.38626 8.48659 4.22444 4.21567 1.23978 2.18357Z");
        canvas.FillPath(vector91path);
        canvas.RestoreState();


        // View:     imageView92
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1125
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(51, 172, 100);
        canvas.Alpha = 1;
        canvas.Translate(390.69153f, -249.65907f);
        var vector92Builder = new PathBuilder();
        var vector92path = vector92Builder.BuildPath("M0 0C0 0 2.57396 11.9695 13.5681 11.9695C13.582 11.9698 10.3097 0.138298 0 0Z");
        canvas.FillPath(vector92path);
        canvas.RestoreState();


        // View:     imageView93
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1126
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(389.93848f, -250.26724f);
        var vector93Builder = new PathBuilder();
        var vector93path = vector93Builder.BuildPath("M14.3212 13.1862C2.97105 13.1862 0.191735 0.871022 0.164223 0.746468L0 0L0.753044 0.013744C11.3912 0.152042 14.8689 12.3014 14.8964 12.426L15.1153 13.1999L14.3212 13.1862C14.3212 13.1862 14.3351 13.1862 14.3212 13.1862ZM1.54721 1.25786C2.28664 3.77328 5.23018 11.4584 13.4861 11.942C12.5686 9.44037 9.18685 1.85228 1.54721 1.25786Z");
        canvas.FillPath(vector93path);
        canvas.RestoreState();


        // View:     imageView94
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1127
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(53, 154, 96);
        canvas.Alpha = 1;
        canvas.Translate(402.92676f, -250.80612f);
        var vector94Builder = new PathBuilder();
        var vector94path = vector94Builder.BuildPath("M8.75384 0C8.75384 0 -1.36418 7.00769 0.155526 12.2461C0.155526 12.2458 9.5066 8.5556 8.75384 0Z");
        canvas.FillPath(vector94path);
        canvas.RestoreState();


        // View:     imageView95
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1128
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(402.32837f, -251.8982f);
        var vector95Builder = new PathBuilder();
        var vector95path = vector95Builder.BuildPath("M0.370431 14.1537L0.178696 13.5177C-1.45049 7.91994 8.58527 0.89851 9.00959 0.594425L9.8585 0L9.95436 1.03681C10.7346 9.93801 1.08235 13.8633 0.972867 13.9049L0.370431 14.1537ZM8.79062 2.25286C5.92906 4.43671 0.986481 8.97021 1.21906 12.4672C3.16364 11.4859 8.66753 8.22403 8.79062 2.25286Z");
        canvas.FillPath(vector95path);
        canvas.RestoreState();


        // View:     imageView96
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1129
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(51, 172, 100);
        canvas.Alpha = 1;
        canvas.Translate(403.80627f, -249.39622f);
        var vector96Builder = new PathBuilder();
        var vector96path = vector96Builder.BuildPath("M11.4478 0C11.4478 0 -0.669239 5.68054 0.029063 11.5687C0.0426774 11.5687 10.722 9.30178 11.4478 0Z");
        canvas.FillPath(vector96path);
        canvas.RestoreState();


        // View:     imageView97
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1130
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(403.21368f, -250.39151f);
        var vector97Builder = new PathBuilder();
        var vector97path = vector97Builder.BuildPath("M0.115077 13.2964L0.0328229 12.633C-0.706606 6.37175 11.2874 0.677175 11.7936 0.442097L12.7248 0L12.6425 1.03652C11.8895 10.6842 0.86812 13.1306 0.74474 13.1581L0.115077 13.2964ZM11.301 2.04556C8.63113 3.44142 1.51168 7.57434 1.21046 11.776C3.42818 11.1125 10.1236 8.59712 11.301 2.04556Z");
        canvas.FillPath(vector97path);
        canvas.RestoreState();


        // View:     imageView98
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1131
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(392.21622f, -256.03082f);
        var vector98Builder = new PathBuilder();
        var vector98path = vector98Builder.BuildPath("M10.5376 1.52042C11.1812 1.52042 11.8109 1.83825 12.1668 2.48794L19.3274 15.6878C19.9982 16.932 19.1084 18.4661 17.6982 18.4661L3.36343 18.4661C1.95321 18.4661 1.06317 16.9457 1.73425 15.6878L8.90873 2.48794C9.26412 1.83825 9.89378 1.52042 10.5376 1.52042ZM10.5376 0C9.30553 0 8.18263 0.677175 7.59381 1.75522L0.419612 14.9551C-0.155311 16.0194 -0.141696 17.2773 0.474353 18.3138C1.0904 19.3506 2.17218 19.9725 3.36315 19.9725L17.6979 19.9725C18.9028 19.9725 19.9843 19.3506 20.5867 18.3138C21.2028 17.2773 21.2167 16.0194 20.6415 14.9551L13.4812 1.75522C12.8923 0.663431 11.7561 0 10.5376 0Z");
        canvas.FillPath(vector98path);
        canvas.RestoreState();


        // View:     imageView99
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1132
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(249, 227, 158);
        canvas.Alpha = 1;
        canvas.Translate(399.05948f, -246.00754f);
        var vector99Builder = new PathBuilder();
        var vector99path = vector99Builder.BuildPath("M1.07898 1.07551C1.02424 1.07551 0.983114 1.07551 0.928373 1.06176C0.394577 0.992757 0.0794615 0.522601 0.0522328 0.467339C-0.043635 0.32904 -0.00250801 0.13548 0.134486 0.0527299C0.271197 -0.0440502 0.462933 -0.00253188 0.545187 0.135766C0.599928 0.218802 0.791663 0.426107 1.01091 0.467625C1.16152 0.481369 1.32574 0.426107 1.49025 0.274065C1.61334 0.163541 1.80508 0.177285 1.91456 0.301839C2.02404 0.426107 2.01043 0.619667 1.88733 0.730191C1.64057 0.964983 1.36659 1.07551 1.07898 1.07551Z");
        canvas.FillPath(vector99path);
        canvas.RestoreState();


        // View:     imageView100
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1133
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(250, 247, 189);
        canvas.Alpha = 1;
        canvas.Translate(393.2614f, -254.6676f);
        var vector100Builder = new PathBuilder();
        var vector100path = vector100Builder.BuildPath("M11.0941 0.931159L18.7201 14.2969C19.432 15.5407 18.5423 17.1026 17.1182 17.1026L1.85249 17.1026C0.428661 17.1026 -0.461377 15.5407 0.25054 14.2969L7.89018 0.944903C8.60238 -0.312667 10.3822 -0.312667 11.0941 0.931159Z");
        canvas.FillPath(vector100path);
        canvas.RestoreState();


        // View:     imageView101
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1134
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(58, 178, 108);
        canvas.Alpha = 1;
        canvas.Translate(392.46725f, -247.0881f);
        var vector101Builder = new PathBuilder();
        var vector101path = vector101Builder.BuildPath("M4.71406 0L0.25054 6.73109C-0.461377 7.97492 0.428661 9.53686 1.85249 9.53686L11.5187 9.52311C8.19168 7.60183 5.52184 1.53417 4.71406 0Z");
        canvas.FillPath(vector101path);
        canvas.RestoreState();


        // View:     imageView102
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1135
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(249, 227, 158);
        canvas.Alpha = 1;
        canvas.Translate(398.88165f, -246.00754f);
        var vector102Builder = new PathBuilder();
        var vector102path = vector102Builder.BuildPath("M1.29795 2.73423C1.24321 2.73423 1.20208 2.73423 1.14734 2.72048C0.613542 2.65119 0.298426 2.18132 0.271197 2.12606C0.175329 1.98776 0.216456 1.7942 0.353451 1.71145C0.490445 1.61467 0.68218 1.65619 0.76415 1.79449C0.818891 1.87752 1.01063 2.08483 1.22959 2.12635C1.3802 2.15412 1.54442 2.08483 1.70893 1.93279C1.83231 1.82226 2.02376 1.83601 2.13353 1.96056C2.24301 2.08483 2.2294 2.27839 2.10602 2.38891C1.85954 2.60967 1.58555 2.73423 1.29795 2.73423ZM1.07898 1.07551C1.02424 1.07551 0.983115 1.07551 0.928374 1.06176C0.394578 0.992758 0.0794616 0.522601 0.0522328 0.467339C-0.043635 0.329041 -0.00250801 0.13548 0.134487 0.0527299C0.271197 -0.0440503 0.462933 -0.00253188 0.545186 0.135766C0.599927 0.218803 0.791663 0.426107 1.01063 0.467625C1.16124 0.481369 1.32546 0.426107 1.48997 0.274065C1.61335 0.163541 1.8048 0.177285 1.91456 0.301839C2.02405 0.426107 2.01043 0.619667 1.88705 0.730191C1.62668 0.964984 1.35269 1.07551 1.07898 1.07551Z");
        canvas.FillPath(vector102path);
        canvas.RestoreState();


        // View:     imageView103
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1136
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(45, 149, 86);
        canvas.Alpha = 1;
        canvas.Translate(394.8124f, -245.07004f);
        var vector103Builder = new PathBuilder();
        var vector103path = vector103Builder.BuildPath("M7.59879 6.27497C2.79321 5.94339 0.109482 0.649402 0 0.414609L0.807784 0C0.835297 0.0552621 3.36813 5.05891 7.66715 5.34897L7.59879 6.27497Z");
        canvas.FillPath(vector103path);
        canvas.RestoreState();


        // View:     imageView104
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1137
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(45, 149, 86);
        canvas.Alpha = 1;
        canvas.Translate(393.63535f, -242.15375f);
        var vector104Builder = new PathBuilder();
        var vector104path = vector104Builder.BuildPath("M0.780272 5.07266L0 4.60279C0.0822534 4.47823 1.95791 1.38241 7.10584 0L7.33842 0.88448C2.53284 2.18385 0.793886 5.04488 0.780272 5.07266Z");
        canvas.FillPath(vector104path);
        canvas.RestoreState();


        // View:     imageView105
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1138
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(391.13058f, -248.41496f);
        var vector105Builder = new PathBuilder();
        var vector105path = vector105Builder.BuildPath("M5.90012 1.52042C5.94124 1.52042 5.99598 1.5482 6.0235 1.58943C7.0094 3.34464 9.4875 9.01172 12.8556 10.85L3.46315 10.85C1.95706 10.85 1.01228 9.28804 1.76533 8.04421L5.79063 1.58943C5.81786 1.54791 5.85899 1.52042 5.90012 1.52042ZM5.90012 0C5.32519 0 4.80473 0.290341 4.50379 0.7877L0.491816 7.24248L0.491816 7.25622C-0.137847 8.29275 -0.16536 9.5506 0.423461 10.6012C1.0259 11.6932 2.18964 12.3704 3.46315 12.3704L12.8553 12.3567L18.825 12.3567L13.5673 9.50937C11.1303 8.19625 9.049 4.14637 7.92638 1.97655C7.69381 1.53445 7.50207 1.14733 7.32395 0.843248C7.03635 0.317828 6.48865 0 5.90012 0Z");
        canvas.FillPath(vector105path);
        canvas.RestoreState();


        // View:     imageView106
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1139
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(58, 178, 108);
        canvas.Alpha = 1;
        canvas.Translate(400.95987f, -246.3004f);
        var vector106Builder = new PathBuilder();
        var vector106path = vector106Builder.BuildPath("M7.63992 0C5.54529 4.03585 0.848911 8.11321 0 8.73541L9.41971 8.73541C10.8438 8.73541 11.7472 7.17347 11.0217 5.92965L7.63992 0Z");
        canvas.FillPath(vector106path);
        canvas.RestoreState();


        // View:     imageView107
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1140
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(45, 149, 86);
        canvas.Alpha = 1;
        canvas.Translate(402.39758f, -243.84024f);
        var vector107Builder = new PathBuilder();
        var vector107path = vector107Builder.BuildPath("M0.219248 7.50533L0 6.62085C5.95571 5.08669 8.26958 0.0555484 8.29709 0L9.11878 0.373377C9.02291 0.594425 6.59927 5.86064 0.219248 7.50533Z");
        canvas.FillPath(vector107path);
        canvas.RestoreState();


        // View:     imageView108
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1141
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(45, 149, 86);
        canvas.Alpha = 1;
        canvas.Translate(406.91586f, -245.30511f);
        var vector108Builder = new PathBuilder();
        var vector108path = vector108Builder.BuildPath("M1.65669 8.66612L0.780556 8.45882C1.69782 4.45074 0.013898 0.400865 0 0.359347L0.835296 0C0.889753 0.179816 2.64231 4.36742 1.65669 8.66612Z");
        canvas.FillPath(vector108path);
        canvas.RestoreState();


        // View:     imageView109
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1142
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(249, 227, 158);
        canvas.Alpha = 1;
        canvas.Translate(401.92105f, -246.15958f);
        var vector109Builder = new PathBuilder();
        var vector109path = vector109Builder.BuildPath("M3.99529 1.07551C3.94055 1.07551 3.89942 1.07551 3.84468 1.06176C3.31088 0.992757 2.99577 0.522887 2.96854 0.467338C2.87267 0.329326 2.9138 0.135766 3.05079 0.0527299C3.1875 -0.0440503 3.37924 -0.00253188 3.46149 0.135766C3.51623 0.218803 3.70797 0.426106 3.92722 0.467338C4.07783 0.481082 4.24205 0.42582 4.40656 0.273778C4.52965 0.163254 4.72139 0.176998 4.83087 0.301552C4.94035 0.426107 4.92674 0.619381 4.80336 0.730192C4.5566 0.964984 4.28289 1.07551 3.99529 1.07551ZM1.07898 4.94557C1.02424 4.94557 0.983114 4.94557 0.928373 4.93183C0.394293 4.86282 0.0794615 4.39295 0.0522328 4.33769C-0.0436349 4.19939 -0.00250801 4.00583 0.134486 3.92308C0.271481 3.8263 0.463216 3.86782 0.545185 4.00612C0.599926 4.08915 0.791663 4.29646 1.01063 4.33797C1.16124 4.35172 1.32546 4.29646 1.48996 4.14441C1.61334 4.03389 1.8048 4.04763 1.91428 4.1719C2.02376 4.29646 2.01015 4.48973 1.88705 4.60054C1.62668 4.83505 1.35297 4.94557 1.07898 4.94557ZM4.03642 2.81698C3.98167 2.81698 3.94055 2.81698 3.88581 2.80323C3.35201 2.73423 3.0369 2.26436 3.00967 2.2091C2.9138 2.0708 2.95492 1.87724 3.09192 1.79449C3.22891 1.69771 3.42065 1.73923 3.50262 1.87752C3.55736 1.96056 3.7491 2.16786 3.96806 2.20938C4.11867 2.22313 4.28289 2.16786 4.4474 2.01582C4.57078 1.9053 4.76223 1.91904 4.872 2.04331C4.98148 2.16786 4.96786 2.36114 4.84448 2.47195C4.59772 2.69271 4.32373 2.81698 4.03642 2.81698Z");
        canvas.FillPath(vector109path);
        canvas.RestoreState();


        // View:     imageView110
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1143
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(396.11316f, -247.39218f);
        var vector110Builder = new PathBuilder();
        var vector110path = vector110Builder.BuildPath("M12.4866 1.50639C12.5961 1.50639 12.7059 1.56165 12.7742 1.65843L15.9642 7.0074C16.7037 8.25123 15.7725 9.81317 14.28 9.81317L4.86061 9.81317C5.70952 9.23277 10.4879 5.51447 12.1854 1.69967C12.2265 1.57568 12.3499 1.50639 12.4866 1.50639ZM12.4866 0C11.7608 0 11.1036 0.428639 10.8024 1.09207C9.32384 4.38174 4.99732 7.89245 3.9978 8.58337L0 11.3614L14.2664 11.3614C15.526 11.3614 16.6898 10.6842 17.2922 9.60615C17.881 8.54185 17.8671 7.29803 17.2375 6.24748L14.0475 0.898509C13.719 0.331858 13.1302 0 12.4866 0Z");
        canvas.FillPath(vector110path);
        canvas.RestoreState();


        // View:     imageView111
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1144
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(249, 227, 158);
        canvas.Alpha = 1;
        canvas.Translate(399.21008f, -253.83403f);
        var vector111Builder = new PathBuilder();
        var vector111path = vector111Builder.BuildPath("M2.74957 3.2627C2.69483 3.2627 2.62619 3.2627 2.57174 3.24895C2.03766 3.15217 1.75006 2.6823 1.70921 2.62704C1.62696 2.48903 1.66809 2.29547 1.81869 2.21243C1.95541 2.1294 2.14714 2.17091 2.22939 2.30921C2.28413 2.39225 2.46225 2.6133 2.68122 2.65482C2.83183 2.68259 2.99605 2.62704 3.16056 2.47529C3.28365 2.36476 3.47539 2.39225 3.58487 2.5168C3.69435 2.64136 3.66712 2.83463 3.54403 2.94544C3.28337 3.15217 3.02328 3.2627 2.74957 3.2627ZM3.76271 1.09287C3.70797 1.09287 3.63961 1.09287 3.58459 1.07913C3.05079 0.98235 2.76319 0.512479 2.72206 0.457217C2.63981 0.318919 2.68094 0.125359 2.81793 0.0426088C2.95492 -0.0404275 3.14666 0.00109075 3.22863 0.139389C3.28337 0.222425 3.46149 0.443474 3.68046 0.484992C3.83106 0.512766 3.99529 0.457504 4.15979 0.305175C4.28317 0.194651 4.47463 0.222139 4.58439 0.346693C4.69387 0.471248 4.66665 0.664522 4.54327 0.775046C4.2965 0.982064 4.03641 1.09287 3.76271 1.09287ZM5.20016 3.20744C5.14542 3.20744 5.07706 3.20744 5.02232 3.19369C4.48852 3.09691 4.20092 2.62704 4.15979 2.57178C4.07754 2.43348 4.11895 2.23992 4.26928 2.15717C4.40627 2.07413 4.59801 2.11594 4.67998 2.25395C4.73472 2.33699 4.91255 2.55803 5.1318 2.59955C5.28241 2.62704 5.44663 2.57178 5.61114 2.41974C5.73452 2.30921 5.92597 2.3367 6.03574 2.46125C6.14522 2.58581 6.11799 2.77908 5.99461 2.88989C5.73424 3.09691 5.47415 3.20744 5.20016 3.20744ZM5.00842 5.25299C4.52908 5.25299 4.15951 4.92142 4.11867 4.8799C3.99529 4.76938 3.99529 4.57582 4.10505 4.45155C4.21453 4.32699 4.40627 4.32699 4.52937 4.4378C4.59801 4.50681 4.83058 4.65885 5.04955 4.64511C5.20016 4.63136 5.33715 4.52055 5.46025 4.34102C5.55612 4.20273 5.74785 4.17495 5.88456 4.27173C6.02156 4.36851 6.04907 4.56207 5.9532 4.70037C5.72034 5.03223 5.43274 5.22579 5.10429 5.25328L5.00842 5.25328L5.00842 5.25299ZM1.84592 5.12872C1.66808 5.12872 1.51748 5.0872 1.36658 5.00417C0.887246 4.75535 0.750535 4.20244 0.736921 4.14718C0.695794 3.9811 0.791662 3.81532 0.956169 3.7738C1.12039 3.73257 1.28461 3.82906 1.31213 3.99514C1.33964 4.09192 1.43551 4.35448 1.64086 4.45126C1.77757 4.52027 1.94207 4.50652 2.14742 4.42349C2.29803 4.36823 2.47615 4.43723 2.54451 4.58927C2.59925 4.74132 2.53089 4.92113 2.38029 4.99014C2.18827 5.10124 2.01015 5.12872 1.84592 5.12872ZM6.30916 6.98072C5.85733 6.98072 5.51499 6.70441 5.47415 6.66289C5.35077 6.55237 5.32354 6.35881 5.43302 6.23425C5.5425 6.1097 5.72062 6.08221 5.85762 6.19302C5.92597 6.24828 6.17245 6.40032 6.39141 6.3588C6.54202 6.33103 6.66512 6.22051 6.7885 6.02695C6.87075 5.88893 7.0622 5.83339 7.1992 5.93017C7.33591 6.0132 7.39093 6.20648 7.29506 6.34477C7.08972 6.69038 6.81573 6.89768 6.48728 6.95294C6.43254 6.96697 6.3778 6.98072 6.30916 6.98072ZM3.80384 7.27106C3.74909 7.27106 3.70797 7.27106 3.65323 7.25732C3.11915 7.18802 2.80432 6.71815 2.77709 6.66289C2.68122 6.52459 2.72235 6.33103 2.85934 6.24828C2.99605 6.1515 3.18779 6.19302 3.27004 6.33132C3.32478 6.41435 3.51652 6.62166 3.73548 6.66318C3.88609 6.67692 4.05031 6.62166 4.21482 6.46962C4.33791 6.35909 4.52965 6.37284 4.63913 6.4971C4.74861 6.62166 4.735 6.81493 4.6119 6.92574C4.35125 7.16053 4.07754 7.27106 3.80384 7.27106ZM3.69407 8.833C3.63933 8.833 3.5982 8.833 3.54346 8.81926C3.00938 8.74996 2.69455 8.28009 2.66732 8.22483C2.57145 8.08653 2.61258 7.89297 2.74957 7.81022C2.88657 7.71344 3.0783 7.75496 3.16027 7.89326C3.21502 7.97629 3.40675 8.1836 3.62571 8.22512C3.77632 8.23886 3.94055 8.1836 4.10505 8.03156C4.22843 7.92103 4.41989 7.93478 4.52937 8.05904C4.63885 8.1836 4.62523 8.37687 4.50214 8.48768C4.24176 8.72248 3.96806 8.833 3.69407 8.833ZM3.7352 10.7265C3.68046 10.7265 3.63933 10.7265 3.58459 10.7128C3.05079 10.6438 2.73568 10.1739 2.70845 10.1183C2.61258 9.98033 2.65371 9.78677 2.7907 9.70374C2.92741 9.60695 3.11915 9.64847 3.2014 9.78677C3.25614 9.86981 3.44788 10.0771 3.66684 10.1183C3.81745 10.1321 3.98167 10.0768 4.14618 9.92478C4.26956 9.81426 4.46101 9.828 4.57078 9.95256C4.68026 10.0771 4.66665 10.2704 4.54327 10.3809C4.28289 10.616 4.0228 10.7265 3.7352 10.7265ZM1.07898 7.13276C1.02424 7.13276 0.983114 7.13276 0.928373 7.11902C0.394294 7.05001 0.0794618 6.58014 0.0522331 6.52459C-0.0436346 6.38658 -0.00250875 6.19302 0.134486 6.10998C0.27148 6.0132 0.463216 6.05472 0.545186 6.19302C0.599927 6.27606 0.791662 6.48336 1.01063 6.52459C1.16123 6.53834 1.32546 6.48307 1.48996 6.33103C1.61334 6.22051 1.8048 6.23425 1.91456 6.3588C2.02404 6.48336 2.01043 6.67663 1.88705 6.78716C1.64057 7.00849 1.36658 7.13276 1.07898 7.13276Z");
        canvas.FillPath(vector111path);
        canvas.RestoreState();


        // View:     textView19
        // NodeName: Vege
        // NodeType: TEXT
        // NodeId:   65:1309
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 11.969229698181152f;
        canvas.DrawString(@"Vege", 419.92822f, -260.03082f, 32f, 28f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView63
        // NodeName: Frame 13
        // NodeType: FRAME
        // NodeId:   65:1310
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 241, 241);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(477.78973f, -272.11798f, 126.86664f, 51.93846f, 15.823729f);
        canvas.RestoreState();


        // View:     frameView64
        // NodeName: Frame 10
        // NodeType: FRAME
        // NodeId:   65:1311
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView65
        // NodeName: Cake
        // NodeType: FRAME
        // NodeId:   72:1093
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView112
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1094
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 231, 184);
        canvas.Alpha = 1;
        canvas.Translate(502.51932f, -248.48372f);
        var vector112Builder = new PathBuilder();
        var vector112path = vector112Builder.BuildPath("M0 0L0 10.3059C0 12.6581 4.57953 14.5615 10.2087 14.5615C15.8534 14.5615 20.4175 12.6581 20.4175 10.3059L20.4175 0L0 0Z");
        canvas.FillPath(vector112path);
        canvas.RestoreState();


        // View:     imageView113
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1095
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(249, 204, 145);
        canvas.Alpha = 1;
        canvas.Translate(502.6868f, -242.00067f);
        var vector113Builder = new PathBuilder();
        var vector113path = vector113Builder.BuildPath("M0.16721 2.3682C0.16721 2.3682 2.55605 0.10894 4.33585 2.3682C6.11595 4.62747 7.42447 4.72037 9.46313 3.83827C11.4869 2.95617 12.5517 1.3003 14.4991 2.75494C16.6594 4.3642 17.7704 4.5963 19.6263 2.47623L19.6263 1.00617L17.1768 1.9966L13.8906 1.00617L10.6044 1.51667L7.68332 2.80093L2.99728 0L0 1.00647L0.16721 2.3682Z");
        canvas.FillPath(vector113path);
        canvas.RestoreState();


        // View:     imageView114
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1096
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(501.74365f, -249.00995f);
        var vector114Builder = new PathBuilder();
        var vector114path = vector114Builder.BuildPath("M10.9847 15.8611C5.65955 15.8611 0 14.1127 0 10.9093L0 0.789199C0 0.355865 0.334717 0 0.775949 0L21.2089 0C21.6349 0 21.9848 0.340432 21.9848 0.789199L21.9848 10.8939C21.9694 14.1127 16.3095 15.8611 10.9847 15.8611ZM1.53643 1.5784L1.53643 10.9093C1.53643 12.5031 5.58368 14.2982 10.9847 14.2982C16.3857 14.2982 20.4329 12.5031 20.4329 10.9093L20.4329 1.5784L1.53643 1.5784Z");
        canvas.FillPath(vector114path);
        canvas.RestoreState();


        // View:     imageView115
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1097
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 100, 100);
        canvas.Alpha = 1;
        canvas.Translate(502.51932f, -247.75656f);
        var vector115Builder = new PathBuilder();
        var vector115path = vector115Builder.BuildPath("M0 6.88613C0 6.88613 2.55605 4.70433 4.41202 6.12779C6.26829 7.55156 6.57236 9.25342 8.80916 8.46422C11.0457 7.67502 12.5062 4.87409 16.3405 7.78336C18.3181 9.28429 20.4178 5.53953 20.4178 4.33243L20.4178 0L0 0L0 6.88613Z");
        canvas.FillPath(vector115path);
        canvas.RestoreState();


        // View:     imageView116
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1098
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 222, 199);
        canvas.Alpha = 1;
        canvas.Translate(502.6868f, -244.41396f);
        var vector116Builder = new PathBuilder();
        var vector116path = vector116Builder.BuildPath("M0 0.587966C0 0.912664 0.210946 1.17593 0.47158 1.17593C0.731915 1.17593 0.943159 0.912664 0.943159 0.587966C0.943159 0.263269 0.732213 0 0.47158 0C0.210946 -2.15015e-15 0 0.262966 0 0.587966Z");
        canvas.FillPath(vector116path);
        canvas.RestoreState();


        // View:     imageView117
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1099
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(501.72818f, -248.54576f);
        var vector117Builder = new PathBuilder();
        var vector117path = vector117Builder.BuildPath("M8.56579 10.2442C7.36378 10.2442 6.664 9.48582 5.97939 8.74323C5.61432 8.34106 5.23379 7.93859 4.73186 7.55186C3.40817 6.53056 1.29335 8.26359 1.263 8.27903C1.0348 8.48026 0.715254 8.51113 0.441529 8.38736C0.16721 8.24786 0 7.96946 0 7.67533L0 0.789199C0 0.355865 0.334717 0 0.775949 0L21.2089 0C21.6349 0 21.9848 0.340432 21.9848 0.789199L21.9848 5.12193C21.9848 6.25156 20.798 8.61916 19.2309 9.43922C18.3636 9.88799 17.4508 9.79509 16.6749 9.22256C14.2557 7.38089 13.0843 8.12379 11.6238 9.05219C11.076 9.40806 10.5131 9.77935 9.84366 10.0115C9.37208 10.1667 8.94603 10.2442 8.56579 10.2442ZM3.77323 5.66359C4.39714 5.66359 5.06658 5.8494 5.67502 6.29816C6.28346 6.76236 6.72469 7.2423 7.1204 7.65989C7.95735 8.55743 8.26171 8.89786 9.37208 8.51113C9.85913 8.32563 10.3459 8.03119 10.8329 7.72193C12.4 6.71636 14.3473 5.46266 17.6338 7.95403C17.9382 8.18613 18.2119 8.20156 18.577 8.01606C19.6115 7.48983 20.4787 5.64846 20.4787 5.1068L20.4787 1.5784L1.5519 1.5784L1.5519 6.2673C2.16034 5.9423 2.93659 5.66359 3.77323 5.66359Z");
        canvas.FillPath(vector117path);
        canvas.RestoreState();


        // View:     imageView118
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1100
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 113, 113);
        canvas.Alpha = 1;
        canvas.Translate(502.51932f, -251.42384f);
        var vector118Builder = new PathBuilder();
        var vector118path = vector118Builder.BuildPath("M0 3.49723C0 5.42877 4.5706 6.99446 10.2087 6.99446C15.8469 6.99446 20.4175 5.42877 20.4175 3.49723C20.4175 1.56569 15.8471 0 10.209 0C4.5709 0 0 1.56569 0 3.49723Z");
        canvas.FillPath(vector118path);
        canvas.RestoreState();


        // View:     imageView119
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1101
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(501.74365f, -252.19762f);
        var vector119Builder = new PathBuilder();
        var vector119path = vector119Builder.BuildPath("M10.9847 8.55712C5.53786 8.55712 0 7.08706 0 4.28643C0 1.4855 5.53816 0 10.9847 0C16.4315 0 21.9694 1.47006 21.9694 4.271C21.9694 7.07163 16.4312 8.55712 10.9847 8.55712ZM10.9847 1.54753C5.21832 1.54753 1.53643 3.1568 1.53643 4.25556C1.53643 5.35433 5.20314 6.97903 10.9847 6.97903C16.751 6.97903 20.4329 5.36976 20.4329 4.271C20.4329 3.1568 16.7356 1.54753 10.9847 1.54753Z");
        canvas.FillPath(vector119path);
        canvas.RestoreState();


        // View:     imageView120
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1102
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 222, 199);
        canvas.Alpha = 1;
        canvas.Translate(509.80692f, -242.8665f);
        var vector120Builder = new PathBuilder();
        var vector120path = vector120Builder.BuildPath("M0 0.588042C0 0.798052 0.110382 0.992325 0.289196 1.09733C0.468009 1.20234 0.688477 1.20234 0.86729 1.09733C1.0461 0.992325 1.15649 0.798052 1.15649 0.588042C1.15649 0.378032 1.0461 0.183759 0.86729 0.0787537C0.688477 -0.0262512 0.468009 -0.0262512 0.289196 0.0787537C0.110382 0.183759 0 0.37773 0 0.588042Z");
        canvas.FillPath(vector120path);
        canvas.RestoreState();


        // View:     imageView121
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1103
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 222, 199);
        canvas.Alpha = 1;
        canvas.Translate(519.6354f, -243.6402f);
        var vector121Builder = new PathBuilder();
        var vector121path = vector121Builder.BuildPath("M0 0.587966C0 0.912664 0.258849 1.17593 0.578095 1.17593C0.897342 1.17593 1.15619 0.912664 1.15619 0.587966C1.15619 0.263269 0.897342 2.60607e-07 0.578095 2.60607e-07C0.258849 -0.000302347 0 0.262966 0 0.587966Z");
        canvas.FillPath(vector121path);
        canvas.RestoreState();


        // View:     imageView122
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1104
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(122, 72, 38);
        canvas.Alpha = 1;
        canvas.Translate(514.2496f, -258.6762f);
        var vector122Builder = new PathBuilder();
        var vector122path = vector122Builder.BuildPath("M4.3665 0.381662L0 9.61995L1.76463 9.71285L5.8577 1.12456C6.04008 0.768696 5.84253 0.304497 5.41647 0.103263C5.02076 -0.113403 4.54918 0.025796 4.3665 0.381662Z");
        canvas.FillPath(vector122path);
        canvas.RestoreState();


        // View:     imageView123
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1105
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(513.795f, -259.1489f);
        var vector123Builder = new PathBuilder();
        var vector123path = vector123Builder.BuildPath("M2.21952 10.6498L2.18917 10.6498L0.424245 10.5569C0.257035 10.5414 0.135346 10.464 0.0591793 10.3248C-0.0169875 10.1856 -0.0169871 10.0309 0.0440058 9.87599L4.4105 0.637694C4.54737 0.374728 4.7604 0.158061 5.06477 0.065161C5.38431 -0.0431724 5.76455 -0.0123065 6.08409 0.127195C6.708 0.436762 7.01208 1.17936 6.73835 1.76763L2.61523 10.3711C2.55424 10.5569 2.4022 10.6498 2.21952 10.6498ZM1.16985 9.64389L1.93062 9.69049L5.90171 1.3809C5.94723 1.27256 5.88653 1.08707 5.68868 0.978732C5.58216 0.93213 5.46048 0.917 5.36913 0.947866C5.33879 0.963299 5.27779 0.994467 5.26262 1.04077L1.16985 9.64389Z");
        canvas.FillPath(vector123path);
        canvas.RestoreState();


        // View:     imageView124
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1106
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(122, 72, 38);
        canvas.Alpha = 1;
        canvas.Translate(513.5491f, -257.41736f);
        var vector124Builder = new PathBuilder();
        var vector124path = vector124Builder.BuildPath("M0.000752301 0.871565L0.213781 9.22776L1.73533 8.60893L1.55265 0.809531C1.55265 0.484531 1.32445 -0.0571361 0.761527 0.00489838C0.198607 0.0666302 -0.0144215 0.531132 0.000752301 0.871565Z");
        canvas.FillPath(vector124path);
        canvas.RestoreState();


        // View:     imageView125
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1107
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(513.07776f, -257.8677f);
        var vector125Builder = new PathBuilder();
        var vector125path = vector125Builder.BuildPath("M0.685046 10.1423C0.608879 10.1423 0.502662 10.1115 0.426495 10.0649C0.289633 9.9874 0.213465 9.83276 0.213465 9.69357L0.000436501 1.33737C-0.0147373 0.749409 0.365501 0.0839764 1.1721 0.00650903C1.49164 -0.0243569 1.79601 0.0531105 2.02421 0.269777C2.32858 0.548176 2.46544 0.981509 2.46544 1.27534L2.64783 9.07443C2.64783 9.27567 2.54131 9.44573 2.35893 9.5232L0.837081 10.1423C0.791559 10.1266 0.730567 10.1423 0.685046 10.1423ZM0.928421 1.30651L1.12628 8.99727L1.71984 8.74973L1.55233 1.27534C1.55233 1.18244 1.50681 1.02781 1.41547 0.965773C1.38512 0.950341 1.35448 0.919474 1.26344 0.934907C0.95877 0.965773 0.928421 1.22904 0.928421 1.30651Z");
        canvas.FillPath(vector125path);
        canvas.RestoreState();


        // View:     imageView126
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1108
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(109, 80, 48);
        canvas.Alpha = 1;
        canvas.Translate(505.02982f, -255.74115f);
        var vector126Builder = new PathBuilder();
        var vector126path = vector126Builder.BuildPath("M0 1.28426L3.72741 7.95342L6.64853 7.95342L8.61131 6.05002L4.83808 0L0 1.28426Z");
        canvas.FillPath(vector126path);
        canvas.RestoreState();


        // View:     imageView127
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1109
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(504.5468f, -256.21896f);
        var vector127Builder = new PathBuilder();
        var vector127path = vector127Builder.BuildPath("M7.13153 8.88031L4.21041 8.88031C4.0432 8.88031 3.89087 8.80284 3.79953 8.64821L0.0569451 1.99418C-0.00375028 1.85498 -0.0192217 1.71548 0.0265973 1.57628C0.0724164 1.43708 0.194105 1.34418 0.330967 1.29758L5.18422 0.013315C5.38207 -0.0332865 5.5951 0.0444835 5.68615 0.214549L9.47455 6.26487C9.58107 6.45068 9.55072 6.71364 9.41386 6.85284L7.45107 8.75624C7.3752 8.83401 7.25322 8.88031 7.13153 8.88031ZM4.49961 7.95191L6.96432 7.95191L8.50075 6.45098L5.10805 1.01948L1.18279 2.07165L4.49961 7.95191Z");
        canvas.FillPath(vector127path);
        canvas.RestoreState();


        // View:     imageView128
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1110
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(86, 45, 32);
        canvas.Alpha = 1;
        canvas.Translate(506.5511f, -254.54977f);
        var vector128Builder = new PathBuilder();
        var vector128path = vector128Builder.BuildPath("M0 0.773766L0.639087 1.96513L3.5602 1.1605L2.84495 0L0 0.773766Z");
        canvas.FillPath(vector128path);
        canvas.RestoreState();


        // View:     imageView129
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1111
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(506.22534f, -254.89948f);
        var vector129Builder = new PathBuilder();
        var vector129path = vector129Builder.BuildPath("M0.964828 2.62439C0.858313 2.62439 0.751799 2.56235 0.690806 2.45402L0.0365452 1.24692C-0.00927392 1.16976 -0.00927382 1.06142 0.0213714 0.968522C0.0517191 0.891054 0.127886 0.813889 0.2344 0.783023L3.07935 0.00925736C3.21621 -0.0216086 3.35337 0.0246903 3.41407 0.148457L4.12902 1.30895C4.17484 1.38642 4.19001 1.49445 4.15937 1.58735C4.12902 1.68025 4.05286 1.75772 3.94634 1.77315L1.05557 2.57779C1.04099 2.62439 0.995175 2.62439 0.964828 2.62439ZM0.782444 1.30926L1.11716 1.94382L3.38402 1.30926L3.00378 0.705556L0.782444 1.30926Z");
        canvas.FillPath(vector129path);
        canvas.RestoreState();


        // View:     imageView130
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1112
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(86, 45, 32);
        canvas.Alpha = 1;
        canvas.Translate(507.85962f, -252.41399f);
        var vector130Builder = new PathBuilder();
        var vector130path = vector130Builder.BuildPath("M0 0.773464L0.669435 1.96513L3.5602 1.1605L2.84525 0L0 0.773464Z");
        canvas.FillPath(vector130path);
        canvas.RestoreState();


        // View:     imageView131
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1113
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(507.5645f, -252.74854f);
        var vector131Builder = new PathBuilder();
        var vector131path = vector131Builder.BuildPath("M0.96453 2.62439C0.858016 2.62439 0.751501 2.56235 0.690806 2.45402L0.0365453 1.24722C-0.00927376 1.16976 -0.00927394 1.04599 0.0213713 0.968522C0.051719 0.891054 0.127886 0.81389 0.2344 0.783024L3.06447 0.00925733C3.20133 -0.0216086 3.3382 0.0246906 3.39919 0.148457L4.11415 1.30895C4.15967 1.38642 4.17484 1.49445 4.14449 1.58735C4.11415 1.68025 4.03798 1.75772 3.93147 1.77315L1.0407 2.57779C1.01005 2.62439 0.979704 2.62439 0.96453 2.62439ZM0.766675 1.30926L1.10139 1.94382L3.36854 1.30926L3.00348 0.705859L0.766675 1.30926Z");
        canvas.FillPath(vector131path);
        canvas.RestoreState();


        // View:     imageView132
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1114
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(86, 45, 32);
        canvas.Alpha = 1;
        canvas.Translate(508.9551f, -250.34082f);
        var vector132Builder = new PathBuilder();
        var vector132path = vector132Builder.BuildPath("M0 0.758333L0.669434 1.96543L3.5602 1.14506L2.84524 0L0 0.758333Z");
        canvas.FillPath(vector132path);
        canvas.RestoreState();


        // View:     imageView133
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1115
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(508.66f, -250.67477f);
        var vector133Builder = new PathBuilder();
        var vector133path = vector133Builder.BuildPath("M0.964531 2.62439C0.858016 2.62439 0.751502 2.56235 0.690806 2.45402L0.036545 1.24722C-0.00927409 1.16976 -0.0092737 1.06142 0.0213715 0.968522C0.0517192 0.891055 0.127886 0.81389 0.2344 0.783024L3.07935 0.00925739C3.21621 -0.0216085 3.35337 0.0246901 3.41407 0.148456L4.12902 1.30895C4.17484 1.38642 4.19002 1.49445 4.15937 1.58735C4.12902 1.68025 4.05286 1.75772 3.94634 1.77315L1.05557 2.57779C1.01005 2.62439 0.979705 2.62439 0.964531 2.62439ZM0.766675 1.30895L1.10139 1.94352L3.36825 1.30895L3.00318 0.690124L0.766675 1.30895Z");
        canvas.FillPath(vector133path);
        canvas.RestoreState();


        // View:     imageView134
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1116
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(251, 255, 166);
        canvas.Alpha = 1;
        canvas.Translate(512.2568f, -251.7644f);
        var vector134Builder = new PathBuilder();
        var vector134path = vector134Builder.BuildPath("M6.26829 3.18779C6.26829 4.95168 4.85325 4.81248 3.13414 4.81248C1.39956 4.81248 0 4.95168 0 3.18779C0 1.42359 1.41504 0.000122972 3.13414 0.000122972C4.85325 -0.01531 6.26829 1.42389 6.26829 3.18779Z");
        canvas.FillPath(vector134path);
        canvas.RestoreState();


        // View:     imageView135
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1117
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(511.76968f, -252.22849f);
        var vector135Builder = new PathBuilder();
        var vector135path = vector135Builder.BuildPath("M2.96693 5.75619C1.94761 5.75619 1.09549 5.70989 0.517398 5.15279C0.182681 4.81236 0 4.3173 0 3.65186C0 1.6247 1.61289 0 3.59055 0C5.58368 0 7.1811 1.64043 7.1811 3.65186C7.1811 4.3173 7.01359 4.7815 6.6637 5.15279C6.05496 5.77163 5.06628 5.77163 3.90979 5.75619L2.96693 5.75619ZM3.60572 4.81236L3.94044 4.81236C4.8836 4.81236 5.70537 4.82779 6.04008 4.47193C6.20759 4.30186 6.28346 4.03859 6.28346 3.65186C6.28346 2.15093 5.08145 0.943832 3.6209 0.943832C2.16034 0.943832 0.958333 2.15093 0.958333 3.65186C0.958333 4.05403 1.0345 4.3173 1.20171 4.47193C1.53643 4.81236 2.37307 4.81236 3.30135 4.81236L3.60572 4.81236Z");
        canvas.FillPath(vector135path);
        canvas.RestoreState();


        // View:     imageView136
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1118
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 100, 163);
        canvas.Alpha = 1;
        canvas.Translate(509.83755f, -250.27878f);
        var vector136Builder = new PathBuilder();
        var vector136path = vector136Builder.BuildPath("M5.37065 2.7389C5.37065 4.25526 4.16864 4.13149 2.67774 4.13149C1.18683 4.13149 0 4.23983 0 2.7389C0 1.23796 1.20201 0 2.69291 0C4.18382 1.07508e-15 5.37065 1.22253 5.37065 2.7389Z");
        canvas.FillPath(vector136path);
        canvas.RestoreState();


        // View:     imageView137
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1119
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(76, 47, 27);
        canvas.Alpha = 1;
        canvas.Translate(509.38116f, -250.74298f);
        var vector137Builder = new PathBuilder();
        var vector137path = vector137Builder.BuildPath("M3.68189 5.0602L2.86042 5.0602C1.85627 5.0602 1.00415 5.07563 0.456406 4.51853C0.152036 4.20896 0 3.77593 0 3.2031C0 1.42377 1.41504 0 3.13414 0C4.85325 0 6.28346 1.4389 6.28346 3.2031C6.28346 3.77563 6.13143 4.20896 5.82706 4.51853C5.34 5.02903 4.57953 5.0602 3.68189 5.0602ZM3.13414 4.11606L3.42334 4.11606C4.18411 4.11606 4.89937 4.11606 5.17309 3.83736C5.30996 3.69816 5.37095 3.49693 5.37095 3.17193C5.37095 1.91853 4.3668 0.912663 3.14961 0.912663C1.91726 0.912663 0.928282 1.93396 0.928282 3.17193C0.928282 3.48149 0.988978 3.69816 1.12614 3.83736C1.39986 4.11606 2.11512 4.11606 2.87559 4.11606L3.13414 4.11606Z");
        canvas.FillPath(vector137path);
        canvas.RestoreState();


        // View:     imageView138
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1120
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(516.3189f, -249.98495f);
        var vector138Builder = new PathBuilder();
        var vector138path = vector138Builder.BuildPath("M0 0.634567C0 0.984986 0.279377 1.26913 0.623913 1.26913C0.968449 1.26913 1.24783 0.984986 1.24783 0.634567C1.24783 0.284148 0.968449 0 0.623913 0C0.27908 0.000302607 0 0.284148 0 0.634567Z");
        canvas.FillPath(vector138path);
        canvas.RestoreState();


        // View:     imageView139
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   72:1121
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(512.72833f, -248.97879f);
        var vector139Builder = new PathBuilder();
        var vector139path = vector139Builder.BuildPath("M0 0.603399C0 0.818856 0.113061 1.01827 0.296635 1.126C0.480209 1.23403 0.706329 1.23403 0.889903 1.126C1.07348 1.01827 1.18654 0.819158 1.18654 0.603399C1.18654 0.38764 1.07348 0.188524 0.889903 0.0807962C0.706329 -0.026932 0.480209 -0.026932 0.296635 0.0807962C0.113061 0.188524 0 0.38764 0 0.603399Z");
        canvas.FillPath(vector139path);
        canvas.RestoreState();


        // View:     textView20
        // NodeName: Desserts
        // NodeType: TEXT
        // NodeId:   65:1313
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 11.969229698181152f;
        canvas.DrawString(@"Desserts", 527.7179f, -260.1488f, 53f, 28f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     rectangleView10
        // NodeName: image 4
        // NodeType: RECTANGLE
        // NodeId:   65:1405
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(501f, -107f, 113f, 80f, 15.82f);
        canvas.RestoreState();


        // View:     rectangleView11
        // NodeName: image 3
        // NodeType: RECTANGLE
        // NodeId:   65:1407
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(372f, -107f, 113f, 80f, 15.82f);
        canvas.RestoreState();


        // View:     textView21
        // NodeName: Guacamole
        // NodeType: TEXT
        // NodeId:   65:1406
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(171, 171, 171);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.021550178527832f;
        canvas.DrawString(@"Guacamole", 525f, -26f, 60f, 24f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView22
        // NodeName: Thai soup
        // NodeType: TEXT
        // NodeId:   65:1408
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(171, 171, 171);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.021550178527832f;
        canvas.DrawString(@"Thai soup", 401f, -26f, 50f, 24f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView23
        // NodeName: Pesto Pasta
        // NodeType: TEXT
        // NodeId:   65:1404
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(171, 171, 171);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.021550178527832f;
        canvas.DrawString(@"Pesto Pasta", 267f, -26f, 60f, 24f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     rectangleView12
        // NodeName: istockphoto-1273255620-170667a 1
        // NodeType: RECTANGLE
        // NodeId:   65:1403
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView13
        // NodeName: 2729063 2
        // NodeType: RECTANGLE
        // NodeId:   65:1402
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(400f, 311f, 33f, 33f, 0f);
        canvas.RestoreState();


        // View:     frameView66
        // NodeName: Splash
        // NodeType: FRAME
        // NodeId:   65:1314
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 222, 169);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(-196f, -444.27274f, 388.82355f, 841.27277f, 37.52541f);
        canvas.RestoreState();


        // View:     frameView67
        // NodeName: Frame 1
        // NodeType: FRAME
        // NodeId:   65:1315
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView24
        // NodeName: Virtual cookbook 
        // enter the ingredients and we will give you the recipe!
        // NodeType: TEXT
        // NodeId:   65:1316
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(87, 87, 87);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-Medium", 500, FontStyleType.Normal);
        canvas.FontSize = 15.010162353515625f;
        canvas.DrawString(@"Virtual cookbook 
enter the ingredients and we will give you the recipe!", -140f, 95.99997f, 276.7499f, 74f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView25
        // NodeName: Forgot password?
        // NodeType: TEXT
        // NodeId:   65:1317
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(87, 87, 87);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-Medium", 500, FontStyleType.Normal);
        canvas.FontSize = 12f;
        canvas.DrawString(@"Forgot password?", -139f, 320.99997f, 276.7499f, 25f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView68
        // NodeName: Frame 2
        // NodeType: FRAME
        // NodeId:   65:1318
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(-126f, 184.99997f, 250f, 52.89659f, 22.515244f);
        canvas.RestoreState();


        // View:     textView26
        // NodeName: Sign up
        // NodeType: TEXT
        // NodeId:   65:1319
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.010162353515625f;
        canvas.DrawString(@"Sign up", -54.70173f, 200.94827f, 106f, 21f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView69
        // NodeName: Frame 3
        // NodeType: FRAME
        // NodeId:   65:1320
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(-126f, 253.99997f, 250f, 55f, 22.515244f);
        canvas.StrokeColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.DrawRoundedRectangle(-126f, 253.99997f, 250f, 55f, 22.515244f);
        canvas.RestoreState();


        // View:     textView27
        // NodeName: sd
        // NodeType: TEXT
        // NodeId:   65:1321
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.010162353515625f;
        canvas.DrawString(@"Login", -44f, 269.99997f, 87f, 21f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     rectangleView14
        // NodeName: image 2
        // NodeType: RECTANGLE
        // NodeId:   65:1322
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(-247f, -288f, 491f, 369f, 0f);
        canvas.RestoreState();


        // View:     frameView70
        // NodeName: Status Bar, Time, Date
        // NodeType: GROUP
        // NodeId:   65:1323
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView140
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1325
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(-69.66406f, -326.22656f);
        var vector140Builder = new PathBuilder();
        var vector140path = vector140Builder.BuildPath("M1.40625 45C1.28906 44.375 1.64062 44.0625 2.10938 44.0625L4.02344 44.0625C4.60938 44.0625 4.84375 44.3359 5 44.8047C6.32812 50.5469 11.5625 54.8828 18.9062 54.8828C29.6094 54.8828 35.7812 44.8438 36.2891 28.8281C36.3281 27.7734 36.2891 26.4844 36.2891 25.3516L36.1719 25.3516C34.3359 32.3047 27.0703 37.7344 18.7109 37.7344C7.92969 37.7344 0 29.8438 0 19.4141C0 8.32031 8.08594 0 19.1406 0C25.7031 0 31.1328 2.96875 34.6094 8.04688C37.9688 12.6562 39.7266 19.1797 39.7266 27.6172C39.7266 46.2891 31.9141 58.0469 18.9062 58.0469C9.6875 58.0469 3.08594 52.6953 1.40625 45Z");
        canvas.FillPath(vector140path);
        canvas.RestoreState();


        // View:     imageView141
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1326
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(-66.109375f, -322.98438f);
        var vector141Builder = new PathBuilder();
        var vector141path = vector141Builder.BuildPath("M31.4453 16.4062C31.4453 7.30469 24.6094 0 15.625 0C6.71875 0 0 6.95312 0 16.0938C0 24.5312 6.48438 31.3281 15.5469 31.3281C24.3359 31.3281 31.4453 24.375 31.4453 16.4062Z");
        canvas.FillPath(vector141path);
        canvas.RestoreState();


        // View:     imageView142
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1327
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(-19.664062f, -314.8203f);
        var vector142Builder = new PathBuilder();
        var vector142path = vector142Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.33594 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.33594 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector142path);
        canvas.RestoreState();


        // View:     imageView143
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1328
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(-19.664062f, -284.7422f);
        var vector143Builder = new PathBuilder();
        var vector143path = vector143Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.375 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.375 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector143path);
        canvas.RestoreState();


        // View:     imageView144
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1329
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(-4.46875f, -325.52344f);
        var vector144Builder = new PathBuilder();
        var vector144path = vector144Builder.BuildPath("M28.9453 55.625L28.9453 42.6953L0.898438 42.6953C0.351562 42.6953 0 42.3438 0 41.7969L0 39.8438C0 39.4922 0.078125 39.2578 0.273438 38.9453C7.85156 27.1094 16.0547 15.2734 26.8359 0.625C27.1484 0.234375 27.3828 0 27.9688 0L31.5234 0C32.0312 0 32.3828 0.351562 32.3828 0.898438L32.3828 39.4922L40.3516 39.4922C40.8984 39.4922 41.25 39.8438 41.25 40.3906L41.25 41.7969C41.25 42.3438 40.8984 42.6953 40.3516 42.6953L32.3828 42.6953L32.3828 55.625C32.3828 56.1719 32.0312 56.5234 31.5234 56.5234L29.8438 56.5234C29.2969 56.5234 28.9453 56.1719 28.9453 55.625Z");
        canvas.FillPath(vector144path);
        canvas.RestoreState();


        // View:     imageView145
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1330
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(-0.6796875f, -322.125f);
        var vector145Builder = new PathBuilder();
        var vector145path = vector145Builder.BuildPath("M0 36.0938L25.1562 36.0938L25.1562 0L25.0781 0C15.3906 13.0469 7.03125 25.1172 0 36.0156L0 36.0938Z");
        canvas.FillPath(vector145path);
        canvas.RestoreState();


        // View:     imageView146
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   65:1331
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(41.390625f, -325.3672f);
        var vector146Builder = new PathBuilder();
        var vector146path = vector146Builder.BuildPath("M15.4297 55.4688L15.4297 3.94531L15.3516 3.94531C11.9922 6.05469 5.46875 10.3906 1.28906 13.0859C0.78125 13.4375 0 13.2812 0 12.5781L0 10.8203C0 10.1562 0.15625 9.96094 0.625 9.64844C4.60938 7.03125 10.4688 3.125 14.7266 0.46875C15.1562 0.195312 15.5078 0 16.1328 0L18.0078 0C18.5547 0 18.9062 0.351562 18.9062 0.898438L18.9062 55.4688C18.9062 56.0156 18.5547 56.3672 18.0078 56.3672L16.3281 56.3672C15.7812 56.3672 15.4297 56.0156 15.4297 55.4688Z");
        canvas.FillPath(vector146path);
        canvas.RestoreState();


        // View:     textView28
        // NodeName: 9 41
        // NodeType: TEXT
        // NodeId:   65:1332
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"9 41", -80f, -347f, 144f, 99f, HorizontalAlignment.Right, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     frameView71
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   65:1333
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView72
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   I65:1333;362:15667
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView73
        // NodeName: Notch
        // NodeType: GROUP
        // NodeId:   I65:1333;362:15667;362:15633
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView15
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1333;362:15667;362:15634
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(-196f, -444f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     rectangleView16
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1333;362:15667;362:15636
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(214, 217, 221);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(-196f, -444f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     imageView147
        // NodeName: Notch
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15637
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(-111f, -446f);
        var vector147Builder = new PathBuilder();
        var vector147path = vector147Builder.BuildPath("M0 0L219 0L219 0C216.894 0.602689 215.418 2.49525 215.345 4.68446L215.317 5.5618L215.317 5.5618C215.317 19.0587 204.375 30 190.878 30L28.1217 30C14.6249 30 3.68349 19.0587 3.68349 5.5618L3.68349 5.5618L3.65455 4.68447C3.58233 2.49525 2.10586 0.602689 0 0L0 0Z");
        canvas.FillPath(vector147path);
        canvas.RestoreState();


        // View:     frameView74
        // NodeName: Right Side
        // NodeType: GROUP
        // NodeId:   I65:1333;362:15667;362:15638
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView75
        // NodeName: Battery
        // NodeType: GROUP
        // NodeId:   I65:1333;362:15667;362:15639
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView148
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15640
        canvas.SaveState();
        canvas.StrokeSize = 1;
        canvas.Translate(154f, -426.66663f);
        var vector148Builder = new PathBuilder();
        var vector148path = vector148Builder.BuildPath("M0 2.66666C0 1.19391 1.19391 0 2.66667 0L19.3333 0C20.8061 0 22 1.19391 22 2.66667L22 8.66667C22 10.1394 20.8061 11.3333 19.3333 11.3333L2.66667 11.3333C1.19391 11.3333 0 10.1394 0 8.66667L0 2.66666Z");
        canvas.DrawPath(vector148path);
        canvas.RestoreState();


        // View:     imageView149
        // NodeName: Combined Shape
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15641
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(1, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(177f, -422.99997f);
        var vector149Builder = new PathBuilder();
        var vector149path = vector149Builder.BuildPath("M0 0L0 4C0.804731 3.66122 1.32804 2.87313 1.32804 2C1.32804 1.12687 0.804731 0.338777 0 0");
        canvas.FillPath(vector149path);
        canvas.RestoreState();


        // View:     imageView150
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15642
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(1, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(156f, -424.66663f);
        var vector150Builder = new PathBuilder();
        var vector150path = vector150Builder.BuildPath("M0 1.33333C0 0.596955 0.596954 0 1.33333 0L16.6667 0C17.403 0 18 0.596954 18 1.33333L18 6C18 6.73638 17.403 7.33333 16.6667 7.33333L1.33333 7.33333C0.596954 7.33333 0 6.73638 0 6L0 1.33333Z");
        canvas.FillPath(vector150path);
        canvas.RestoreState();


        // View:     imageView151
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15644
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(133.69373f, -426.6693f);
        var vector151Builder = new PathBuilder();
        var vector151path = vector151Builder.BuildPath("M7.63661 2.27733C9.8525 2.27742 11.9837 3.12886 13.5896 4.65566C13.7105 4.77354 13.9038 4.77205 14.0229 4.65233L15.1789 3.48566C15.2392 3.42494 15.2729 3.34269 15.2724 3.25711C15.2719 3.17153 15.2373 3.08967 15.1763 3.02966C10.9612 -1.00989 4.31137 -1.00989 0.0962725 3.02966C0.0352139 3.08963 0.00057 3.17146 6.97078e-06 3.25704C-0.000556058 3.34262 0.0330082 3.42489 0.0932725 3.48566L1.24961 4.65233C1.36863 4.77223 1.56208 4.77372 1.68294 4.65566C3.28909 3.12876 5.4205 2.27732 7.63661 2.27733L7.63661 2.27733Z");
        canvas.FillPath(vector151path);
        canvas.RestoreState();


        // View:     imageView152
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15645
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(136.357f, -422.87527f);
        var vector152Builder = new PathBuilder();
        var vector152path = vector152Builder.BuildPath("M4.97332 2.27895C6.19081 2.27888 7.36486 2.73141 8.26732 3.54862C8.38939 3.6646 8.58167 3.66209 8.70066 3.54295L9.85532 2.37629C9.91613 2.31509 9.94987 2.23208 9.94899 2.14581C9.94812 2.05955 9.9127 1.97723 9.85066 1.91729C7.10246 -0.639096 2.84652 -0.639096 0.0983249 1.91729C0.0362471 1.97723 0.000829042 2.05959 1.4369e-05 2.14588C-0.000800304 2.23217 0.0330566 2.31518 0.0939916 2.37629L1.24832 3.54295C1.36731 3.66209 1.55959 3.6646 1.68166 3.54862C2.58353 2.73195 3.75664 2.27946 4.97332 2.27895L4.97332 2.27895Z");
        canvas.FillPath(vector152path);
        canvas.RestoreState();


        // View:     imageView153
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15646
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(139.01709f, -419.07816f);
        var vector153Builder = new PathBuilder();
        var vector153path = vector153Builder.BuildPath("M4.53223 1.26616C4.59399 1.20556 4.62799 1.12215 4.62623 1.03565C4.62446 0.949141 4.58708 0.867197 4.5229 0.809163C3.24733 -0.269721 1.37914 -0.269721 0.103567 0.809163C0.0393462 0.86715 0.00190016 0.949069 7.03234e-05 1.03558C-0.00175952 1.12208 0.032189 1.20551 0.0939003 1.26616L2.09157 3.28183C2.15012 3.34107 2.22994 3.37441 2.31323 3.37441C2.39652 3.37441 2.47635 3.34107 2.5349 3.28183L4.53223 1.26616Z");
        canvas.FillPath(vector153path);
        canvas.RestoreState();


        // View:     imageView154
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15648
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(111.66666f, -419.66672f);
        var vector154Builder = new PathBuilder();
        var vector154path = vector154Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 3C3 3.55228 2.55228 4 2 4L1 4C0.447715 4 0 3.55228 0 3L0 1C0 0.447715 0.447715 0 1 0L1 0Z");
        canvas.FillPath(vector154path);
        canvas.RestoreState();


        // View:     imageView155
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15649
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(116.33331f, -421.66672f);
        var vector155Builder = new PathBuilder();
        var vector155path = vector155Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 5C3 5.55228 2.55228 6 2 6L1 6C0.447715 6 0 5.55228 0 5L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector155path);
        canvas.RestoreState();


        // View:     imageView156
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15650
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(121f, -424.00003f);
        var vector156Builder = new PathBuilder();
        var vector156path = vector156Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 7.33333C3 7.88562 2.55228 8.33333 2 8.33333L1 8.33333C0.447715 8.33333 0 7.88562 0 7.33333L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector156path);
        canvas.RestoreState();


        // View:     imageView157
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15651
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(125.66666f, -426.33337f);
        var vector157Builder = new PathBuilder();
        var vector157path = vector157Builder.BuildPath("M1 2.36848e-15L2 2.36848e-15C2.55228 0 3 0.447715 3 1L3 9.66667C3 10.219 2.55228 10.6667 2 10.6667L1 10.6667C0.447715 10.6667 0 10.219 0 9.66667L0 1C0 0.447715 0.447715 0 1 0L1 2.36848e-15Z");
        canvas.FillPath(vector157path);
        canvas.RestoreState();


        // View:     frameView76
        // NodeName: Recording Indicator
        // NodeType: GROUP
        // NodeId:   I65:1333;362:15667;362:15652
        canvas.SaveState();
        canvas.RestoreState();


        // View:     elipseView5
        // NodeName: Indicator
        // NodeType: ELLIPSE
        // NodeId:   I65:1333;362:15667;362:15653
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 149, 0);
        canvas.Alpha = 1;
        canvas.FillEllipse(116.00003f, -435.99988f, 6f, 6f);
        canvas.RestoreState();


        // View:     frameView77
        // NodeName: Left Side
        // NodeType: GROUP
        // NodeId:   I65:1333;362:15667;362:15654
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView78
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1333;362:15667;362:15655
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView79
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1333;362:15667;362:15655;362:15623
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView158
        // NodeName: 9:41
        // NodeType: VECTOR
        // NodeId:   I65:1333;362:15667;362:15655;362:15623;362:15615
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(1, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(-162.54648f, -426.83252f);
        var vector158Builder = new PathBuilder();
        var vector158path = vector158Builder.BuildPath("M3.86719 11.0889C6.55518 11.0889 8.15186 8.98682 8.15186 5.42725C8.15186 4.08691 7.89551 2.95898 7.40479 2.0874C6.69434 0.732422 5.47119 0 3.92578 0C1.62598 0 0 1.54541 0 3.71338C0 5.74951 1.46484 7.229 3.479 7.229C4.7168 7.229 5.72021 6.65039 6.21826 5.64697L6.24023 5.64697C6.24023 5.64697 6.26953 5.64697 6.27686 5.64697C6.2915 5.64697 6.34277 5.64697 6.34277 5.64697C6.34277 8.06396 5.42725 9.50684 3.88184 9.50684C2.97363 9.50684 2.27051 9.00879 2.02881 8.21045L0.146484 8.21045C0.461426 9.94629 1.93359 11.0889 3.86719 11.0889ZM3.93311 5.72754C2.71729 5.72754 1.85303 4.86328 1.85303 3.65479C1.85303 2.47559 2.76123 1.57471 3.94043 1.57471C5.11963 1.57471 6.02783 2.49023 6.02783 3.68408C6.02783 4.86328 5.1416 5.72754 3.93311 5.72754Z");
        canvas.FillPath(vector158path);
        canvas.Translate(-162.54648f, -426.83252f);
        var vector159Builder = new PathBuilder();
        var vector159path = vector159Builder.BuildPath("M11.243 10.9863C11.9388 10.9863 12.4148 10.4883 12.4148 9.8291C12.4148 9.1626 11.9388 8.67188 11.243 8.67188C10.5545 8.67188 10.0711 9.1626 10.0711 9.8291C10.0711 10.4883 10.5545 10.9863 11.243 10.9863ZM11.243 5.49316C11.9388 5.49316 12.4148 5.00244 12.4148 4.34326C12.4148 3.67676 11.9388 3.18604 11.243 3.18604C10.5545 3.18604 10.0711 3.67676 10.0711 4.34326C10.0711 5.00244 10.5545 5.49316 11.243 5.49316Z");
        canvas.FillPath(vector159path);
        canvas.Translate(-162.54648f, -426.83252f);
        var vector160Builder = new PathBuilder();
        var vector160path = vector160Builder.BuildPath("M19.2706 10.8325L21.0797 10.8325L21.0797 8.8623L22.5079 8.8623L22.5079 7.26562L21.0797 7.26562L21.0797 0.263672L18.4137 0.263672C16.546 3.07617 15.0592 5.42725 14.107 7.17773L14.107 8.8623L19.2706 8.8623L19.2706 10.8325ZM15.8575 7.19971C17.088 5.03174 18.1866 3.2959 19.1974 1.80176L19.2999 1.80176L19.2999 7.30957L15.8575 7.30957L15.8575 7.19971Z");
        canvas.FillPath(vector160path);
        canvas.Translate(-162.54648f, -426.83252f);
        var vector161Builder = new PathBuilder();
        var vector161path = vector161Builder.BuildPath("M26.5365 10.8325L28.4262 10.8325L28.4262 0.263672L26.5438 0.263672L23.7826 2.19727L23.7826 4.01367L26.412 2.16797L26.5365 2.16797L26.5365 10.8325Z");
        canvas.FillPath(vector161path);
        canvas.RestoreState();


        // View:     frameView80
        // NodeName: iPhone 14 - 4
        // NodeType: FRAME
        // NodeId:   65:1334
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(632f, -450f, 389f, 840f, 0f);
        canvas.RestoreState();


        // View:     frameView81
        // NodeName: Lockscreen
        // NodeType: INSTANCE
        // NodeId:   65:1335
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView82
        // NodeName: Lockscreen Assets
        // NodeType: FRAME
        // NodeId:   I65:1335;362:14396
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView17
        // NodeName: Wallpaper
        // NodeType: RECTANGLE
        // NodeId:   I65:1335;362:14397
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(632f, -450f, 389f, 840f, 0f);
        canvas.RestoreState();


        // View:     frameView83
        // NodeName: Bottom UI
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14398
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView84
        // NodeName: Home Indicator
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14399
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView85
        // NodeName: Home Indicator
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14399;362:15725
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView18
        // NodeName: Home Indicator
        // NodeType: RECTANGLE
        // NodeId:   I65:1335;362:14399;362:15725;362:15723
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(760f, 377f, 134f, 5f, 100f);
        canvas.RestoreState();


        // View:     textView29
        // NodeName: swipe up to open
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14400
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 17f;
        canvas.DrawString(@"swipe up to open", 761f, 262f, 131f, 20f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView86
        // NodeName: Camera button
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14401
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView159
        // NodeName: Oval Copy
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14402
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.Translate(925f, 290f);
        var vector162Builder = new PathBuilder();
        var vector162path = vector162Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.FillPath(vector162path);
        canvas.StrokeColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.StrokeSize = 0;
        canvas.Translate(925f, 290f);
        var vector163Builder = new PathBuilder();
        var vector163path = vector163Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.DrawPath(vector163path);
        canvas.RestoreState();


        // View:     imageView160
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14404
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(946.0125f, 311.31403f);
        var vector164Builder = new PathBuilder();
        var vector164path = vector164Builder.BuildPath("M3.995 0C1.789 0 0 1.793 0 4.005C0 6.216 1.789 8.01 3.995 8.01C6.202 8.01 7.99 6.216 7.99 4.005C7.99 1.793 6.202 0 3.995 0L3.995 0Z");
        canvas.FillPath(vector164path);
        canvas.RestoreState();


        // View:     imageView161
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14405
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(955.68054f, 310.315f);
        var vector165Builder = new PathBuilder();
        var vector165path = vector165Builder.BuildPath("M0.668 1.348C0.3 1.348 0 1.046 0 0.674C0 0.302 0.3 0 0.668 0C1.036 0 1.335 0.302 1.335 0.674C1.335 1.046 1.036 1.348 0.668 1.348L0.668 1.348Z");
        canvas.FillPath(vector165path);
        canvas.RestoreState();


        // View:     imageView162
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14406
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(945.0445f, 310.36603f);
        var vector166Builder = new PathBuilder();
        var vector166path = vector166Builder.BuildPath("M4.958 9.937C2.219 9.937 0 7.712 0 4.968C0 2.224 2.219 0 4.958 0C7.696 0 9.916 2.224 9.916 4.968C9.916 7.712 7.696 9.937 4.958 9.937L4.958 9.937Z");
        canvas.FillPath(vector166path);
        canvas.RestoreState();


        // View:     imageView163
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14407
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(939.0005f, 305.99976f);
        var vector167Builder = new PathBuilder();
        var vector167path = vector167Builder.BuildPath("M21.999 5.43925C21.999 5.34525 21.999 5.25225 21.998 5.15925C21.998 5.08025 21.997 5.00125 21.995 4.92225C21.99 4.75125 21.98 4.50125 21.95 4.33125C21.919 4.15925 21.869 4.07525 21.791 3.91825C21.713 3.76525 21.612 3.62425 21.491 3.50225C21.371 3.37925 21.231 3.27825 21.079 3.19925C20.924 3.12025 20.766 3.06925 20.595 3.03825C20.427 3.00725 20.256 2.99725 20.086 2.99325C20.008 2.99125 19.93 2.99025 19.852 2.99025C19.76 2.98925 19.667 2.98925 19.575 2.98925L18.829 2.98925L17.346 2.98925C17.2 2.98225 17.054 2.98325 16.911 2.95725C16.716 2.92125 16.535 2.84925 16.358 2.75725C16.185 2.66825 16.027 2.55525 15.889 2.41525C15.752 2.27525 15.579 1.62925 15.44 1.30425C15.396 1.20225 15.38 1.14325 15.34 1.06425C15.252 0.88925 15.136 0.72625 15 0.58625C14.861 0.44625 14.702 0.32825 14.53 0.23825C14.353 0.14625 14.172 0.08925 13.977 0.05425C13.786 0.01825 13.59 0.00825 13.396 0.00225C13.307 -0.00075 8.628 -0.00075 8.539 0.00225C8.346 0.00825 8.15 0.01825 7.959 0.05425C7.765 0.08925 7.584 0.14625 7.407 0.23825C7.234 0.32825 7.075 0.44525 6.937 0.58525C6.799 0.72525 6.684 0.88825 6.596 1.06425C6.557 1.14325 6.524 1.22225 6.497 1.30325C6.358 1.64925 6.189 2.26425 6.051 2.40425C5.914 2.54425 5.755 2.65825 5.581 2.74725C5.405 2.84025 5.224 2.91125 5.03 2.94625C4.838 2.98125 4.643 2.97925 4.449 2.98325C4.36 2.98725 4.459 2.98725 4.369 2.98825C4.264 2.98925 4.159 2.98925 4.053 2.98925L3.17 2.98925L2.424 2.98925C2.332 2.98925 2.24 2.98925 2.147 2.99025C2.069 2.99025 1.991 2.99125 1.913 2.99325C1.743 2.99725 1.572 3.00725 1.404 3.03825C1.233 3.06925 1.075 3.12025 0.92 3.19925C0.768 3.27825 0.628 3.37925 0.508 3.50225C0.387 3.62425 0.286 3.76525 0.209 3.91825C0.13 4.07525 0.079 4.23525 0.049 4.40825C0.019 4.57725 0.008 4.75125 0.004 4.92225C0.002 5.00125 0.002 5.08025 0.001 5.15925C0 5.25225 0 5.34525 0 5.43925L0 5.93325L0 13.4622L0 14.2172C0 14.3112 0 14.4042 0.001 14.4972C0.002 14.5772 0.002 14.6552 0.004 14.7343C0.008 14.9062 0.019 15.0782 0.049 15.2483C0.079 15.4213 0.13 15.5813 0.209 15.7382C0.286 15.8923 0.387 16.0322 0.508 16.1542C0.628 16.2762 0.768 16.3783 0.92 16.4573C1.075 16.5363 1.233 16.5872 1.404 16.6182C1.572 16.6493 1.743 16.6593 1.913 16.6632C1.991 16.6653 2.069 16.6663 2.147 16.6672C2.24 16.6672 2.332 16.6672 2.424 16.6672L19.575 16.6672C19.667 16.6672 19.76 16.6672 19.852 16.6672C19.93 16.6663 20.008 16.6653 20.086 16.6632C20.256 16.6593 20.427 16.6493 20.595 16.6182C20.766 16.5872 20.924 16.5363 21.079 16.4573C21.231 16.3783 21.371 16.2762 21.491 16.1542C21.612 16.0322 21.713 15.8923 21.791 15.7382C21.869 15.5813 21.919 15.4213 21.95 15.2483C21.98 15.0782 21.99 14.9062 21.995 14.7343C21.997 14.6552 21.998 14.5772 21.998 14.4972C21.999 14.4042 21.999 14.3112 21.999 14.2172L21.999 13.4622L21.999 6.19425L21.999 5.43925Z");
        canvas.FillPath(vector167path);
        canvas.RestoreState();


        // View:     imageView164
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14408
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(941.00354f, 307.352f);
        var vector168Builder = new PathBuilder();
        var vector168path = vector168Builder.BuildPath("M0.128 0.968L2.198 0.968C2.269 0.968 2.327 0.91 2.327 0.839L2.327 0.401C2.327 0.387 2.327 0.372 2.326 0.358C2.325 0.326 2.322 0.294 2.317 0.263C2.312 0.231 2.303 0.201 2.288 0.172C2.274 0.144 2.256 0.118 2.234 0.096C2.211 0.073 2.186 0.054 2.159 0.04C2.13 0.025 2.101 0.015 2.07 0.01C2.039 0.004 2.008 0.002 1.977 0.001C1.963 0.001 1.948 0 1.934 0L0.396 0C0.383 0 0.368 0.001 0.354 0.001C0.323 0.002 0.292 0.004 0.261 0.01C0.23 0.015 0.201 0.025 0.173 0.04C0.145 0.054 0.12 0.073 0.097 0.096C0.075 0.118 0.058 0.144 0.043 0.172C0.028 0.201 0.02 0.231 0.014 0.263C0.008 0.294 0.006 0.326 0.006 0.358C0.005 0.372 0.002 0.387 0.002 0.401C0.002 0.418 0 0.436 0 0.453L0 0.839C0 0.91 0.058 0.968 0.128 0.968L0.128 0.968Z");
        canvas.FillPath(vector168path);
        canvas.RestoreState();


        // View:     frameView87
        // NodeName: Flashlight button
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14409
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView165
        // NodeName: Oval
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14410
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.Translate(678f, 290f);
        var vector169Builder = new PathBuilder();
        var vector169path = vector169Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.FillPath(vector169path);
        canvas.StrokeColor = Color.FromRgb(95, 88, 88);
        canvas.Alpha = 1;
        canvas.StrokeSize = 0;
        canvas.Translate(678f, 290f);
        var vector170Builder = new PathBuilder();
        var vector170path = vector170Builder.BuildPath("M25 50C38.8071 50 50 38.8071 50 25C50 11.1929 38.8071 0 25 0C11.1929 0 0 11.1929 0 25C0 38.8071 11.1929 50 25 50Z");
        canvas.DrawPath(vector170path);
        canvas.RestoreState();


        // View:     imageView166
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14412
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(702.0006f, 316.33447f);
        var vector171Builder = new PathBuilder();
        var vector171path = vector171Builder.BuildPath("M1.998 0.999C1.998 1.551 1.551 1.998 0.999 1.998C0.447 1.998 0 1.551 0 0.999C0 0.447 0.447 0 0.999 0C1.551 0 1.998 0.447 1.998 0.999L1.998 0.999Z");
        canvas.FillPath(vector171path);
        canvas.RestoreState();


        // View:     imageView167
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14413
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(701.32965f, 313.0185f);
        var vector172Builder = new PathBuilder();
        var vector172path = vector172Builder.BuildPath("M0 1.67L0 4.294C0 5.216 0.748 5.963 1.67 5.963C2.592 5.963 3.34 5.216 3.34 4.294L3.34 1.67C3.34 0.747 2.592 0 1.67 0C0.748 0 0 0.747 0 1.67L0 1.67Z");
        canvas.FillPath(vector172path);
        canvas.RestoreState();


        // View:     imageView168
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14414
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(697.99963f, 305.6665f);
        var vector173Builder = new PathBuilder();
        var vector173path = vector173Builder.BuildPath("M5.251 0L10.001 0C10.001 1.268 10 2.262 8.75 4.001C7.761 5.377 7.667 5.97 7.667 7.5L7.667 19.25L7.667 21.251L7.667 21.5C7.667 22.329 6.996 23 6.167 23L3.834 23C3.005 23 2.334 22.329 2.334 21.5L2.334 21.251L2.334 19.25L2.334 7.5C2.334 5.97 2.24 5.377 1.25 4.001C0.00100005 2.262 0 1.268 0 0L4.751 0L5.251 0Z");
        canvas.FillPath(vector173path);
        canvas.RestoreState();


        // View:     imageView169
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14415
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(697.99963f, 303.0005f);
        var vector174Builder = new PathBuilder();
        var vector174path = vector174Builder.BuildPath("M0 0.5C0 0.224 0.224 0 0.5 0L9.501 0C9.777 0 10.001 0.224 10.001 0.5L10.001 1.666L0 1.666L0 0.5Z");
        canvas.FillPath(vector174path);
        canvas.RestoreState();


        // View:     frameView88
        // NodeName: Status Bar, Time, Date
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14416
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView30
        // NodeName: Date
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14417
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 22f;
        canvas.DrawString(@"Monday, June 3", 748f, -260f, 157f, 26f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     imageView170
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14419
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(758.33594f, -332.22656f);
        var vector175Builder = new PathBuilder();
        var vector175path = vector175Builder.BuildPath("M1.40625 45C1.28906 44.375 1.64062 44.0625 2.10938 44.0625L4.02344 44.0625C4.60938 44.0625 4.84375 44.3359 5 44.8047C6.32812 50.5469 11.5625 54.8828 18.9062 54.8828C29.6094 54.8828 35.7812 44.8438 36.2891 28.8281C36.3281 27.7734 36.2891 26.4844 36.2891 25.3516L36.1719 25.3516C34.3359 32.3047 27.0703 37.7344 18.7109 37.7344C7.92969 37.7344 0 29.8438 0 19.4141C0 8.32031 8.08594 0 19.1406 0C25.7031 0 31.1328 2.96875 34.6094 8.04688C37.9688 12.6562 39.7266 19.1797 39.7266 27.6172C39.7266 46.2891 31.9141 58.0469 18.9062 58.0469C9.6875 58.0469 3.08594 52.6953 1.40625 45Z");
        canvas.FillPath(vector175path);
        canvas.RestoreState();


        // View:     imageView171
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14420
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(761.8906f, -328.98438f);
        var vector176Builder = new PathBuilder();
        var vector176path = vector176Builder.BuildPath("M31.4453 16.4062C31.4453 7.30469 24.6094 0 15.625 0C6.71875 0 0 6.95312 0 16.0938C0 24.5312 6.48438 31.3281 15.5469 31.3281C24.3359 31.3281 31.4453 24.375 31.4453 16.4062Z");
        canvas.FillPath(vector176path);
        canvas.RestoreState();


        // View:     imageView172
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14421
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(808.33594f, -320.8203f);
        var vector177Builder = new PathBuilder();
        var vector177path = vector177Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.33594 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.33594 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector177path);
        canvas.RestoreState();


        // View:     imageView173
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14422
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(808.33594f, -290.7422f);
        var vector178Builder = new PathBuilder();
        var vector178path = vector178Builder.BuildPath("M2.8125 5.625C1.25 5.625 0 4.375 0 2.8125C0 1.25 1.25 0 2.8125 0C4.375 0 5.625 1.25 5.625 2.8125C5.625 4.375 4.375 5.625 2.8125 5.625Z");
        canvas.FillPath(vector178path);
        canvas.RestoreState();


        // View:     imageView174
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14423
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(823.53125f, -331.52344f);
        var vector179Builder = new PathBuilder();
        var vector179path = vector179Builder.BuildPath("M28.9453 55.625L28.9453 42.6953L0.898438 42.6953C0.351562 42.6953 0 42.3438 0 41.7969L0 39.8438C0 39.4922 0.078125 39.2578 0.273438 38.9453C7.85156 27.1094 16.0547 15.2734 26.8359 0.625C27.1484 0.234375 27.3828 0 27.9688 0L31.5234 0C32.0312 0 32.3828 0.351562 32.3828 0.898438L32.3828 39.4922L40.3516 39.4922C40.8984 39.4922 41.25 39.8438 41.25 40.3906L41.25 41.7969C41.25 42.3438 40.8984 42.6953 40.3516 42.6953L32.3828 42.6953L32.3828 55.625C32.3828 56.1719 32.0312 56.5234 31.5234 56.5234L29.8438 56.5234C29.2969 56.5234 28.9453 56.1719 28.9453 55.625Z");
        canvas.FillPath(vector179path);
        canvas.RestoreState();


        // View:     imageView175
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14424
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(827.3203f, -328.125f);
        var vector180Builder = new PathBuilder();
        var vector180path = vector180Builder.BuildPath("M0 36.0938L25.1562 36.0938L25.1562 0L25.0781 0C15.3906 13.0469 7.03125 25.1172 0 36.0156L0 36.0938Z");
        canvas.FillPath(vector180path);
        canvas.RestoreState();


        // View:     imageView176
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14425
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(869.3906f, -331.3672f);
        var vector181Builder = new PathBuilder();
        var vector181path = vector181Builder.BuildPath("M15.4297 55.4688L15.4297 3.94531L15.3516 3.94531C11.9922 6.05469 5.46875 10.3906 1.28906 13.0859C0.78125 13.4375 0 13.2812 0 12.5781L0 10.8203C0 10.1562 0.15625 9.96094 0.625 9.64844C4.60938 7.03125 10.4688 3.125 14.7266 0.46875C15.1562 0.195312 15.5078 0 16.1328 0L18.0078 0C18.5547 0 18.9062 0.351562 18.9062 0.898438L18.9062 55.4688C18.9062 56.0156 18.5547 56.3672 18.0078 56.3672L16.3281 56.3672C15.7812 56.3672 15.4297 56.0156 15.4297 55.4688Z");
        canvas.FillPath(vector181path);
        canvas.RestoreState();


        // View:     textView31
        // NodeName: 9 41
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14426
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"9 41", 748f, -353f, 144f, 99f, HorizontalAlignment.Right, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     frameView89
        // NodeName: Editable Time
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14427
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView32
        // NodeName: 41
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14428
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"41", 819f, -353f, 80f, 99f, HorizontalAlignment.Left, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     imageView177
        // NodeName: :
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14429
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(808.78467f, -320.5f);
        var vector182Builder = new PathBuilder();
        var vector182path = vector182Builder.BuildPath("M2.71533 5.39014C4.17432 5.39014 5.39014 4.17432 5.39014 2.6748C5.39014 1.21582 4.17432 0 2.71533 0C1.21582 0 0 1.21582 0 2.6748C0 4.17432 1.21582 5.39014 2.71533 5.39014ZM2.71533 34.8242C4.17432 34.8242 5.39014 33.6084 5.39014 32.1089C5.39014 30.6499 4.17432 29.4341 2.71533 29.4341C1.21582 29.4341 0 30.6499 0 32.1089C0 33.6084 1.21582 34.8242 2.71533 34.8242Z");
        canvas.FillPath(vector182path);
        canvas.RestoreState();


        // View:     textView33
        // NodeName: 9
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14430
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProDisplay-Thin", 200, FontStyleType.Normal);
        canvas.FontSize = 83f;
        canvas.DrawString(@"9", 755f, -353f, 48f, 99f, HorizontalAlignment.Right, VerticalAlignment.Center);
        canvas.RestoreState();


        // View:     imageView178
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14432
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(820.48535f, -387.86432f);
        var vector183Builder = new PathBuilder();
        var vector183path = vector183Builder.BuildPath("M11.6946 10.532L0.334703 10.532C0.219024 10.532 0.108345 10.532 0 10.532L0 8.26133C0 6.89733 0.00933436 5.89033 0.214357 4.87667C0.412045 3.90067 0.776085 3.05633 1.32715 2.323C2.43493 0.849 4.17913 0 6.01466 0C7.85053 0 9.59439 0.849 10.7022 2.323C11.2536 3.05633 11.6176 3.90067 11.815 4.87667C12.0203 5.89033 12.0293 6.89733 12.0293 8.26133L12.0293 10.532C11.9213 10.532 11.8106 10.532 11.6946 10.532L11.6946 10.532Z");
        canvas.FillPath(vector183path);
        canvas.RestoreState();


        // View:     imageView179
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14433
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Translate(815f, -391f);
        var vector184Builder = new PathBuilder();
        var vector184path = vector184Builder.BuildPath("M22.9999 19.5157C22.9999 18.744 23.0013 18.141 22.9923 17.748C22.9826 17.317 22.9586 16.951 22.8963 16.5983C22.7689 15.8817 22.4755 15.243 21.9538 14.7187C21.5798 14.3427 21.1457 14.0863 20.6677 13.9233L20.6677 11.397C20.6677 9.867 20.654 8.56333 20.343 7.16933C20.0419 5.821 19.4919 4.58767 18.6518 3.49767C16.9583 1.30067 14.313 0 11.5 0C8.68702 0 6.04173 1.30067 4.34821 3.49767C3.50812 4.58767 2.95806 5.821 2.65736 7.16933C2.34599 8.56333 2.33233 9.867 2.33233 11.397L2.33233 13.9233C1.85427 14.0863 1.42023 14.3427 1.04618 14.7187C0.524461 15.243 0.231095 15.8817 0.103748 16.5983C0.0410742 16.951 0.0174049 17.317 0.00773718 17.748C-0.00126381 18.141 6.96675e-05 18.744 6.96675e-05 19.5157L6.96675e-05 27.484C6.96675e-05 28.2557 -0.00126381 28.8587 0.00773718 29.2517C0.0174049 29.6827 0.0410742 30.049 0.103748 30.4013C0.231095 31.118 0.524461 31.757 1.04618 32.281C1.56758 32.8053 2.20365 33.0997 2.91672 33.228C3.26776 33.2907 3.63214 33.3147 4.06052 33.3243C4.45223 33.3333 5.05229 33.3323 5.82004 33.3323L17.18 33.3323C17.9477 33.3323 18.5481 33.3333 18.9391 33.3243C19.3679 33.3147 19.7322 33.2907 20.0833 33.228C20.7964 33.0997 21.4324 32.8053 21.9538 32.281C22.4755 31.757 22.7689 31.118 22.8963 30.4013C22.9586 30.049 22.9826 29.6827 22.9923 29.2517C23.0013 28.8587 22.9999 28.2557 22.9999 27.484L22.9999 19.5157Z");
        canvas.FillPath(vector184path);
        canvas.RestoreState();


        // View:     frameView90
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14434
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView91
        // NodeName: iPhone X (or newer)
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14434;362:15667
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView92
        // NodeName: Notch
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14434;362:15667;362:15633
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView19
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1335;362:14434;362:15667;362:15634
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(632f, -450f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     rectangleView20
        // NodeName: BG
        // NodeType: RECTANGLE
        // NodeId:   I65:1335;362:14434;362:15667;362:15636
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(214, 217, 221);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(632f, -450f, 389f, 44f, 0f);
        canvas.RestoreState();


        // View:     imageView180
        // NodeName: Notch
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15637
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(717f, -452f);
        var vector185Builder = new PathBuilder();
        var vector185path = vector185Builder.BuildPath("M0 0L219 0L219 0C216.894 0.602689 215.418 2.49525 215.345 4.68446L215.317 5.5618L215.317 5.5618C215.317 19.0587 204.375 30 190.878 30L28.1217 30C14.6249 30 3.68349 19.0587 3.68349 5.5618L3.68349 5.5618L3.65455 4.68447C3.58233 2.49525 2.10586 0.602689 0 0L0 0Z");
        canvas.FillPath(vector185path);
        canvas.RestoreState();


        // View:     frameView93
        // NodeName: Right Side
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14434;362:15667;362:15638
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView94
        // NodeName: Battery
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14434;362:15667;362:15639
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView181
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15640
        canvas.SaveState();
        canvas.StrokeSize = 1;
        canvas.Translate(982f, -432.66663f);
        var vector186Builder = new PathBuilder();
        var vector186path = vector186Builder.BuildPath("M0 2.66666C0 1.19391 1.19391 0 2.66667 0L19.3333 0C20.8061 0 22 1.19391 22 2.66667L22 8.66667C22 10.1394 20.8061 11.3333 19.3333 11.3333L2.66667 11.3333C1.19391 11.3333 0 10.1394 0 8.66667L0 2.66666Z");
        canvas.DrawPath(vector186path);
        canvas.RestoreState();


        // View:     imageView182
        // NodeName: Combined Shape
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15641
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(1005f, -428.99997f);
        var vector187Builder = new PathBuilder();
        var vector187path = vector187Builder.BuildPath("M0 0L0 4C0.804731 3.66122 1.32804 2.87313 1.32804 2C1.32804 1.12687 0.804731 0.338777 0 0");
        canvas.FillPath(vector187path);
        canvas.RestoreState();


        // View:     imageView183
        // NodeName: Rectangle
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15642
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(984f, -430.66663f);
        var vector188Builder = new PathBuilder();
        var vector188path = vector188Builder.BuildPath("M0 1.33333C0 0.596955 0.596954 0 1.33333 0L16.6667 0C17.403 0 18 0.596954 18 1.33333L18 6C18 6.73638 17.403 7.33333 16.6667 7.33333L1.33333 7.33333C0.596954 7.33333 0 6.73638 0 6L0 1.33333Z");
        canvas.FillPath(vector188path);
        canvas.RestoreState();


        // View:     imageView184
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15644
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(961.6937f, -432.6693f);
        var vector189Builder = new PathBuilder();
        var vector189path = vector189Builder.BuildPath("M7.63661 2.27733C9.8525 2.27742 11.9837 3.12886 13.5896 4.65566C13.7105 4.77354 13.9038 4.77205 14.0229 4.65233L15.1789 3.48566C15.2392 3.42494 15.2729 3.34269 15.2724 3.25711C15.2719 3.17153 15.2373 3.08967 15.1763 3.02966C10.9612 -1.00989 4.31137 -1.00989 0.0962725 3.02966C0.0352139 3.08963 0.00057 3.17146 6.97078e-06 3.25704C-0.000556058 3.34262 0.0330082 3.42489 0.0932725 3.48566L1.24961 4.65233C1.36863 4.77223 1.56208 4.77372 1.68294 4.65566C3.28909 3.12876 5.4205 2.27732 7.63661 2.27733L7.63661 2.27733Z");
        canvas.FillPath(vector189path);
        canvas.RestoreState();


        // View:     imageView185
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15645
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(964.357f, -428.87527f);
        var vector190Builder = new PathBuilder();
        var vector190path = vector190Builder.BuildPath("M4.97332 2.27895C6.19081 2.27888 7.36486 2.73141 8.26732 3.54862C8.38939 3.6646 8.58167 3.66209 8.70066 3.54295L9.85532 2.37629C9.91613 2.31509 9.94987 2.23208 9.94899 2.14581C9.94812 2.05955 9.9127 1.97723 9.85066 1.91729C7.10246 -0.639096 2.84652 -0.639096 0.0983249 1.91729C0.0362471 1.97723 0.000829042 2.05959 1.4369e-05 2.14588C-0.000800304 2.23217 0.0330566 2.31518 0.0939916 2.37629L1.24832 3.54295C1.36731 3.66209 1.55959 3.6646 1.68166 3.54862C2.58353 2.73195 3.75664 2.27946 4.97332 2.27895L4.97332 2.27895Z");
        canvas.FillPath(vector190path);
        canvas.RestoreState();


        // View:     imageView186
        // NodeName: Wifi-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15646
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(967.0171f, -425.07816f);
        var vector191Builder = new PathBuilder();
        var vector191path = vector191Builder.BuildPath("M4.53223 1.26616C4.59399 1.20556 4.62799 1.12215 4.62623 1.03565C4.62446 0.949141 4.58708 0.867197 4.5229 0.809163C3.24733 -0.269721 1.37914 -0.269721 0.103567 0.809163C0.0393462 0.86715 0.00190016 0.949069 7.03234e-05 1.03558C-0.00175952 1.12208 0.032189 1.20551 0.0939003 1.26616L2.09157 3.28183C2.15012 3.34107 2.22994 3.37441 2.31323 3.37441C2.39652 3.37441 2.47635 3.34107 2.5349 3.28183L4.53223 1.26616Z");
        canvas.FillPath(vector191path);
        canvas.RestoreState();


        // View:     imageView187
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15648
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(939.6666f, -425.66672f);
        var vector192Builder = new PathBuilder();
        var vector192path = vector192Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 3C3 3.55228 2.55228 4 2 4L1 4C0.447715 4 0 3.55228 0 3L0 1C0 0.447715 0.447715 0 1 0L1 0Z");
        canvas.FillPath(vector192path);
        canvas.RestoreState();


        // View:     imageView188
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15649
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(944.33325f, -427.66672f);
        var vector193Builder = new PathBuilder();
        var vector193path = vector193Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 5C3 5.55228 2.55228 6 2 6L1 6C0.447715 6 0 5.55228 0 5L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector193path);
        canvas.RestoreState();


        // View:     imageView189
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15650
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(949f, -430.00003f);
        var vector194Builder = new PathBuilder();
        var vector194path = vector194Builder.BuildPath("M1 0L2 0C2.55228 0 3 0.447715 3 1L3 7.33333C3 7.88562 2.55228 8.33333 2 8.33333L1 8.33333C0.447715 8.33333 0 7.88562 0 7.33333L0 1C0 0.447715 0.447715 0 1 0Z");
        canvas.FillPath(vector194path);
        canvas.RestoreState();


        // View:     imageView190
        // NodeName: Cellular_Connection-path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15651
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(218, 218, 218);
        canvas.Alpha = 1;
        canvas.Translate(953.6666f, -432.33337f);
        var vector195Builder = new PathBuilder();
        var vector195path = vector195Builder.BuildPath("M1 2.36848e-15L2 2.36848e-15C2.55228 0 3 0.447715 3 1L3 9.66667C3 10.219 2.55228 10.6667 2 10.6667L1 10.6667C0.447715 10.6667 0 10.219 0 9.66667L0 1C0 0.447715 0.447715 0 1 0L1 2.36848e-15Z");
        canvas.FillPath(vector195path);
        canvas.RestoreState();


        // View:     frameView95
        // NodeName: Recording Indicator
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14434;362:15667;362:15652
        canvas.SaveState();
        canvas.RestoreState();


        // View:     elipseView6
        // NodeName: Indicator
        // NodeType: ELLIPSE
        // NodeId:   I65:1335;362:14434;362:15667;362:15653
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 149, 0);
        canvas.Alpha = 1;
        canvas.FillEllipse(944f, -441.99988f, 6f, 6f);
        canvas.RestoreState();


        // View:     frameView96
        // NodeName: Left Side
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14434;362:15667;362:15654
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView97
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14434;362:15667;362:15655
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView98
        // NodeName: Time
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14434;362:15667;362:15655;362:15623
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView191
        // NodeName: 9:41
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14434;362:15667;362:15655;362:15623;362:15615
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Translate(665.4535f, -432.83252f);
        var vector196Builder = new PathBuilder();
        var vector196path = vector196Builder.BuildPath("M3.86719 11.0889C6.55518 11.0889 8.15186 8.98682 8.15186 5.42725C8.15186 4.08691 7.89551 2.95898 7.40479 2.0874C6.69434 0.732422 5.47119 0 3.92578 0C1.62598 0 0 1.54541 0 3.71338C0 5.74951 1.46484 7.229 3.479 7.229C4.7168 7.229 5.72021 6.65039 6.21826 5.64697L6.24023 5.64697C6.24023 5.64697 6.26953 5.64697 6.27686 5.64697C6.2915 5.64697 6.34277 5.64697 6.34277 5.64697C6.34277 8.06396 5.42725 9.50684 3.88184 9.50684C2.97363 9.50684 2.27051 9.00879 2.02881 8.21045L0.146484 8.21045C0.461426 9.94629 1.93359 11.0889 3.86719 11.0889ZM3.93311 5.72754C2.71729 5.72754 1.85303 4.86328 1.85303 3.65479C1.85303 2.47559 2.76123 1.57471 3.94043 1.57471C5.11963 1.57471 6.02783 2.49023 6.02783 3.68408C6.02783 4.86328 5.1416 5.72754 3.93311 5.72754Z");
        canvas.FillPath(vector196path);
        canvas.Translate(665.4535f, -432.83252f);
        var vector197Builder = new PathBuilder();
        var vector197path = vector197Builder.BuildPath("M11.243 10.9863C11.9388 10.9863 12.4148 10.4883 12.4148 9.8291C12.4148 9.1626 11.9388 8.67188 11.243 8.67188C10.5545 8.67188 10.0711 9.1626 10.0711 9.8291C10.0711 10.4883 10.5545 10.9863 11.243 10.9863ZM11.243 5.49316C11.9388 5.49316 12.4148 5.00244 12.4148 4.34326C12.4148 3.67676 11.9388 3.18604 11.243 3.18604C10.5545 3.18604 10.0711 3.67676 10.0711 4.34326C10.0711 5.00244 10.5545 5.49316 11.243 5.49316Z");
        canvas.FillPath(vector197path);
        canvas.Translate(665.4535f, -432.83252f);
        var vector198Builder = new PathBuilder();
        var vector198path = vector198Builder.BuildPath("M19.2706 10.8325L21.0797 10.8325L21.0797 8.8623L22.5079 8.8623L22.5079 7.26562L21.0797 7.26562L21.0797 0.263672L18.4137 0.263672C16.546 3.07617 15.0592 5.42725 14.107 7.17773L14.107 8.8623L19.2706 8.8623L19.2706 10.8325ZM15.8575 7.19971C17.088 5.03174 18.1866 3.2959 19.1974 1.80176L19.2999 1.80176L19.2999 7.30957L15.8575 7.30957L15.8575 7.19971Z");
        canvas.FillPath(vector198path);
        canvas.Translate(665.4535f, -432.83252f);
        var vector199Builder = new PathBuilder();
        var vector199path = vector199Builder.BuildPath("M26.5365 10.8325L28.4262 10.8325L28.4262 0.263672L26.5438 0.263672L23.7826 2.19727L23.7826 4.01367L26.412 2.16797L26.5365 2.16797L26.5365 10.8325Z");
        canvas.FillPath(vector199path);
        canvas.RestoreState();


        // View:     frameView99
        // NodeName: Notification
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14435
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(245, 245, 245);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(640f, -210f, 373f, 106f, 13f);
        canvas.RestoreState();


        // View:     frameView100
        // NodeName: Content
        // NodeType: FRAME
        // NodeId:   I65:1335;362:14435;362:16326
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView34
        // NodeName: Title
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14435;362:16327
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Semibold", 600, FontStyleType.Normal);
        canvas.FontSize = 15f;
        canvas.DrawString(@"Notification Title", 652f, -172f, 119f, 20f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView35
        // NodeName: Description
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14435;362:16328
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 15f;
        canvas.DrawString(@"Notification text would be placed right here. This is where notification text would be placed.", 652f, -150f, 333f, 40f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView101
        // NodeName: Right Item (Dots or Text)
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14435;362:16329
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView192
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14435;362:16331
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(142, 142, 147);
        canvas.Alpha = 1;
        canvas.Translate(978f, -190f);
        var vector200Builder = new PathBuilder();
        var vector200path = vector200Builder.BuildPath("M2.502 0C1.119 0 0 1.119 0 2.5C0 3.857 1.083 4.963 2.435 4.999L2.569 4.999C3.919 4.963 5.002 3.857 5.002 2.5C5.002 1.119 3.882 0 2.502 0");
        canvas.FillPath(vector200path);
        canvas.RestoreState();


        // View:     imageView193
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14435;362:16332
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(142, 142, 147);
        canvas.Alpha = 1;
        canvas.Translate(969.001f, -190f);
        var vector201Builder = new PathBuilder();
        var vector201path = vector201Builder.BuildPath("M2.5 0C1.118 0 0 1.119 0 2.5C0 3.857 1.082 4.963 2.433 4.999L2.567 4.999C3.918 4.963 5 3.857 5 2.5C5 1.119 3.882 0 2.5 0");
        canvas.FillPath(vector201path);
        canvas.RestoreState();


        // View:     imageView194
        // NodeName: Path
        // NodeType: VECTOR
        // NodeId:   I65:1335;362:14435;362:16333
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(142, 142, 147);
        canvas.Alpha = 1;
        canvas.Translate(960f, -190f);
        var vector202Builder = new PathBuilder();
        var vector202path = vector202Builder.BuildPath("M2.5 0C1.119 0 0 1.119 0 2.5C0 3.857 1.083 4.963 2.433 4.999L2.567 4.999C3.919 4.963 5.003 3.857 5.003 2.5C5.003 1.119 3.882 0 2.5 0");
        canvas.FillPath(vector202path);
        canvas.RestoreState();


        // View:     textView36
        // NodeName: now
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14435;362:16334
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 13f;
        canvas.DrawString(@"now", 958f, -197f, 25f, 18f, HorizontalAlignment.Right, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView102
        // NodeName: App Icon + Name
        // NodeType: GROUP
        // NodeId:   I65:1335;362:14435;362:16335
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView37
        // NodeName: App Name
        // NodeType: TEXT
        // NodeId:   I65:1335;362:14435;362:16336
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("SFProText-Regular", 400, FontStyleType.Normal);
        canvas.FontSize = 13f;
        canvas.DrawString(@"FIGMA", 676f, -199f, 41f, 18f, HorizontalAlignment.Left, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView103
        // NodeName: App Icon
        // NodeType: INSTANCE
        // NodeId:   I65:1335;362:14435;362:16337
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(55, 27, 27);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(650f, -200f, 20f, 20f, 4.3333335f);
        canvas.StrokeColor = Color.FromRgb(55, 27, 27);
        canvas.Alpha = 1;
        canvas.StrokeSize = 0;
        canvas.DrawRoundedRectangle(650f, -200f, 20f, 20f, 4.3333335f);
        canvas.RestoreState();


        // View:     rectangleView21
        // NodeName: Mask
        // NodeType: RECTANGLE
        // NodeId:   I65:1335;362:14435;362:16337;362:16290
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(650f, -200f, 20f, 20f, 4.3333335f);
        canvas.RestoreState();


        // View:     rectangleView22
        // NodeName: REPLACE ME
        // NodeType: RECTANGLE
        // NodeId:   I65:1335;362:14435;362:16337;362:16291
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(650f, -200f, 20f, 20f, 4.3333335f);
        canvas.RestoreState();


        // View:     frameView104
        // NodeName: Group 2
        // NodeType: GROUP
        // NodeId:   65:1336
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView105
        // NodeName: iPhone 14 - 1
        // NodeType: FRAME
        // NodeId:   65:1337
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 222, 169);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(632f, -310f, 258.76776f, 560f, 26.540285f);
        canvas.RestoreState();


        // View:     rectangleView23
        // NodeName: image 2
        // NodeType: RECTANGLE
        // NodeId:   65:1338
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(612.0947f, -266.20856f, 299.0205f, 224.26541f, 0f);
        canvas.RestoreState();


        // View:     frameView106
        // NodeName: Frame 1
        // NodeType: FRAME
        // NodeId:   65:1339
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView38
        // NodeName: Discover Restaurants Close to You
        // NodeType: TEXT
        // NodeId:   65:1340
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(16, 16, 16);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 15.92417049407959f;
        canvas.DrawString(@"Discover Restaurants Close to You", 659.86725f, -30.000061f, 202.36969f, 48f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView39
        // NodeName: Get your food delivered to you at the comfort of your home
        // NodeType: TEXT
        // NodeId:   65:1341
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(87, 87, 87);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-Medium", 500, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Get your food delivered to you at the comfort of your home", 663.18475f, 25.962025f, 195.73462f, 35f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView107
        // NodeName: Frame 2
        // NodeType: FRAME
        // NodeId:   65:1342
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(680.4361f, 104.691956f, 162.85309f, 40.559235f, 15.9241705f);
        canvas.RestoreState();


        // View:     textView40
        // NodeName: Get Started
        // NodeType: TEXT
        // NodeId:   65:1343
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Get Started", 730.8626f, 115.97163f, 62f, 17.999992f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView108
        // NodeName: Frame 3
        // NodeType: FRAME
        // NodeId:   65:1344
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(680.4361f, 153.12799f, 161.70142f, 40.559235f, 15.9241705f);
        canvas.StrokeColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.DrawRoundedRectangle(680.4361f, 153.12799f, 161.70142f, 40.559235f, 15.9241705f);
        canvas.RestoreState();


        // View:     textView41
        // NodeName: Login
        // NodeType: TEXT
        // NodeId:   65:1345
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Login", 746.7868f, 164.40764f, 29f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView109
        // NodeName: iPhone 14 - 2
        // NodeType: FRAME
        // NodeId:   65:1346
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(926.59717f, -310f, 258.76782f, 560f, 26.540285f);
        canvas.RestoreState();


        // View:     frameView110
        // NodeName: Frame 7
        // NodeType: FRAME
        // NodeId:   65:1347
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView111
        // NodeName: Frame 6
        // NodeType: FRAME
        // NodeId:   65:1348
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView112
        // NodeName: Frame 4
        // NodeType: FRAME
        // NodeId:   65:1349
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView113
        // NodeName: navigation
        // NodeType: FRAME
        // NodeId:   65:1350
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(943.8483f, -280.20557f, 11.321106f, 11.321075f, 0f);
        canvas.RestoreState();


        // View:     imageView195
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1351
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Translate(945.2634f, -279.26215f);
        var vector203Builder = new PathBuilder();
        var vector203path = vector203Builder.BuildPath("M0 4.24541L8.96253 0L4.71712 8.96253L3.7737 5.18883L0 4.24541Z");
        canvas.FillPath(vector203path);
        canvas.StrokeColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(945.2634f, -279.26215f);
        var vector204Builder = new PathBuilder();
        var vector204path = vector204Builder.BuildPath("M0 4.24541L8.96253 0L4.71712 8.96253L3.7737 5.18883L0 4.24541Z");
        canvas.DrawPath(vector204path);
        canvas.RestoreState();


        // View:     textView42
        // NodeName: Location
        // NodeType: TEXT
        // NodeId:   65:1352
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(5, 5, 5);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.063190460205078f;
        canvas.DrawString(@"Location", 960.20087f, -283.04498f, 44f, 17f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView114
        // NodeName: Frame 5
        // NodeType: FRAME
        // NodeId:   65:1353
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView43
        // NodeName: Lagos, Nigeria
        // NodeType: TEXT
        // NodeId:   65:1354
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Lagos, Nigeria", 943.8483f, -266.045f, 76f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView115
        // NodeName: chevron-down
        // NodeType: FRAME
        // NodeId:   65:1355
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView196
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1356

        // View:     elipseView7
        // NodeName: Ellipse 1
        // NodeType: ELLIPSE
        // NodeId:   65:1357
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(217, 217, 217);
        canvas.Alpha = 1;
        canvas.FillEllipse(1131.9811f, -283.45972f, 35.829346f, 35.829376f);
        canvas.RestoreState();


        // View:     textView44
        // NodeName: Categories
        // NodeType: TEXT
        // NodeId:   65:1358
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Categories", 943.8483f, -171.327f, 60f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView116
        // NodeName: Frame 21
        // NodeType: FRAME
        // NodeId:   65:1359
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView45
        // NodeName: Near You
        // NodeType: TEXT
        // NodeId:   65:1360
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Near You", 943.8483f, -90.37915f, 49f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView46
        // NodeName: See all
        // NodeType: TEXT
        // NodeId:   65:1361
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.962085247039795f;
        canvas.DrawString(@"See all", 1141.4739f, -90.37915f, 27f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView117
        // NodeName: Frame 22
        // NodeType: FRAME
        // NodeId:   65:1362
        canvas.SaveState();
        canvas.RestoreState();


        // View:     textView47
        // NodeName: Popular Restaurants
        // NodeType: TEXT
        // NodeId:   65:1363
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Popular Restaurants", 943.8483f, 102.03793f, 111.00006f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     textView48
        // NodeName: See all
        // NodeType: TEXT
        // NodeId:   65:1364
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.962085247039795f;
        canvas.DrawString(@"See all", 1203.4739f, 102.03793f, 27f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView118
        // NodeName: Frame 14
        // NodeType: FRAME
        // NodeId:   65:1365
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView119
        // NodeName: Frame 11
        // NodeType: FRAME
        // NodeId:   65:1366
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(247, 237, 227);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(943.8483f, -140.80571f, 69.436035f, 34.92417f, 10.526147f);
        canvas.RestoreState();


        // View:     frameView120
        // NodeName: Frame 8
        // NodeType: FRAME
        // NodeId:   65:1367
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView24
        // NodeName: pizza 1
        // NodeType: RECTANGLE
        // NodeId:   65:1368
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(959.7724f, -130.31049f, 13.933655f, 13.933647f, 0f);
        canvas.RestoreState();


        // View:     textView49
        // NodeName: Pizza
        // NodeType: TEXT
        // NodeId:   65:1369
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.962085247039795f;
        canvas.DrawString(@"Pizza", 976.36017f, -132.84364f, 21f, 19f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView121
        // NodeName: Frame 12
        // NodeType: FRAME
        // NodeId:   65:1370
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(242, 248, 234);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1019.2559f, -140.80571f, 76.435974f, 34.92417f, 10.526147f);
        canvas.RestoreState();


        // View:     frameView122
        // NodeName: Frame 9
        // NodeType: FRAME
        // NodeId:   65:1371
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView25
        // NodeName: burger 1
        // NodeType: RECTANGLE
        // NodeId:   65:1372
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(1035.18f, -130.31049f, 13.933594f, 13.933647f, 0f);
        canvas.RestoreState();


        // View:     textView50
        // NodeName: Burger
        // NodeType: TEXT
        // NodeId:   65:1373
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.962085247039795f;
        canvas.DrawString(@"Burger", 1051.7677f, -132.84364f, 28f, 19f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView123
        // NodeName: Frame 13
        // NodeType: FRAME
        // NodeId:   65:1374
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 241, 241);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1101.6635f, -140.80571f, 67.436035f, 34.92417f, 10.526147f);
        canvas.RestoreState();


        // View:     frameView124
        // NodeName: Frame 10
        // NodeType: FRAME
        // NodeId:   65:1375
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView26
        // NodeName: french-fries 1
        // NodeType: RECTANGLE
        // NodeId:   65:1376
        canvas.SaveState();
        canvas.FillColor = Colors.White;
        canvas.FillRoundedRectangle(1117.5876f, -130.31049f, 13.933594f, 13.933647f, 0f);
        canvas.RestoreState();


        // View:     textView51
        // NodeName: Fries
        // NodeType: TEXT
        // NodeId:   65:1377
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.962085247039795f;
        canvas.DrawString(@"Fries", 1134.1755f, -132.84364f, 19f, 19f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView125
        // NodeName: Frame 18
        // NodeType: FRAME
        // NodeId:   65:1378
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(245, 245, 245);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(943.8483f, -226.39813f, 224.4787f, 39.14691f, 11.943128f);
        canvas.RestoreState();


        // View:     frameView126
        // NodeName: Frame 17
        // NodeType: FRAME
        // NodeId:   65:1379
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView127
        // NodeName: Frame 16
        // NodeType: FRAME
        // NodeId:   65:1380
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView128
        // NodeName: search
        // NodeType: FRAME
        // NodeId:   65:1381
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView197
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1382

        // View:     imageView198
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1383

        // View:     textView52
        // NodeName: Search Restaurants...
        // NodeType: TEXT
        // NodeId:   65:1384
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(179, 179, 179);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 10.616113662719727f;
        canvas.DrawString(@"Search Restaurants...", 975.69653f, -215.82477f, 115f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView129
        // NodeName: Frame 15
        // NodeType: FRAME
        // NodeId:   65:1385
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1133.161f, -220.42665f, 28.530762f, 27.203796f, 11.943128f);
        canvas.RestoreState();


        // View:     frameView130
        // NodeName: filter
        // NodeType: FRAME
        // NodeId:   65:1386
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView199
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1387

        // View:     frameView131
        // NodeName: Component 1
        // NodeType: INSTANCE
        // NodeId:   65:1388
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView27
        // NodeName: Rectangle 1
        // NodeType: RECTANGLE
        // NodeId:   I65:1388;17:131
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(217, 217, 217);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(943.8483f, -59.194275f, 153.93365f, 109.478676f, 5.308057f);
        canvas.RestoreState();


        // View:     frameView132
        // NodeName: Frame 20
        // NodeType: FRAME
        // NodeId:   I65:1388;17:132
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1069.2512f, -53.22271f, 21.895752f, 21.895735f, 3.3175354f);
        canvas.RestoreState();


        // View:     frameView133
        // NodeName: bookmark
        // NodeType: FRAME
        // NodeId:   I65:1388;17:133
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView200
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1388;17:134
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Translate(1076.5222f, -47.00233f);
        var vector205Builder = new PathBuilder();
        var vector205path = vector205Builder.BuildPath("M7.35387 9.45498L3.67694 6.82859L0 9.45498L0 1.05055C0 0.771929 0.110683 0.504717 0.3077 0.3077C0.504717 0.110683 0.771929 2.3327e-16 1.05055 0L6.30332 0C6.58194 2.3327e-16 6.84915 0.110683 7.04617 0.3077C7.24319 0.504717 7.35387 0.771929 7.35387 1.05055L7.35387 9.45498Z");
        canvas.FillPath(vector205path);
        canvas.StrokeColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(1076.5222f, -47.00233f);
        var vector206Builder = new PathBuilder();
        var vector206path = vector206Builder.BuildPath("M7.35387 9.45498L3.67694 6.82859L0 9.45498L0 1.05055C0 0.771929 0.110683 0.504717 0.3077 0.3077C0.504717 0.110683 0.771929 2.3327e-16 1.05055 0L6.30332 0C6.58194 2.3327e-16 6.84915 0.110683 7.04617 0.3077C7.24319 0.504717 7.35387 0.771929 7.35387 1.05055L7.35387 9.45498Z");
        canvas.DrawPath(vector206path);
        canvas.RestoreState();


        // View:     textView53
        // NodeName: Olivier Burger
        // NodeType: TEXT
        // NodeId:   I65:1388;17:135
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 9.952606201171875f;
        canvas.DrawString(@"Olivier Burger", 943.8483f, 50.2844f, 69f, 24f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView134
        // NodeName: star
        // NodeType: FRAME
        // NodeId:   I65:1388;17:136
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView201
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1388;17:137
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(232, 150, 60);
        canvas.Alpha = 1;
        canvas.Translate(1088.6588f, 57.085346f);
        var vector207Builder = new PathBuilder();
        var vector207path = vector207Builder.BuildPath("M4.14692 0L5.42832 2.59597L8.29384 3.01481L6.22038 5.03436L6.70972 7.88744L4.14692 6.53969L1.58412 7.88744L2.07346 5.03436L0 3.01481L2.86552 2.59597L4.14692 0Z");
        canvas.FillPath(vector207path);
        canvas.StrokeColor = Color.FromRgb(232, 150, 60);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(1088.6588f, 57.085346f);
        var vector208Builder = new PathBuilder();
        var vector208path = vector208Builder.BuildPath("M4.14692 0L5.42832 2.59597L8.29384 3.01481L6.22038 5.03436L6.70972 7.88744L4.14692 6.53969L1.58412 7.88744L2.07346 5.03436L0 3.01481L2.86552 2.59597L4.14692 0Z");
        canvas.DrawPath(vector208path);
        canvas.RestoreState();


        // View:     textView54
        // NodeName: 4.6
        // NodeType: TEXT
        // NodeId:   I65:1388;17:138
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 8.523242950439453f;
        canvas.DrawString(@"4.6", 1071.5687f, 52.274918f, 14f, 20f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView135
        // NodeName: Frame 19
        // NodeType: FRAME
        // NodeId:   I65:1388;17:139
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView136
        // NodeName: material-symbols:location-on
        // NodeType: INSTANCE
        // NodeId:   I65:1388;17:140
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView202
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1388;17:140;17:108
        canvas.SaveState();
        canvas.StrokeSize = 1;
        canvas.Translate(945.83887f, 72.511856f);
        var vector209Builder = new PathBuilder();
        var vector209path = vector209Builder.BuildPath("M3.98104 4.9763C4.25474 4.9763 4.48912 4.87877 4.68419 4.6837C4.87893 4.48896 4.9763 4.25474 4.9763 3.98104C4.9763 3.70735 4.87893 3.47296 4.68419 3.27789C4.48912 3.08315 4.25474 2.98578 3.98104 2.98578C3.70735 2.98578 3.47313 3.08315 3.27839 3.27789C3.08332 3.47296 2.98578 3.70735 2.98578 3.98104C2.98578 4.25474 3.08332 4.48896 3.27839 4.6837C3.47313 4.87877 3.70735 4.9763 3.98104 4.9763ZM3.98104 9.95261C2.64573 8.81635 1.64848 7.76088 0.989289 6.78618C0.329763 5.81182 0 4.90995 0 4.08057C0 2.83649 0.400261 1.84538 1.20078 1.10723C2.00097 0.369076 2.92773 0 3.98104 0C5.03436 0 5.96111 0.369076 6.7613 1.10723C7.56182 1.84538 7.96209 2.83649 7.96209 4.08057C7.96209 4.90995 7.63249 5.81182 6.97329 6.78618C6.31377 7.76088 5.31635 8.81635 3.98104 9.95261Z");
        canvas.DrawPath(vector209path);
        canvas.RestoreState();


        // View:     textView55
        // NodeName: 5.8km away
        // NodeType: TEXT
        // NodeId:   I65:1388;17:141
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.305635929107666f;
        canvas.DrawString(@"5.8km away", 958.4455f, 68.48819f, 45.781982f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView137
        // NodeName: Component 2
        // NodeType: INSTANCE
        // NodeId:   65:1389
        canvas.SaveState();
        canvas.RestoreState();


        // View:     rectangleView28
        // NodeName: Rectangle 1
        // NodeType: RECTANGLE
        // NodeId:   I65:1389;49:1140
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(217, 217, 217);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1111.052f, -59.194275f, 153.9336f, 109.478676f, 5.308057f);
        canvas.RestoreState();


        // View:     frameView138
        // NodeName: Frame 20
        // NodeType: FRAME
        // NodeId:   I65:1389;49:1141
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1236.455f, -53.222565f, 21.895752f, 21.895735f, 3.3175356f);
        canvas.RestoreState();


        // View:     frameView139
        // NodeName: bookmark
        // NodeType: FRAME
        // NodeId:   I65:1389;49:1142
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView203
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1389;49:1143
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Translate(1243.7261f, -47.002197f);
        var vector210Builder = new PathBuilder();
        var vector210path = vector210Builder.BuildPath("M7.35387 9.45498L3.67694 6.82859L0 9.45498L0 1.05055C0 0.771929 0.110683 0.504717 0.3077 0.3077C0.504717 0.110683 0.771929 2.3327e-16 1.05055 0L6.30332 0C6.58194 2.3327e-16 6.84915 0.110683 7.04617 0.3077C7.24319 0.504717 7.35387 0.771929 7.35387 1.05055L7.35387 9.45498Z");
        canvas.FillPath(vector210path);
        canvas.StrokeColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(1243.7261f, -47.002197f);
        var vector211Builder = new PathBuilder();
        var vector211path = vector211Builder.BuildPath("M7.35387 9.45498L3.67694 6.82859L0 9.45498L0 1.05055C0 0.771929 0.110683 0.504717 0.3077 0.3077C0.504717 0.110683 0.771929 2.3327e-16 1.05055 0L6.30332 0C6.58194 2.3327e-16 6.84915 0.110683 7.04617 0.3077C7.24319 0.504717 7.35387 0.771929 7.35387 1.05055L7.35387 9.45498Z");
        canvas.DrawPath(vector211path);
        canvas.RestoreState();


        // View:     textView56
        // NodeName: French Fries
        // NodeType: TEXT
        // NodeId:   I65:1389;49:1144
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(0, 0, 0);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 9.952606201171875f;
        canvas.DrawString(@"French Fries", 1111.052f, 50.284477f, 61f, 24f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView140
        // NodeName: star
        // NodeType: FRAME
        // NodeId:   I65:1389;49:1145
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView204
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1389;49:1146
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(232, 150, 60);
        canvas.Alpha = 1;
        canvas.Translate(1255.8625f, 57.08546f);
        var vector212Builder = new PathBuilder();
        var vector212path = vector212Builder.BuildPath("M4.14692 0L5.42832 2.59597L8.29384 3.01481L6.22038 5.03436L6.70972 7.88744L4.14692 6.53969L1.58412 7.88744L2.07346 5.03436L0 3.01481L2.86552 2.59597L4.14692 0Z");
        canvas.FillPath(vector212path);
        canvas.StrokeColor = Color.FromRgb(232, 150, 60);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(1255.8625f, 57.08546f);
        var vector213Builder = new PathBuilder();
        var vector213path = vector213Builder.BuildPath("M4.14692 0L5.42832 2.59597L8.29384 3.01481L6.22038 5.03436L6.70972 7.88744L4.14692 6.53969L1.58412 7.88744L2.07346 5.03436L0 3.01481L2.86552 2.59597L4.14692 0Z");
        canvas.DrawPath(vector213path);
        canvas.RestoreState();


        // View:     textView57
        // NodeName: 4.6
        // NodeType: TEXT
        // NodeId:   I65:1389;49:1147
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 8.523242950439453f;
        canvas.DrawString(@"4.6", 1239.7725f, 52.275024f, 14f, 20f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     frameView141
        // NodeName: Frame 19
        // NodeType: FRAME
        // NodeId:   I65:1389;49:1148
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView142
        // NodeName: material-symbols:location-on
        // NodeType: INSTANCE
        // NodeId:   I65:1389;49:1149
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView205
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1389;49:1149;17:108
        canvas.SaveState();
        canvas.StrokeSize = 1;
        canvas.Translate(1112.9335f, 72.51203f);
        var vector214Builder = new PathBuilder();
        var vector214path = vector214Builder.BuildPath("M3.98104 4.9763C4.25474 4.9763 4.48912 4.87877 4.68419 4.6837C4.87893 4.48896 4.9763 4.25474 4.9763 3.98104C4.9763 3.70735 4.87893 3.47296 4.68419 3.27789C4.48912 3.08315 4.25474 2.98578 3.98104 2.98578C3.70735 2.98578 3.47313 3.08315 3.27839 3.27789C3.08332 3.47296 2.98578 3.70735 2.98578 3.98104C2.98578 4.25474 3.08332 4.48896 3.27839 4.6837C3.47313 4.87877 3.70735 4.9763 3.98104 4.9763ZM3.98104 9.95261C2.64573 8.81635 1.64848 7.76088 0.989289 6.78618C0.329763 5.81182 0 4.90995 0 4.08057C0 2.83649 0.400261 1.84538 1.20078 1.10723C2.00097 0.369076 2.92773 0 3.98104 0C5.03436 0 5.96111 0.369076 6.7613 1.10723C7.56182 1.84538 7.96209 2.83649 7.96209 4.08057C7.96209 4.90995 7.63249 5.81182 6.97329 6.78618C6.31377 7.76088 5.31635 8.81635 3.98104 9.95261Z");
        canvas.DrawPath(vector214path);
        canvas.RestoreState();


        // View:     textView58
        // NodeName: 5.8km away
        // NodeType: TEXT
        // NodeId:   I65:1389;49:1150
        canvas.SaveState();
        canvas.FontColor = Color.FromRgb(106, 106, 106);
        canvas.Alpha = 1;
        canvas.Font = new Microsoft.Maui.Graphics.Font("Poppins-SemiBold", 600, FontStyleType.Normal);
        canvas.FontSize = 7.305636405944824f;
        canvas.DrawString(@"5.8km away", 1125.5402f, 68.488365f, 46f, 18f, HorizontalAlignment.Center, VerticalAlignment.Top);
        canvas.RestoreState();


        // View:     rectangleView29
        // NodeName: Rectangle 2
        // NodeType: RECTANGLE
        // NodeId:   65:1390
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(217, 217, 217);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(943.8483f, 133.22281f, 224.26544f, 99.52606f, 5.308057f);
        canvas.RestoreState();


        // View:     frameView143
        // NodeName: Frame 20
        // NodeType: FRAME
        // NodeId:   65:1391
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(1140.2465f, 138.53088f, 21.895752f, 21.895737f, 3.3175356f);
        canvas.RestoreState();


        // View:     frameView144
        // NodeName: bookmark
        // NodeType: FRAME
        // NodeId:   65:1392
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView206
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   65:1393
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Translate(1147.5173f, 144.75128f);
        var vector215Builder = new PathBuilder();
        var vector215path = vector215Builder.BuildPath("M7.35387 9.45498L3.67694 6.82859L0 9.45498L0 1.05055C0 0.771929 0.110683 0.504717 0.3077 0.3077C0.504717 0.110683 0.771929 2.3327e-16 1.05055 0L6.30332 0C6.58194 2.3327e-16 6.84915 0.110683 7.04617 0.3077C7.24319 0.504717 7.35387 0.771929 7.35387 1.05055L7.35387 9.45498Z");
        canvas.FillPath(vector215path);
        canvas.StrokeColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(1147.5173f, 144.75128f);
        var vector216Builder = new PathBuilder();
        var vector216path = vector216Builder.BuildPath("M7.35387 9.45498L3.67694 6.82859L0 9.45498L0 1.05055C0 0.771929 0.110683 0.504717 0.3077 0.3077C0.504717 0.110683 0.771929 2.3327e-16 1.05055 0L6.30332 0C6.58194 2.3327e-16 6.84915 0.110683 7.04617 0.3077C7.24319 0.504717 7.35387 0.771929 7.35387 1.05055L7.35387 9.45498Z");
        canvas.DrawPath(vector216path);
        canvas.RestoreState();


        // View:     frameView145
        // NodeName: Group 1
        // NodeType: GROUP
        // NodeId:   65:1394
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView207
        // NodeName: Rectangle 5
        // NodeType: VECTOR
        // NodeId:   65:1395
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(249, 248, 248);
        canvas.Alpha = 1;
        canvas.Translate(926.59717f, 199.57346f);
        var vector217Builder = new PathBuilder();
        var vector217path = vector217Builder.BuildPath("M0 0L98.5507 0C102.235 0 105.438 2.52784 106.295 6.11132L108.322 14.5948C113.702 37.1061 145.78 36.9627 150.959 14.4041L152.847 6.18065C153.677 2.56371 156.896 0 160.607 0L258.768 0L258.768 52.9652L0 52.9652L0 0Z");
        canvas.FillPath(vector217path);
        canvas.RestoreState();


        // View:     elipseView8
        // NodeName: Ellipse 5
        // NodeType: ELLIPSE
        // NodeId:   65:1396
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.FillEllipse(1036.7394f, 184.97623f, 38.4834f, 38.483414f);
        canvas.RestoreState();


        // View:     frameView146
        // NodeName: vuesax/linear/shop
        // NodeType: INSTANCE
        // NodeId:   65:1397
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView147
        // NodeName: vuesax/linear/shop
        // NodeType: GROUP
        // NodeId:   I65:1397;49:1159
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView148
        // NodeName: shop
        // NodeType: GROUP
        // NodeId:   I65:1397;49:1160
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView208
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1397;49:1161

        // View:     imageView209
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1397;49:1162

        // View:     imageView210
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1397;49:1163

        // View:     imageView211
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1397;49:1164

        // View:     imageView212
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1397;49:1165

        // View:     imageView213
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1397;49:1166

        // View:     frameView149
        // NodeName: vuesax/linear/home-2
        // NodeType: INSTANCE
        // NodeId:   65:1398
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 255, 255);
        canvas.Alpha = 1;
        canvas.FillRoundedRectangle(943.18494f, 210.85315f, 15.924194f, 15.924164f, 0f);
        canvas.RestoreState();


        // View:     frameView150
        // NodeName: vuesax/linear/home-2
        // NodeType: GROUP
        // NodeId:   I65:1398;49:1168
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView151
        // NodeName: home-2
        // NodeType: GROUP
        // NodeId:   I65:1398;49:1169
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView214
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1398;49:1170

        // View:     imageView215
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1398;49:1171

        // View:     imageView216
        // NodeName: Vector 1
        // NodeType: VECTOR
        // NodeId:   I65:1398;49:1172
        canvas.SaveState();
        canvas.FillColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.Translate(944.8438f, 212.1802f);
        var vector218Builder = new PathBuilder();
        var vector218path = vector218Builder.BuildPath("M0 3.98104L5.97156 0L11.9431 3.98104L12.9384 7.96209L11.9431 12.6066L1.65877 13.2701L0 11.6114L0 3.98104Z");
        canvas.FillPath(vector218path);
        canvas.StrokeColor = Color.FromRgb(255, 152, 50);
        canvas.Alpha = 1;
        canvas.StrokeSize = 1;
        canvas.Translate(944.8438f, 212.1802f);
        var vector219Builder = new PathBuilder();
        var vector219path = vector219Builder.BuildPath("M0 3.98104L5.97156 0L11.9431 3.98104L12.9384 7.96209L11.9431 12.6066L1.65877 13.2701L0 11.6114L0 3.98104Z");
        canvas.DrawPath(vector219path);
        canvas.RestoreState();


        // View:     frameView152
        // NodeName: vuesax/linear/category
        // NodeType: INSTANCE
        // NodeId:   65:1399
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView153
        // NodeName: vuesax/linear/category
        // NodeType: GROUP
        // NodeId:   I65:1399;49:1174
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView154
        // NodeName: category
        // NodeType: GROUP
        // NodeId:   I65:1399;49:1175
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView217
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1399;49:1176

        // View:     imageView218
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1399;49:1177

        // View:     imageView219
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1399;49:1178

        // View:     imageView220
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1399;49:1179

        // View:     imageView221
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1399;49:1180

        // View:     frameView155
        // NodeName: vuesax/linear/message
        // NodeType: INSTANCE
        // NodeId:   65:1400
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView156
        // NodeName: vuesax/linear/message
        // NodeType: GROUP
        // NodeId:   I65:1400;49:1182
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView157
        // NodeName: message
        // NodeType: GROUP
        // NodeId:   I65:1400;49:1183
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView222
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1400;49:1184

        // View:     imageView223
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1400;49:1185

        // View:     imageView224
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1400;49:1186

        // View:     imageView225
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1400;49:1187

        // View:     imageView226
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1400;49:1188

        // View:     frameView158
        // NodeName: vuesax/linear/heart
        // NodeType: INSTANCE
        // NodeId:   65:1401
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView159
        // NodeName: vuesax/linear/heart
        // NodeType: GROUP
        // NodeId:   I65:1401;49:1190
        canvas.SaveState();
        canvas.RestoreState();


        // View:     frameView160
        // NodeName: heart
        // NodeType: GROUP
        // NodeId:   I65:1401;49:1191
        canvas.SaveState();
        canvas.RestoreState();


        // View:     imageView227
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1401;49:1192

        // View:     imageView228
        // NodeName: Vector
        // NodeType: VECTOR
        // NodeId:   I65:1401;49:1193

    }
}