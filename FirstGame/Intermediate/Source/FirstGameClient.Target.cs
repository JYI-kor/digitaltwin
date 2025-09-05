using UnrealBuildTool;

public class FirstGameClientTarget : TargetRules
{
	public FirstGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FirstGame");
	}
}
