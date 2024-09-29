using UnrealBuildTool;

public class RPGEditorTarget : TargetRules
{
	public RPGEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("RPG");
	}
}
