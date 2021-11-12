using Sandbox;

public partial class NavigatorExampleGame : Sandbox.Game
{

	public NavigatorExampleGame()
	{
		if ( IsClient )
		{
			new Hud();
		}
	}

}
