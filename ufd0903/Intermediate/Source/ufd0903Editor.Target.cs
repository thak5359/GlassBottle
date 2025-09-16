using UnrealBuildTool;

public class ufd0903EditorTarget : TargetRules
{
	public ufd0903EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ufd0903");
	}
}
