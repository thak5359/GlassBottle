using UnrealBuildTool;

public class ufd0903ClientTarget : TargetRules
{
	public ufd0903ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ufd0903");
	}
}
