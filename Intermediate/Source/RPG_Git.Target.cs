using UnrealBuildTool;

public class RPG_GitTarget : TargetRules
{
	public RPG_GitTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("RPG_Git");
	}
}
