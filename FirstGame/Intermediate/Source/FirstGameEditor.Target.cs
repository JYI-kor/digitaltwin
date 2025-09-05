using UnrealBuildTool;

public class FirstGameEditorTarget : TargetRules
{
	public FirstGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FirstGame");
	}
}
