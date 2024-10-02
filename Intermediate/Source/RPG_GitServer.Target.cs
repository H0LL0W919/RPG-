using UnrealBuildTool;

public class RPG_GitServerTarget : TargetRules
{
	public RPG_GitServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("RPG_Git");
	}
}
