using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Sheep
{
    public class SheepFur : JavaEntityTexture
    {
        public SheepFur() : base("Sheep Fur")
        {
            AddVersion("sheep_fur")
                .WithDefaultModel<Java.Models.Entity.SheepWool>();
                //.MapsToBedrockEntity<BedrockEntities.SheepFur>();
        }
    }
}
