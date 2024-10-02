using UnrealBuildTool;

public class RPG_GitClientTarget : TargetRules
{
	public RPG_GitClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("RPG_Git");
	}
}
