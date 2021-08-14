using UnrealBuildTool;

public class MyFirstProjectTarget : TargetRules
{
	public MyFirstProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyFirstProject");
	}
}
