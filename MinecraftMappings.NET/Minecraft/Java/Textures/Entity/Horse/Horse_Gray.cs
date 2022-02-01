using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Gray : JavaEntityTexture
    {
        public Horse_Gray() : base("Horse, Gray")
        {
            AddVersion("horse_gray")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Gray>();
        }
    }
}
