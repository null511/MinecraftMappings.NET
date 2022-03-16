using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_Ender : JavaEntityTexture
    {
        public Chest_Ender() : base("Chest, Ender")
        {
            AddVersion("ender")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.Chest>();
                //.MapsToBedrockEntity<BedrockEntities.ChestEnder>();
        }
    }
}
