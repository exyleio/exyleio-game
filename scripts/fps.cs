using Godot;

public partial class fps : Label
{
	public override void _Process(double delta)
	{
		this.Text = string.Format("fps: {0:0.0}", 1 / delta);
	}
}
