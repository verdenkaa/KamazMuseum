using UnrealBuildTool;

public class KamazRES5Target : TargetRules
{
	public KamazRES5Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("KamazRES5");
	}
}
