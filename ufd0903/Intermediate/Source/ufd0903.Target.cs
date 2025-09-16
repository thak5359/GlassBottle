using UnrealBuildTool;

public class ufd0903Target : TargetRules
{
	public ufd0903Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ufd0903");
	}
}
