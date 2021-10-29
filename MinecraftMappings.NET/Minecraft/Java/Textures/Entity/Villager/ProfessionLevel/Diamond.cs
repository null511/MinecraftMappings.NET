using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.ProfessionLevel
{
    public class Diamond : JavaEntityTexture
    {
        public Diamond() : base("Diamond")
        {
            AddVersion("diamond")
                .WithPath("entity/villager/profession_level")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Diamond>();
        }
    }
}
