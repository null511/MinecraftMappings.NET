using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.EnderDragon
{
    public class Dragon : JavaEntityTexture
    {
        public Dragon() : base("Ender Dragon")
        {
            AddVersion("dragon")
                .WithPath("entity/enderdragon")
                .WithDefaultModel<Java.Models.Entity.Dragon>();
                //.MapsToBedrockEntity<BedrockEntities.Dragon>();
        }
    }
}
