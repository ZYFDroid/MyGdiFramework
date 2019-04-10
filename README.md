# MyGdiFramework
从网上弄来的关于GDI的代码简单封装了一下方便WinForm使用



内含基本的Gdi调用，以及一些绘图的难点（例如绘制半透明图像，或者绘制旋转后的图像）



使用方法：首先导入GdiSystem.cs



然后

```c#
GdiSystem Gdi;

private void Form1_Load(object sender, EventArgs e)
{
	Gdi = new GdiSystem(this);
}
```



使用一个绘图Timer或线程绘制图像

例如绘制一个绿色的半透明圆，大小和窗口相同

```c#
Brush b = new SolidBrush(Color.FromArgb(127, 127, 255, 0));//创建画笔

private void timer1_Tick(object sender, EventArgs e)
{
	Gdi.Graphics.Clear(Color.Transparent);//先清空之前残留的图像

	Gdi.Graphics.FillEllipse(b, 0, 0, Width, Height);//画一个圆

	Gdi.UpdateWindow();//画完提交
}
```

