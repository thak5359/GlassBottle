using UnrealBuildTool;

public class ufd0903ServerTarget : TargetRules
{
	public ufd0903ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ufd0903");
	}
}
