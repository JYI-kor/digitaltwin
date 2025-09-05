using UnrealBuildTool;

public class FirstGameServerTarget : TargetRules
{
	public FirstGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FirstGame");
	}
}
