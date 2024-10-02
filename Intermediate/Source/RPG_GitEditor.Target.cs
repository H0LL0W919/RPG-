using UnrealBuildTool;

public class RPG_GitEditorTarget : TargetRules
{
	public RPG_GitEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("RPG_Git");
	}
}
