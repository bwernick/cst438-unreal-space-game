using UnrealBuildTool;

public class CST438_Space_GameTarget : TargetRules
{
	public CST438_Space_GameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CST438_Space_Game");
	}
}
