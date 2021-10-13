namespace MinecraftMappings.Internal.Models.Entity
{
    public abstract class BedrockEntityModel : EntityModel<BedrockEntityDataVersion>
    {
        protected BedrockEntityModel(string name) : base(name) {}
    }

    public class BedrockEntityDataVersion : EntityModelVersion {}
}
