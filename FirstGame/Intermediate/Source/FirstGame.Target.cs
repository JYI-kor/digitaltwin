using UnrealBuildTool;

public class FirstGameTarget : TargetRules
{
	public FirstGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FirstGame");
	}
}
