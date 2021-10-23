using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Alex : JavaEntityTexture
    {
        public Alex() : base("Alex")
        {
            AddVersion("alex")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.PlayerSlim>();
                //.MapsToBedrockEntity<BedrockEntities.Alex>();
        }
    }
}
